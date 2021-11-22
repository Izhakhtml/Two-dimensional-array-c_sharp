// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using TwoDimensionalArray;
///////////////////////////// exe 1-2-3-4-5
string[,] twoArrayString = new string[3, 6];
int[,] twoArray = new int[4, 4];
void GetTwoArray(int[,] array1)
{

for(int i = 0; i < array1.GetLength(0); i++)
{
        //Console.WriteLine(i);
    for (int j = 0; j < array1.GetLength(1); j++)
    {
        Console.Write(j);
    }
        Console.WriteLine();
    }
}
//GetTwoArray(twoArray);
///////////////////////// exe 6

void GetReplaceIndex(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = j;
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
//GetReplaceIndex(twoArray);

////////////////////////////// exe 7
void GetReplacePlus(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            array[i, j] = j * i;
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
//GetReplacePlus(twoArray);

////////////////////////////// exe 8

void GetRandomNumber(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Random ran = new Random();
            int random = ran.Next(0,10);
            array[i, j] = random;
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}
//GetRandomNumber(twoArray);

////////////////////////////// exe 9
void GetArrayAndPrint(int[,] array)
{
    for(int i=0;i< array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}
//GetArrayAndPrint(twoArray);

////////////////////////////// exe 10
void GetArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = j;
            if (array[i, j] % 2 == 0)
            {
                Console.Write(array[i,j]);
            }
            
        }
        Console.WriteLine();
    }
}
//GetArrayNumbers(twoArray);

//////////////////////////// exe 11
void GetArrayString(string[,] array,string str)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = str;
            if (array[i,j].Length > 4)
            {
                Console.Write(array[i, j]);
            }
            else
            {
                array[i, j] = "try again";
                Console.Write(array[i, j]);
            }
                

        }
        Console.WriteLine();
    }
}
//GetArrayString(twoArrayString,"ffrrf");

//////////////////////////// exe 12-13

void GetArrayClass()
{
    Teacher[] arrayTeacher = new Teacher[]
    {
      new Teacher(65),new Teacher(20),new Teacher(19),new Teacher(26)
    };
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for (int j = 0; j < twoArray.GetLength(1); j++)
        {
            twoArray[i, j] = arrayTeacher[i].age;
            if (twoArray[i, j] > 25)
            {
                Console.Write(twoArray[i, j]);
            }
            else { Console.Write(twoArray[i, j] = 0); }
        }
        Console.WriteLine();
    }
}
//GetArrayClass();
/////////////////////////////// exe 14
void PrintTwoArray()
{
    int[,] twoArray = new int[6, 4];
    for (int i = 0; i < twoArray.GetLength(0); i++)
    {
        for(int j = 0; j < twoArray.GetLength(1); j++)
        {
            Random random = new Random();
            int randomNum = random.Next(0, 5);
            twoArray[i, j] = randomNum;
            twoArray[5,3] = randomNum;
            Console.Write(twoArray[i, j]);
        } 

        Console.WriteLine();
    }
}
//PrintTwoArray();
/////////////////////////////////// building exercise
int[,] arrayBuilding = new int[4,3];
Random random = new Random();
int counter = 0;
void Print()
{
    
    for(int i = 0; i < arrayBuilding.GetLength(0); i++)
    {
        if(i!=0)Console.WriteLine();
        for (int j = 0; j < arrayBuilding.GetLength(1); j++)
        {
            int randomNumber = random.Next(0, 10);
            arrayBuilding[i, j] = randomNumber;
            Console.Write($"{arrayBuilding[i, j]}");
            counter++;
        }
        //Console.WriteLine();
        Console.Write($"how Tenant:{arrayBuilding.GetLength(1)}");
     
    }
           
}
Print();