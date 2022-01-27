using BasicCoreProgram;

namespace BasicCoreProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Program number which is to be executed \n 1. flipCoin \n 2. LeapYear\n 3. PowOfTwo\n 4. Primefactor\n 5. Exit");

            int option = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                switch (option)
                {
                    case 1:
                        Basicprograms programs = new BasicCoreProgram.Basicprograms();
                        programs.FlipCoin();
                        break;

                    case 2:
                        Basicprograms check = new Basicprograms();
                        check.LeapYear();
                        break;

                    case 3:
                        Basicprograms res = new Basicprograms();
                        res.PowerOfTwo();
                        break;

                    case 4:
                        Basicprograms sum = new Basicprograms();
                        sum.Harmonic();
                        break;

                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
