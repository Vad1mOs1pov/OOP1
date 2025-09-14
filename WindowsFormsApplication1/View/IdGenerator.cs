using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    internal class IdGenerator
    {
        private static object lockObject = new object();
        private static int currentId = 1;
        public static int GetNextId()
        {
            lock(lockObject)
            {
                return currentId++;
            }
        }

    }
}
