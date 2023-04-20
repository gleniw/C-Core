using NUnit.Framework;
using Moq;
using NorthwindBusiness;
using NorthwindData;
using NorthwindData.Services;
using System.Data;

namespace NorthwindTests
{
    public class CustomerManagerShould
    {
        private CustomerManager _sut;

        #region Dummy

        [Test]
        public void BeAbleToBeConstructed()
        {
            //Arrange
            //Create Dummy Object
            var mockCustomerService = new Mock<ICustomerService>(); //Created Dummy Object
            //Act
            _sut = new CustomerManager(mockCustomerService.Object); //Passed in Object - no fields i.e. null if they have them
            //Assert
            Assert.That(_sut, Is.InstanceOf<CustomerManager>());

        }

        //Test Doubles created via MOQ

        #endregion

        #region Stubs

        [Category("Happy")]
        [Test]
        public void ReturnTrue_WhenUpdateIsCalled_WithValidId()
        {
            //Testing if Update Method is called
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(originalCustomer);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert 
            Assert.That(result);

        }

        [Category("Sad")]
        [Test]

        public void ReturnFalse_WhenUpdateIsCalled_WithInvalidId()
        {

            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            // Assert 
            Assert.That(result, Is.False);
        }

        //Return Null as a customer type


        [Category("Happy")]
        [Test]
        public void UpdateSelectedCustomer_WhenUpdateIsCalled_WithValidId()
        {
            //Testing if Update Method is called
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(originalCustomer);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", "Glen Smith", "US", "San Fran","postcode");

            // Assert 
            Assert.That(_sut.SelectedCustomer.ContactName, Is.EqualTo("Glen Smith"));
            Assert.That(_sut.SelectedCustomer.Country, Is.EqualTo("US"));
            Assert.That(_sut.SelectedCustomer.City, Is.EqualTo("San Fran"));
            Assert.That(_sut.SelectedCustomer.PostalCode, Is.EqualTo("postcode"));

        }

        [Category("Sad")]
        [Test]
        public void NotChangeTheSelectedCustomer_WhenUpdateIsCalled_WithInvalidId()
        {
            //Testing if Update Method is called
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", "Glen Smith", "US", "San Fran", "postcode");

            // Assert 

            Assert.That(result, Is.False);

        }


        [Category("Happy")]
        [Test]
        public void DeleteSelectedCustomer_WhenDeleteIsCalled_WithValidId()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(originalCustomer);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Delete("MANDA");

            // Assert 

            Assert.That(result);

        }

        [Category("Sad")]
        [Test]
        public void NoDeletetionOfCustomer_WhenUpdateIsCalled_WithInvalidId()
        {
            //Testing if Update Method is called
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(originalCustomer);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Delete("INVALID");

            // Assert 

            Assert.That(result, Is.False);

        }

        [Category("Sad")]
        [Test]

        public void ReturnFalse_WhenDeletionIsCalled_WithInvalidId()
        {

            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            var originalCustomer = new Customer
            {
                CustomerId = "MANDA"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns((Customer)null);

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Delete("MANDA");

            // Assert 
            Assert.That(result, Is.False);
        }


        #endregion

        #region Throw Exception - MOQ

        [Test]
        [Category("Sad")]

        public void ReturnFalse_WhenUpdateIsCalled_AndDatabaseExceptionIsThrown()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();

            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges()).Throws<DataException>();

            _sut = new CustomerManager(mockCustomerService.Object);

            //Act

            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert

            Assert.That(result, Is.False);
        }

        #endregion

        //We won't cover Fakes

        #region Spies

        //Verify - When I call a method, another method is called

        [Test]

        public void CallSaveCustomerChanges_WhenUpdateIsCallWithValidID()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>(); //MockBehavior.Loose or Strict
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());
            //Assert

            mockCustomerService.Verify(cs => cs.SaveCustomerChanges(), Times.Once); //Times.Exactly(1); Times.Between(0,3), Time.AtLeastOnce

        }

        [Test]

        public void RemoveCustomer_WhenDeleteIsCalledWithValidID()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>();
            var originalCustomer = new Customer
            {
                CustomerId = "MANDA",
                ContactName = "Nish Mandal",
                CompanyName = "Sparta Global",
                City = "Birmingham"
            };

            mockCustomerService.Setup(cs => cs.GetCustomerById("MANDA")).Returns(originalCustomer);
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Delete("MANDA");
            //Assert

            mockCustomerService.Verify(cs => cs.RemoveCustomer(originalCustomer), Times.AtLeastOnce);

        }

        #endregion

        //Loose Behavior - Customer Service has loose behavior

        #region Loose and Strict Behavior

        [Test]

        public void LetsSeeWhatHappens_WhenUpdateIsCalled_IfAllInvocationsArentSetUp()
        {
            //Arrange
            var mockCustomerService = new Mock<ICustomerService>(MockBehavior.Strict);
            mockCustomerService.Setup(cs => cs.GetCustomerById(It.IsAny<string>())).Returns(new Customer());
            mockCustomerService.Setup(cs => cs.SaveCustomerChanges());
            _sut = new CustomerManager(mockCustomerService.Object);

            //Act
            var result = _sut.Update("MANDA", It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

            //Assert
            Assert.That(result);
        }

        #endregion


        //Friday Homework - Call Manager can implements ICallManager and Service Layer (SPS) New Constructor - ICallManager Type
    }
}

