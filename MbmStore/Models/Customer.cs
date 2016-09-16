using System;
using System.Collections.Generic;

namespace MbmStore.Models
{
    public class Customer
    {
        #region Private variables
        private List<string> phoneNumbers = new List<string>();
        private DateTime birthDate;
        private string firstName;
        private string lastName;
        private string address;
        private string zip;
        private string city;
        #endregion

        #region Public properties
        public string FirstName
        {
            get
            {
                return firstName ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    firstName = value;
                }
            }
        }
        public string LastName
        {
            get
            {
                return lastName ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    lastName = value;
                }
            }
        }
        public string Address
        {
            get
            {
                return address ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    address = value;
                }
            }
        }
        public string Zip
        {
            get
            {
                return zip ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    zip = value;
                }
            }
        }
        public string City
        {
            get
            {
                return city ?? string.Empty;
            }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    city = value;
                }
            }
        }
        //public string Phonenumber { get; set; }

        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                int age = calculateAge(value);
                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }
                else
                {
                    birthDate = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return calculateAge(birthDate);
            }
        }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Customer(string firstName, string lastName, string address, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zip = zip;
            City = city;
        }

        /// <summary>
        /// Mehtod for adding a new phone number to the list of phone numbes.
        /// </summary>
        /// <param name="phone"></param>
        public void addPhone(string phone)
        {
            if (phoneNumbers == null)
            {
                phoneNumbers = new List<string>();
            }
            if (string.IsNullOrEmpty(phone) == false)
            {
                phoneNumbers.Add(phone);
            }
        }

        /// <summary>
        /// Method for calculating the age of a customer based on the difference between the specified <paramref name="checkedDate"/> and DateTime.Now.
        /// </summary>
        /// <param name="checkedDate"></param>
        /// <returns></returns>
        private int calculateAge(DateTime checkedDate)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - checkedDate.Year;

            if (now.Month < checkedDate.Month
                || (now.Month == checkedDate.Month && now.Day < checkedDate.Day))
            {
                age--;
            }

            return age;
        }

    }
}