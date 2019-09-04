using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
	class terningespil
	{
		static void Main(string[] args)
		{
            //Her initialisere vi vores variabler
            int antalTerninger;
			Console.Write("Hvor mange terninger skal kastes?: ");
			antalTerninger = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] terningarr = new int[antalTerninger];
            int antalslag = 0;
            bool rollDice = true;
            
            //dette while loop gør at den køre indtil vi siger den skal stoppe
            while (rollDice)
            {
                //Her "slår" computeren terningerne og indsætte værdien i vores array
                for (int i = 0; i < terningarr.Length; i++)
                {
                    terningarr[i] = rnd.Next(1, 7);
                }
                Console.WriteLine("[{0}]", string.Join(", ", terningarr)); //viser brugeren slaget

                //Her tjekker den om summen af værdierne i vores array er alle 6'ere
                foreach (int i in terningarr)
                {
                    if (terningarr.Sum()==6*antalTerninger)
                        rollDice = false; //hvis det er sandt stopper den programmet
                    else
                        continue;
                }
                antalslag++;
            }
            Console.WriteLine("du har brugt " + antalslag + " slag på at slå rene seksere");
            
           
            
            
            
            Console.Read();
			
			
			
			

			
			

			

		}
	}
}
