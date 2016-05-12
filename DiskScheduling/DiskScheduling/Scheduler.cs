using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal class Scheduler
    {
        private IAlgorithm algorithm = null;
        private List<int> values = null;

        public Scheduler()
        {
            values = new List<int>();
        }

        public List<int> CreateProcess()
        {
            values.Clear();
            Random myRandom = new Random();

            for (int i = 0; i < 15; i++)
            {
                values.Add(myRandom.Next(1, 100));
            }

            return values;
        }


        public int processPOP()
        {
           return algorithm.pop(values);

        }
        public void processPush(int val){

            algorithm.push(values,val);
        
        }
        public List<int> GetValuesList()
        {
            return values;
        }
        public void removeFromList(int val)
        {
            values.Remove(val);
        }

        public void setAlgorithm(IAlgorithm algorithm)
        {
            this.algorithm = algorithm;
        }
    }
}