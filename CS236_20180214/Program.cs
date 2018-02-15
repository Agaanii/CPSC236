using System;

namespace CS236_20180214
{
    class Program
    {
        private static void PrintString(string input)
        {
            Console.WriteLine(input);
            Console.WriteLine(value: input);
        }

        private static int GetSquare(int input)
        {
            return input * input;
        }

        class IntValue
        {
            public IntValue(int m1, int m2, int m3)
            {
                member1 = m1;
                member2 = m2;
                Member3 = m3;
            }
            private int member1;
            public int Member1 {
                get {
                    return member1;
                }
                set {
                    member1 = value;
                }
            }

            public int member2;
            public int Member3 { get; set; }
        }

        private static int GetProduct(IntValue inputs)
        {
            return inputs.Member1 * inputs.member2 * inputs.Member3;
        }

        private static void IncrementValue(ref int value)
        {
            value++;
        }

        private static void IncrementValues(IntValue inputs)
        {
            inputs.Member1++;
            inputs.member2++;
            inputs.Member3++;
        }
        
        static void Main(string[] args)
        {
            PrintString("I'm a string");
            PrintString(GetSquare(5).ToString());
            IntValue ints = new IntValue(1,2,3);
            ints.Member1 = 1;
            ints.member2 = 2;
            ints.Member3 = 3;
            PrintString(GetProduct(ints).ToString());
            IntValue ints2 = new IntValue(m1: 1, m2: 2, m3: 3);
            PrintString(GetProduct(ints2).ToString());

            int i = 0;
            PrintString(i.ToString());
            IncrementValue(ref i);
            PrintString(i.ToString());

            IncrementValues(ints2);
            PrintString(GetProduct(ints2).ToString());

            Console.ReadLine();
        }
    }
}
