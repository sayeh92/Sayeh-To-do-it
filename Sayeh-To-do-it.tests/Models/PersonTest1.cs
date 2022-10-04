using Sayeh_To_do_it.Data;
using Sayeh_To_do_it.Models;

namespace Sayeh_To_do_it.tests.Models
{
    public class UnitTest1
    {
        public class UnitTests
        {
            [Theory]
            [InlineData(null)]
            [InlineData("")]
            [InlineData(" ")]
           
            public void FirstNameBadValueTest(string badFirstName)
            {
                //Arrange

                Person testPerson = new Person(PersonSequencer.NextPersonId(), "Jonna", "Lind");

                //Act
                ArgumentException exception = Assert.Throws<ArgumentException>(() => testPerson.FirstName = badFirstName);

                //Assert
                Assert.Contains("Firstname", exception.Message);

            }
            [Theory]
            [InlineData("")]
            [InlineData(" ")]
            [InlineData(null)]
            public void LastNameBadValueTest(string badLastName)
            {
                //Arrange
                Person testPerson = new Person(PersonSequencer.NextPersonId(), "Sam", "Jonsson");

                //Act
                var exception = Assert.Throws<ArgumentException>(() => testPerson.LastName = badLastName);

                //Assert
                Assert.Contains("Lastname", exception.Message);
            }




            [Fact]
            public void PersonClassTest()
            {
                // Arrange
                string firstName1 = "Susy";
                string lastName1 = "Lund";
                string firstName2 = "Melwin";
                string lastName2 = "Carlsson";


                // Act
                Person testPerson1 = new Person(PersonSequencer.NextPersonId(), firstName1, lastName1);
                Person testPerson2 = new Person(PersonSequencer.NextPersonId(), firstName2, lastName2);

                // Assert        
                Assert.Equal(firstName1, testPerson1.FirstName);
                Assert.Equal(lastName1, testPerson1.LastName);
                Assert.Equal(firstName2, testPerson2.FirstName);
                Assert.Equal(lastName2, testPerson2.LastName);


            }
        }
    }
}