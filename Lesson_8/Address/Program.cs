﻿namespace Les8
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
        }
    }
    public class Address
    {
        private string index;

        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private string street;

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        private string house;

        public string House
        {
            get { return house; }
            set { house = value; }
        }

        private string apartment;

        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }

}
