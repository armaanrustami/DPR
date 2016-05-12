using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    class Disk_Scheduling
    {

        List<int> Values;
        IAlgorithem algorithem;
       public Disk_Scheduling()
        {

            Values = new List<int>();
        }


        public List<int> CreateProcess()
        {
            Values.Clear();
            Random myRandom = new Random();
            for (int i = 0; i < 15; i++)
            {
                Values.Add(  myRandom.Next(1, 100));
            }

            return Values;
        }
        
        public void setAlgorithem(IAlgorithem algorithem)
        {
            this.algorithem = algorithem;
        }
    }
}
