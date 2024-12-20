using System.Text;

namespace Demo4
{

    internal class Program
    {
        public static void Main(string[] args)


        {
            #region For recording

            //// 1. Array.Sort Example
            //int[] array1 = { 5, 1, 3, 7, 2 };
            //Array.Sort(array1);
            //Console.WriteLine("Sorted Array: " + string.Join(", ", array1));

            //// 2. Array.Copy Example
            //int[] sourceArray = { 10, 20, 30, 40, 50 };
            //int[] destinationArray = new int[5];
            //Array.Copy(sourceArray, destinationArray, 5);
            //Console.WriteLine("Copied Array: " + string.Join(", ", destinationArray));

            //// 3. Array.Length Example
            //Console.WriteLine("Length of the array: " + array1.Length);

            //// 4. Array.Find Example
            //int foundValue = Array.Find(sourceArray, x => x > 30);  // Find first element greater than 30
            //Console.WriteLine("First element greater than 30: " + foundValue);

            //// 5. Array.Reverse Example
            //Array.Reverse(sourceArray);
            //Console.WriteLine("Reversed Array: " + string.Join(", ", sourceArray));
            #endregion
            #region loop statments
            ////Console.WriteLine("1 T");
            ////Console.WriteLine("2 T");
            ////Console.WriteLine(3);
            ////Console.WriteLine(4);
            ////Console.WriteLine(5);
            ////Console.WriteLine(6);
            ////Console.WriteLine(7);
            ////Console.WriteLine(8);
            ////Console.WriteLine(9);
            ////Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(i);
            #endregion
            #region for - for each
            //int[] Numbers = { 1, 2, 3 ,4,5,6,7,8,9,10};
            ////for (int i = 0; i < Numbers.Length; i++)
            ////if (Numbers[i] == 5)
            ////{ continue;
            ////}
            ////{
            ////    Console.WriteLine(Numbers[i]);
            ////}
            ////foreach(int Number in Numbers)
            ////{
            ////    Console.WriteLine(Number);
            ////}
            #endregion
            #region Whlie - Do While
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    //Number = int.Parse(Console.ReadLine());
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //} while (Number % 2 == 1 || !Flag);
            //Console.WriteLine($"{Number}is even");
            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || !Flag);
            //{
            //    Number = int.Parse(Console.ReadLine());
            //       Flag = int.TryParse(Console.ReadLine(), out Number);
            //}


            #endregion
            #region String
            //string Name;
            //Name = new string("Ahmed");
            //Name = "Ahmed";
            //string Name01 = "Ahmed";
            //string Name02 = "Ali";
            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC:{Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC:{Name01.GetHashCode()}");
            //Name02 = Name01;
            //Console.WriteLine("************ Name02 = Mostfa *************");
            //Console.WriteLine($"Name01 HC:{Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC:{Name01.GetHashCode()}");
            //Name01 = "Mostfa";
            #endregion
            #region StringBuilder
            //StringBuilder Message;
            //Message = new StringBuilder("Ahmed");
            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());


            #endregion
            #region StringBuilder Methods
            //StringBuilder Message = new StringBuilder("Welcome");
            //Message.Append("TO route");
            //Message.AppendLine("Mostafa");
            //Message.Append("Hany");

            //Message.Remove(0, 7);
            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);
            //int Age = 10;
            //string  Name= "Ali";
            //Message.AppendFormat("Name:{0}, Age : {1}", Name, Age);

            #endregion
            #region Array 1 D
            //int[] Numbers = new int[3];
            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Numbers[i] = i + 1;
            //}
            //Console.WriteLine("***********");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //    Console.WriteLine(Numbers.Length);
            //    Console.WriteLine(Numbers.Rank);
            //}
            #endregion
            #region 2D Array
            //int[,] Marks = new int[3, 5]; //{ { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 100, 200, 300, 400, 500 } };
            ////Console.WriteLine( Mark.Length );
            ////Console.WriteLine( Mark.Rank );
            ////Console.WriteLine(Mark.GetLength(0));
            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Grade student ({i + 1})");
            //    for (int k = 0; k < Marks.GetLength(1); k++)
            //    {
            //        bool Flag;
            //        Console.WriteLine($"Enter Grade[{k + 1}]");
            //        //Marks[i, k] = int.Parse(Console.ReadLine());
            //        int.TryParse(Console.ReadLine(), out Marks[i,k]);
            //        Flag = int.TryParse(Console.ReadLine(), out Marks[i, k]);

            //        k = Flag && Marks[i, k] != 0 ? ++k : k;

            //    }
            //}
            //Console.Clear();
            //for (int i = 0; i < Marks.GetLength(0); i++) ;
            //{
            //    Console.WriteLine($"Grade Sudent({i + 1})");
            //    for (int k = 0; k < Marks.GetLength(1); k++) ;
            //    {
            //        Console.WriteLine($"Grade[{k + 1}]");
            //        Console.WriteLine();
            //    }
            //}
            #endregion
            #region Judged Array
            int[][] Number = new int[3][];
            Number[0] = new int[3] { 1, 2, 3};
            Number[1] = new int[2] { 4, 5};
            Number[2] = new int[1] {6 };

            for (int i = 0; i < Number.Length; i++)
            {
                for (int j = 0; j > Number[i].Length; j++)

                {
                    Console.WriteLine(Number[i][j]);
                }
            }
            #endregion

        }
    
    }
    }

  
 
