using SafariParkApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafariParkApp
{
    public enum WeaponType
    {
        WaterPistol,
        LaserGun,
        BubbleBlaster
    }
    public class Weapon : IShootable
    {
        private WeaponType _weaponType;
        private string _brand;
        public Weapon(WeaponType type, string brand)
        {
            _weaponType = type;
            _brand = brand;
        }

        //The below is an example of the too many IF / Switch statements and needs to be 
        public override string ToString()
        {
            string result = $"{base.ToString()} - {_brand}";
            switch (_weaponType)
            {
                case WeaponType.WaterPistol:
                    result = "Splash!! " + result;
                     break;
                case WeaponType.BubbleBlaster:
                    result = "Bubbles... " + result;
                    break;
                case WeaponType.LaserGun:
                    result = "Zing!! " + result;
                    break;
            }
            return result;
        }

        public virtual string Shoot()
        {
            return $"Shooting a {_weaponType}";
        }
    }
}


public abstract class Weapon : IShootable

{

    private string _brand;

    public Weapon(string brand)

    {

        _brand = brand;

    }

    public override string ToString()

    {

        return $"{base.ToString()} - {_brand}";

    }



    public virtual string Shoot()

    {

        return $"Shooting a {ToString()}";

    }

}



//public class WaterPistol : Weapon

//{

//    public WaterPistol(string brand) : base(brand)

//    {

//    }

//    public override string Shoot()

//    {

//        return $"Splash!! {base.Shoot()}";

//    }

//}



//public class LaserGun : Weapon

//{

//    public LaserGun(string brand) : base(brand)

//    {

//    }

//    public override string Shoot()

//    {

//        return $"Zing!! {base.Shoot()}";

//    }

//}

//}