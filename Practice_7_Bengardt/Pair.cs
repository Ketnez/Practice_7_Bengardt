using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_7_Bengardt
{
    internal class Pair
    {
        public int First { get; set; }
        public int Second { get; set; }

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }

        public static bool operator true(Pair pair)
        {
            return pair.First == pair.Second;
        }

        public static bool operator false(Pair pair)
        {
            return pair.First == pair.Second;
        }

        public Pair Substract(Pair subtrahend)
        {
            return new Pair(First - subtrahend.First, Second - subtrahend.Second);
        }
    }
}
