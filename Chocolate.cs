using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Chocolate
    {
        public int[,] arrayChocolate;
        public Chocolate(int[,] chocolate)
        {
            this.arrayChocolate = chocolate;
        }
        public void GetRandomNumber()
        {
            Random random = new Random();
            for (int i = 0; i < this.arrayChocolate.GetLength(0); i++)
            {
                for(int j = 0; j < this.arrayChocolate.GetLength(1); j++)
                {
                    int randomNumber = random.Next(0, 100);
                    if (randomNumber > 55) { 
                     arrayChocolate[i, j] = randomNumber;
                     Console.Write(arrayChocolate[i, j]);
                    }
                    else { Console.Write("milk"); }
                }
                    Console.WriteLine();
            }
        }
        public void GetDataFromUser (int fNum,int lNum)
        {
            Random random = new Random();     
            this.arrayChocolate = new int[fNum, lNum];
            for(int i = 0; i < arrayChocolate.GetLength(0); i++)
            {
                for(int j=0; j < arrayChocolate.GetLength(1); j++)
                {
                    int randomNumber = random.Next(0, 100);
                    if (randomNumber > 55)
                    {
                        arrayChocolate[i, j] = randomNumber;
                        Console.Write(arrayChocolate[i, j]);
                    }
                    else { Console.Write("milk"); }
                }
                Console.WriteLine();
            }
        }

    }
}
