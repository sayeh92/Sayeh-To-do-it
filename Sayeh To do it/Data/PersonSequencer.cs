using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayeh_To_do_it.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int PersonId { get { return personId; } }

        public static int NextPersonId()
        {
            personId++;
            return personId;
        }

        public static void ReSet()
        {
            personId = 0;
        }
    }
}
