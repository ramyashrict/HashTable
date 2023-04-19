using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Hashtable1
    {

        public class Program
        {
            static void Main(string[] args)
            {
                Hashtable h = new Hashtable();
                h.Add(0, "TO");
                h.Add(1, "BE");
                h.Add(2, "TO");
                h.Add(3, "NOT");
                h.Add(4, "TO");
                h.Add(5, "BE");

                foreach (DictionaryEntry ele in h)
                {
                    Console.WriteLine("{0} and {1} ", ele.Key, ele.Value);
                }
            }
        }
    }
    
