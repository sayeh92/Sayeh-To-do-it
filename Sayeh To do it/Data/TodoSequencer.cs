using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.Data
{
    public class TodoSequencer
    {
        private static int _toDoId;

        public static int NextTodoId()
        {
            _toDoId++;
            return _toDoId;
        }

        public static void Reset()
        {
            _toDoId = 0;
        }
    }
}
