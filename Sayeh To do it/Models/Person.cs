using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.Models
{
    public class Person
    {

        private readonly int _id;
        private string _firstName;
        private string _lastName;


        public Person(int id, string firstName, string lastName)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
        }

        public int Id { get { return _id; } }

        public string FirstName
        {
            get { return _firstName; } //getters
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Can not be null or empty");
                }
                else
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {

            get { return _lastName; } //getters
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Can not be null or empty");
                }
                else
                {
                    _lastName = value;
                }

            }
        }  // setters

    }
}
