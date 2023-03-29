using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        //1 2 3
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            if (birthDate > date)
            {
                throw new ArgumentException("Error - birthDate is in the future");
            }
            else if (birthDate.Month < date.Month && birthDate.Day < date.Day)
            {
                TimeSpan rAge = date - birthDate;
                var r1AgeInYears = rAge.Days / 365.25 ;
                return Convert.ToInt32(r1AgeInYears);
            }
            else
            {
                TimeSpan rAge = date - birthDate;
                var r2AgeInYears = (rAge.Days / 365.25) - 1;
                return Convert.ToInt32(r2AgeInYears);
            }
;
        }

        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return date.ToString("yy/dd/MMM");
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return date.ToString("MMMM");
        }

        // Adds on years to a give a date and returns a string representation of the new date

        public static string AddYearGetDateString(DateOnly date)
        {
            date = date.AddYears(1);
            return date.ToString("dd MMMM yyyy");
        }

        // Returns a DateOnly instance from the using the date information from a DateTime instance
        public static DateOnly GetDateOnly(DateTime date)
        {
            return DateOnly.FromDateTime(date);
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            string message = "";
            switch (suit)
            {
                case Suit.HEARTS:
                    message = "You've broken my heart";
                    break;
                case Suit.CLUBS:
                    message = "And the seventh rule is if this is your first night at fight club, you have to fight.";
                    break;
                case Suit.DIAMONDS:
                    message = "Diamonds are a girls best friend";
                    break;
                case Suit.SPADES:
                    message = "Bucket and spade";
                    break;
                    default: return null;
            }
            return message;
        }
    }
}
