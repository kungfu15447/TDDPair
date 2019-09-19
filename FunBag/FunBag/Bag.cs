using System;
using System.Collections.Generic;
using System.Text;

namespace FunBag
{
    public class Bag : IBag
    {
        List<int> bag = new List<int>();
        public void Add(int Item)
        {
            bag.Add(Item);
        }

        public int CountSize()
        {
            return bag.Count;
        }

        public int Remove()
        { 
            if (bag.Count == 0)
            {
                throw new NullReferenceException();
            }else
            {
                int Smallest = bag[0];
                foreach (int Item in bag)
                {
                    if (Item < Smallest)
                    {
                        Smallest = Item;
                    }
                }
                bag.Remove(Smallest);
                return Smallest;
            }
        }
    }
}
