﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage : IEnumerable
    {
        private Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Toshka", 55);
            carArray[2] = new Car("Vlad", 30);
            carArray[3] = new Car("Bodya", 30);
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return carArray.GetEnumerator();
        //}
        public IEnumerator GetEnumerator()
        {

            return actualImplementation();
            IEnumerator actualImplementation()
            {
                foreach (Car c in carArray)
                {
                    yield return c;
                }
            }

        }

        public IEnumerable GetTheCars(bool returnReversed)
        {

            return actualImplementation();
            IEnumerable actualImplementation()
            {
                if (returnReversed)
                {
                    for (int i = carArray.Length; i != 0; i--)
                    {
                        yield return carArray[i - 1];
                    }
                }
                else
                {
                    foreach (Car c in carArray)
                    {
                        yield return c;
                    }
                }
            }

        }
    }
}
