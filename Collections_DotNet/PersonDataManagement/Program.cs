using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDataManagement
{
    public class Program
    {
        public static void AddPersonsDetails(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person() { SSN = 1, Name = "Sam" , Age = 15, Address = "13 Main Ct, Newyork, NY" });
            listPersonInCity.Add(new Person() { SSN = 4, Name = "John", Age = 25, Address = "345 Main Ave, Dayton,OH" });
            listPersonInCity.Add(new Person() { SSN = 5, Name = "Elan", Age = 35, Address = "1208 Alex st, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 8, Name = "Sam", Age = 45, Address = "32 Cranbrook Rd, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 3, Name = "Smith", Age = 55, Address = "13 Main Ct, Newyork, NY" });
            listPersonInCity.Add(new Person() { SSN = 10, Name = "Sue", Age = 65, Address = "126 Province Ave, Baltimore,NY" });
            listPersonInCity.Add(new Person() { SSN = 6, Name = "Winston", Age = 65, Address = "13 Main Ct, Newyork, NY" });
            listPersonInCity.Add(new Person() { SSN = 2, Name = "Mac", Age = 85, Address = "12 Main Street, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 9, Name = "Sam", Age = 95, Address = "13 Main Street, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 7, Name = "Miller", Age = 14, Address = "18 Main Street, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 11, Name = "Petter", Age = 75, Address = "15 Main Ct, Newyork,NY" });
            listPersonInCity.Add(new Person() { SSN = 12, Name = "Henery", Age = 45, Address = "45 Cranbrook Rd, Newyork,NY" });
        }

        /// <summary>
        /// UC 1
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void IterateOverList(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity)
            {
                Console.WriteLine("Name\t" + person.Name + "\t" + "Address\t" + person.Address);
            }
        }

        /// <summary>
        /// UC 2 : Retrieve top 2 reecords from list
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void RetriveTop2Records(List<Person> listPersonInCity)
        {
            var result = listPersonInCity.FindAll(x => x.Age<60).OrderBy(x=>x.Age).Take(2);
            foreach (Person person in result)
            {
                Console.WriteLine("Person Name : " + person.Name + " Age " + person.Age);
            }
        }

        /// <summary>
        /// UC 3: 
        /// </summary>
        /// <param name="listPersonInCity"></param>
        public static void FindOutAverageAgeForALL(List<Person> listPersonInCity)
        {
            try
            {
                var result = listPersonInCity.Average(a => a.Age);
                Console.WriteLine("Average age among all person  : \t" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UC 4: 
        /// </summary>
        /// <param name="listPersonsInCity"></param>
        public static void RetrieveTeenagerRecords(List<Person> listPersonsInCity)
        {
            try
            {
                var result = listPersonsInCity.FindAll(x => x.Age > 13 && x.Age <= 18);
                foreach (Person person in result)
                {
                    Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address" + person.Address);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UC 5 :
        /// </summary>
        /// <param name="listPersonsInCity"></param>
        public static Person SearchPerson(List<Person> listPersonsInCity, string name)
        {
            try
            {
                var person = listPersonsInCity.Where(n => n.Name == name).FirstOrDefault();
                if (person != null)
                {
                    Console.WriteLine("Person present.");
                    Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                    return person;
                }
                else
                {
                    Console.WriteLine("Person is not present in the list.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// UC 6 : Skipp whose age is greater than 60 years.
        /// </summary>
        /// <param name="listPersonsInCity"></param>
        public static void SkipLessThanAge60(List<Person> listPersonsInCity)
        {
            var result = listPersonsInCity.FindAll(x => x.Age > 60).Skip(1);
            foreach(Person person in result)
            {
                Console.WriteLine("Age\t" + person.Age + "\t" + "Name\t" + person.Name + "\t" + "Address" + person.Address);
            }
        }



        /// <summary>
        /// UC 6 : 
        /// </summary>
        /// <param name="listPersonsInCity"></param>
        public static void RemovePerson(List <Person> listPersonsInCity)
        {
            var remov = SearchPerson(listPersonsInCity, "Smith");
            bool result = false;
            if (remov!=null)
                {
                    result = listPersonsInCity.Remove(remov);
                    //Console.WriteLine("Removed successfully.");
                }
            if (result)
            {
                Console.WriteLine("Removed successfully!!");
            }
            else
            {
                Console.WriteLine("Not Removed!!");
            }
        }






        /// <summary>
        /// Driver method
        /// </summary>
        /// <param name="args"></param>

            static void Main(string[] args)
            {
                Console.WriteLine("-----Welcome to lambda exoression program-----!");

                List<Person> listPersonInCity = new List<Person>();
                AddPersonsDetails(listPersonInCity);
                SkipLessThanAge60(listPersonInCity);
              //  SearchPerson(listPersonInCity);
                FindOutAverageAgeForALL(listPersonInCity);

            }

    }
}