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
        private Dictionary<String, int> arguments = null;
        private int head = 0;
        private Random rand = new Random();
        private List<int> values = null;

        public Scheduler()
        {
            values = new List<int>();
            algorithm = new FIFO();
            arguments = new Dictionary<string, int>();
        }

        /// <summary>
        /// available algorithms
        /// </summary>
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

        /// <summary>
        /// generates one new value in the list of values
        /// </summary>
        public void generateValue()
        {
            values.Add(rand.Next(1, 100));
        }

        /// <summary>
        /// generates multiple values for the list of values
        /// </summary>
        public void generateValues()
        {
            values.Clear();

            for (int i = 0; i < 15; i++)
            {
                values.Add(rand.Next(1, 100));
            }
        }

        /// <summary>
        /// returns the list of values
        /// </summary>
        /// <returns></returns>
        public List<int> getValues()
        {
            return values;
        }

        /// <summary>
        /// removes a single values from the list of values
        /// </summary>
        public void removeValue()
        {
            values.RemoveAt(0);
        }

        /// <summary>
        /// sets the direction argument in the dictionary of arguments
        /// </summary>
        /// <param name="direction">-1 for down, 1 for up</param>
        public void setDirection(int direction)
        {
            arguments["direction"] = direction;
        }

        /// <summary>
        /// sets the value of the element in the textbox in the dictionary of arguments
        /// </summary>
        /// <param name="data">the value in the textbox</param>
        public void setStartingData(int data)
        {
            arguments["start"] = data;
        }

        /// <summary>
        /// sort the list of values by some algorithms
        /// </summary>
        /// <param name="selected_algorithm">algorithms to sort by</param>
        public void sortByAlgorithm(ALGORITHMS selected_algorithm)
        {
            switch (selected_algorithm)
            {
                case ALGORITHMS.FIFO:
                    algorithm = new FIFO();
                    break;

                case ALGORITHMS.SSTF:
                    algorithm = new SSTF(arguments);
                    break;

                case ALGORITHMS.SCAN:
                    algorithm = new SCAN(arguments);
                    break;

                case ALGORITHMS.CLOOK:
                    algorithm = new CLOOK();
                    break;

                case ALGORITHMS.LOOK:
                    algorithm = new LOOK();
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