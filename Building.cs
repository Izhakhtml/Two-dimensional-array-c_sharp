using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionalArray
{
    class Building
    {
        public int[,] arrayBuild;
        public Building(int[,] arrayBuild)
        { this.arrayBuild = arrayBuild; }
        public void GetEvenNumbers()
        {

            Random random = new Random();
            for (int i = 0; i < this.arrayBuild.GetLength(0); i++)
            {
                for (int j = 0; j < this.arrayBuild.GetLength(1); j++)
                {
                    int randomNumber = random.Next(0, 50);
                    if (randomNumber % 2 == 0)
                    {
                        this.arrayBuild[i, j] = randomNumber;
                        Console.Write(this.arrayBuild[i, j]);
                    }
                    else { Console.Write("odd"); }
                }
                Console.WriteLine();
            }
        }
        public void GetEvenNumbersWithArgu(int inputF,int inputL)
        {
            this.arrayBuild = new int[inputF, inputL];
            Random random = new Random();
            for (int i = 0; i < this.arrayBuild.GetLength(0); i++)
            {
                for (int j = 0; j < this.arrayBuild.GetLength(1); j++)
                {
                    int randomNumber = random.Next(0, 50);
                    if (randomNumber % 2 == 0)
                    {
                        this.arrayBuild[i, j] = randomNumber;
                        Console.Write(this.arrayBuild[i, j]);
                    }
                    else{Console.Write("odd");}
                }
                Console.WriteLine();
            }
        }
    }
}
