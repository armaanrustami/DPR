using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Dealer
    {
        private List<Tuple<ICarFactory, ICar>> cars;
        private List<ICarFactory> factories;
        private string name;

        public Dealer(string name)
        {
            this.name = name;
            factories = new List<ICarFactory>();
            cars = new List<Tuple<ICarFactory, ICar>>();
        }

        /// <summary>
        /// adds a car to a factory
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="car"></param>
        public void addCar(ICarFactory factory, ICar car)
        {
            cars.Add(new Tuple<ICarFactory, ICar>(factory, car));
        }

        /// <summary>
        /// adds factory to a dealer
        /// </summary>
        /// <param name="factory"></param>
        public void addFactory(ICarFactory factory)
        {
            factories.Add(factory);
        }

        /// <summary>
        /// returns the cars for a factory
        /// </summary>
        /// <param name="factory">factory to gets from</param>
        /// <returns></returns>
        public List<ICar> getCars(ICarFactory factory)
        {
            return cars.Where(t => t.Item1 == factory).Select(t => t.Item2).ToList();
        }

        /// <summary>
        /// returns factories
        /// </summary>
        /// <returns></returns>
        public List<ICarFactory> getFactories()
        {
            return factories;
        }

        /// <summary>
        /// returns name
        /// </summary>
        /// <returns></returns>
        public string getName()
        {
            return name;
        }

        /// <summary>
        /// Log function
        /// </summary>
        /// <returns></returns>
        public string Log()
        {
            string res = name + ":\n";

            foreach (ICarFactory f in factories)
            {
                foreach (ICar c in getCars(f))
                {
                    res += c.ToString() + " from " + f.ToString() + "\n";
                }
            }

            res += "Total factories: " + factories.Count + "\n";
            res += "Total cars: " + cars.Count + "\n";

            return res;
        }

        /// <summary>
        /// Removes a car tuple from the list of (factory, cars)
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="car"></param>
        public void removeCar(ICarFactory factory, ICar car)
        {
            cars.Remove(new Tuple<ICarFactory, ICar>(factory, car));
        }

        /// <summary>
        /// Removes a factory from the dealer with all it's cars.
        /// </summary>
        /// <param name="factory">Factory to purge :@</param>
        public void removeFactory(ICarFactory factory)
        {
            factories.Remove(factory);
            cars.RemoveAll(t => t.Item1.Equals(factory));
        }

        /// <summary>
        /// to string ;)
        /// </summary>
        /// <returns>name</returns>
        public override string ToString()
        {
            return name;
        }
    }
}