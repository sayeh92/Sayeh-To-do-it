using Sayeh_To_do_it.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.Data
{
    public class TodoService
    {
         private static Todo[] _toDoArray = new Todo[1];

        public int Size()
        {
            return _toDoArray.Length;
        }

        public Todo[] FindAll()
        {
            return _toDoArray;
        }

        public Todo FindById(int toDoId)
        {
            if (toDoId == null)
            {
                return null;
            }

            var toDo = _toDoArray.FirstOrDefault(x => x.Id == toDoId);

            return toDo;
        }

        public void AddToDo(string Description)
        {
            Todo newToDo = new Todo(TodoSequencer.NextTodoId(), Description);

            _toDoArray = _toDoArray.Append(newToDo).ToArray();
        }

        public void Clear()
        {
            _toDoArray = new Todo[0];
        }

        public Todo[] FindByDoneStatus(bool doneStatus)
        {
            Todo[] newToDoArray = new Todo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if (_toDoArray[i].Done == doneStatus)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }

            return newToDoArray.ToArray();
        }

        public Todo[] FindByAssignee(int personId)
        {
            Todo[] newToDoArray = new Todo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if (_toDoArray[i].Assignee != null && _toDoArray[i].Assignee.Id == personId)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }

            return newToDoArray.ToArray();
        }

      
        public Todo[] FindByAssignee(Person assignee)
        {

            Todo[] newToDoArray = new Todo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if (_toDoArray[i].Assignee == assignee)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }
            return newToDoArray.ToArray();
        }



        public Todo[] FindUnassignedTodoItems()
        {

            Todo[] newToDoArray = new Todo[0];

            for (int i = 0; i < _toDoArray.Length; i++)
            {
                if ( _toDoArray[i].Assignee == null)
                {
                   
                    newToDoArray.Append(newToDoArray[i]);
                }
            }
            return newToDoArray.ToArray();
        }


      /*  public void removeObjectFromArray(int index) 
        {
            ToDo[] newToDoArray = new ToDo[0];
            for (int i = 0; i < toDoList.Length; i++)
            {
                if (index != i)
                {
                    newToDoArray.Append(newToDoArray[i]);
                }
            }
            return newToDoArray.ToArray();
         }*/
          
          public Todo[] RemoveObject(int indexToRemove)
        { 
            _toDoArray = _toDoArray.Where((source, index) => index != indexToRemove).ToArray();

            return _toDoArray;
        }

    }
}
