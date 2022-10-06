using Sayeh_To_do_it.Data;
using Sayeh_To_do_it.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.tests.Models
{
    public class TodoTest
    {
        [Fact]
        public void TodoClassTest()
        {
            //Arrange
            string description1 = "Finish assignment";
            string description2 = "Go for walk";

            //Act
            Todo testTodo1 = new Todo(TodoSequencer.NextTodoId(),description1);
            Todo testTodo2 = new Todo(TodoSequencer.NextTodoId(), description2);

            //Assert

            Assert.Equal(description1, testTodo1.Description);
            Assert.Equal(description2, testTodo2.Description);


        }
    }
}
