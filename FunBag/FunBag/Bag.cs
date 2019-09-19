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
            if (bag.Count == 0)
            {
                bag.Add(Item);
            } else
            {
                for (int i = 0; i < bag.Count; i++)
                {
                    if (Item > bag[i])
                    {
                        bag.Insert(i, Item);
                        break;
                    }else if (Item < bag[i])
                    {
                        bag.Insert(0, Item);
                        break;
                    }
                }
            }
        }

        public int CountSize()
        {
            return bag.Count;
        }

        public List<int> getBag()
        {
            return bag;
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
