//using Sayeh_To_do_it.Data;
//using Sayeh_To_do_it.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Sayeh_To_do_it.tests.Data
//{
//    public class PeopleServiceTest
//    {
//        [Fact]

//        public void CreateNewPersonTest()
//        {
//            PeopleService testingPeople = new PeopleService();
//            testingPeople.Clear();
//            string firstName1 = "Hanna";
//            string lastName1 = "Ljung";
//            string firstName2 = "Mona";
//            string lastName2 = "Lund";


//            //Act
//            Person testPerson1 = testingPeople.CreateNewPerson(firstName1, lastName1);
//            Person testPerson2 = testingPeople.CreateNewPerson(firstName2, lastName2);

//            //Assert
//            Assert.Equal(firstName1, testPerson1.FirstName);
//            Assert.Equal(lastName1, testPerson1.LastName);

//            Assert.Equal(firstName2, testPerson2.FirstName);
//            Assert.Equal(lastName2, testPerson2.LastName);

//        }


//       /* [Fact]
//        public void FindPersonByIdTest()
//        {
//            //Arrange
//            PeopleService testingPeople = new PeopleService();
//            Person testPerson1 = testingPeople.CreateNewPerson("Fred", "Lindberg");
//            Person testPerson2 = testingPeople.CreateNewPerson("Anna", "Molin");
//            Person testPerson3 = testingPeople.CreateNewPerson("Jens", "Schmidth");
//            int checkedPersonId = testPerson2.PersonId;

//            //Act
//            Person matchedPerson = testingPeople.FindById(checkedPersonId);

//            //Assert
//            Assert.NotEqual(matchedPerson, testPerson1);
//            Assert.Equal(matchedPerson, testPerson2);
//            Assert.NotEqual(matchedPerson, testPerson3);
//        }
//        [Fact]
//        public void SizePersonTest()
//        {
//            //Assert
//            PeopleService testingPeople = new PeopleService();
//            testingPeople.CreateNewPerson("Hanna", "Ljung");
//            testingPeople.CreateNewPerson("Mona", "Lund");

//            int expectedSize = 2;

//            //Act
//            int actualSize = testingPeople.Size();

//            //Assert
//            Assert.Equal(expectedSize, actualSize);
//        }

//        [Fact]
//        public void FindAllPeopleTest()
//        {
//            //Arrange            
//            PeopleService testingPeople = new PeopleService();
//            testingPeople.Clear();

//            testingPeople.CreateNewPerson("Fred", "Lindberg");
//            testingPeople.CreateNewPerson("Anna", "Molin");
//            testingPeople.CreateNewPerson("Jens", "Schmidth");
//            int expectedSize = 3;
//            //Act
//            Person[] foundPersons = testingPeople.FindAll();

//            //Assert
//            Assert.Equal(expectedSize, foundPersons.Length);
//        }

//        [Fact]
//        public void RemovePersonTest()
//        {
//            //Arrange
//            PeopleService testPerson = new PeopleService();

//            Person testPerson1 = testPerson.CreateNewPerson("Maja", "Ljung");
//            Person testPerson2 = testPerson.CreateNewPerson("Ludwig", "Hallberg");
//            Person testPerson3 = testPerson.CreateNewPerson("Anna", "Larsson");


//            //Act
//            testPerson.RemovePerson(testPerson2.PersonId);

//            //Assert
//            Assert.Contains(testPerson1, testPerson.FindAll());
//            Assert.DoesNotContain(testPerson2, testPerson.FindAll());
//            Assert.Contains(testPerson3, testPerson.FindAll());
//        }*/
//    }
//}
