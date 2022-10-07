using Sayeh_To_do_it.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.tests.Data

{
    public class TodoSequencerTest
    {
        //[Fact]
        //public void ResetTodoIdTest()
        //{
          
        //    //Arrange
        //    int expected = 0;
        //    TodoSequencer.NextTodoId = 4;

        //    //Act
        //    TodoSequencer.Reset();


        //    //Assert
        //    Assert.Equal(expected, TodoSequencer.TodoId);

        //}

        [Fact]

        public void NextTodoIdTest()
        {

            //Arrange
            int expectedId1 = 1;
            int expectedId2 = 2;
            int id1;
            int id2;

            //Act
            id1 = TodoSequencer.NextTodoId();
            id2 = TodoSequencer.NextTodoId();


            //Assert
            Assert.Equal(expectedId1, id1);
            Assert.Equal(expectedId2, id2);
        }

    }
   
   

}
