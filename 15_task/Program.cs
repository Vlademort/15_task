using System;

namespace _15_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число прогрессии: ");
            int start_number = Convert.ToInt32(Console.ReadLine());            
            Console.Write("Введите дельту прогрессии: ");
            int delta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество чисел последовательности прогрессии: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int start_number_2 = 10;


            ArithProgression arithprogression = new ArithProgression(start_number, delta, amount);
            if (delta == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write("арифметическая прогрессия ");
                for (int i = 0; i < amount; i++)
                {                    
                    Console.Write($"{arithprogression.NextValue} ");
                    arithprogression.getNext();
                }
                Console.WriteLine();

                arithprogression.setStart(start_number_2);
                arithprogression.reset();

                Console.Write("арифметическая прогрессия после reset ");
                for (int i = 0; i < amount; i++)
                {
                    Console.Write($"{arithprogression.NextValue} ");
                    arithprogression.getNext();
                }
            }
            Console.WriteLine();
            Console.WriteLine();


            GeomProgression geomprogression = new GeomProgression(start_number, delta, amount);
            if (start_number == 0 || delta == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write("геометрическая прогрессия ");
                for (int i = 0; i < amount; i++)
                {
                    Console.Write($"{geomprogression.NextValue} ");
                    geomprogression.getNext();
                }
                Console.WriteLine();

                geomprogression.setStart(start_number_2);
                geomprogression.reset();

                Console.Write("геометрическая прогрессия после reset ");
                for (int i = 0; i < amount; i++)
                {
                    Console.Write($"{geomprogression.NextValue} ");
                    geomprogression.getNext();
                }
            }

            Console.ReadKey();
        }
    }

    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }

    class ArithProgression : ISeries
    {
        public int StartValue { get; set; }
        public int NextValue { get; set; }
        public int Delta { get; set; }
        public int Amount { get; set; }

        public ArithProgression(int start_value, int delta, int amount)
        {
            StartValue = start_value;
            Delta = delta;
            Amount = amount;
            NextValue = start_value;
        }

        public void setStart(int x)
        {
            StartValue = x;
        }
        public int getNext()
        {
            return NextValue += Delta;
        }
        public void reset()
        {
            NextValue = StartValue;
        }
    }

    class GeomProgression : ISeries
    {
        public int StartValue { get; set; }
        public int NextValue { get; set; }
        public int Delta { get; set; }
        public int Amount { get; set; }


        public GeomProgression(int start_value, int delta, int amount)
        {
            StartValue = start_value;
            Delta = delta;
            Amount = amount;
            NextValue = start_value;
        }

        public void setStart(int x)
        {
            StartValue = x;
        }
        public int getNext()
        {
            return NextValue *= Delta;
        }
        public void reset()
        {
            NextValue = StartValue;
        }
    }
}
