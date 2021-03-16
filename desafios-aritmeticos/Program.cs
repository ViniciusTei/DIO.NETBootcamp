using System;

namespace desafios_aritmeticos
{
    class Program
    {
        static bool checkOutOfRange(double var) {
            bool res = false;

            if(var < 0.00) {
                res = true;
            } else if (var > 10.00) {
                res = true;
            }
            

            return res;
        }
        static void Main(string[] args)
        {
           double a, b, mediaP;
           bool loop = true;
           string userA, userB;

            do
            {
                userA = Console.ReadLine();

                if(userA.Contains(".")) {
                    userA = userA.Replace(".", ",");
                }

                userB = Console.ReadLine();

                if(userB.Contains(".")) {
                    userB = userB.Replace(".", ",");
                }
                
                a = Convert.ToDouble(userA);
                b = Convert.ToDouble(userB);

                

                if(checkOutOfRange(a) || checkOutOfRange(b)) {
                    Console.WriteLine("Variavel out of range.");
                } else {
                    loop = false;
                }

            } while (loop);
            
            //complete com as variaveis
            mediaP = ((a  * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000").Replace(",", "."));
        }
    }

    
}
