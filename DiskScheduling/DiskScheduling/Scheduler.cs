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
        private int head = 0;
        private Random rand = new Random();
        private List<int> values = null;

        public Scheduler()
        {
            values = new List<int>();
            algorithm = new FIFO();
        }

        public enum ALGORITHMS
        {
            FIFO,
            SSTF,
            CLOOK,
            LOOK,
            CSCAN,
            SCAN,
            NONE
        };

        public void generateValue()
        {
            values.Add(rand.Next(1, 100));
        }

        public void generateValues()
        {
            values.Clear();

            for (int i = 0; i < 15; i++)
            {
                values.Add(rand.Next(1, 100));
            }
        }

        public List<int> getValues()
        {
            return values;
        }

        public void removeValue()
        {
            values.RemoveAt(0);
        }

        public void setStartingData(int data)
        {
            head = data;
        }

        public void sortByAlgorithm(ALGORITHMS selected_algorithm)
        {
            switch (selected_algorithm)
            {
                case ALGORITHMS.FIFO:
                    algorithm = new FIFO();
                    break;

                case ALGORITHMS.SSTF:
                    algorithm = new SSTF(head);
                    break;

                case ALGORITHMS.CLOOK:
                    algorithm = new CLOOK();
                    break;

                case ALGORITHMS.LOOK:
                    algorithm = new LOOK();
                    break;

                case ALGORITHMS.SCAN:
                    algorithm = new SCAN();
                    break;

                case ALGORITHMS.CSCAN:
                    algorithm = new CSCAN();
                    break;

                case ALGORITHMS.NONE:
                    throw new ArgumentException("Can't process elements with no selected algorithm.");
                default:
                    throw new ArgumentException("Unknown algorithms: " + selected_algorithm);
            }

            algorithm.sort(values);
        }
    }
}