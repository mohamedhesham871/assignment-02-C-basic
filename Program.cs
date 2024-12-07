using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace assignment__02_C__basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Basic

            #region Q1 Write a program that allows the user to enter a number then print it
            //Console.WriteLine("please enter number :");
            //int number= int.Parse(Console.ReadLine());
            //Console.WriteLine($"the number is {number}");
            #endregion


            #region Q2 Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string n = "I Love Codeing";    
            //int x =int.Parse(n);

            //will give you Erro & exception  because can't convert  non-numeric to integer 
            #endregion

            #region Q3 Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float x = 4.3f;
            //float y = 6.5f;
            ////double z = 92.42;

            //// if we using int Or long will casting floating-point numbers  and take all number befor fraction 
            //// waht happen in sum  happen in all arithmetic operation
            //int sum1 = (int) (x+ y);  
            //Console.WriteLine(sum1);// 10

            //float sum2= x + y;
            //Console.WriteLine(sum2);// 10.8

            #endregion

            #region Q4 Write C# program that Extract a substring from a given string
            //string name = "moahemd hesham";
            ////using split function
            //string Fname = name.Split(' ')[0];
            //string Lname = name.Split(' ')[1];
            //// or can use substring function
            //string Subs = name.Substring(0, 7);
            //Console.WriteLine(Subs);
            //Console.WriteLine($"First name is : {Fname} and Last Name is {Lname}");
            #endregion

            #region Q5 Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int num1 = 10;
            //int num2 = num1;
            //num1++;
            //Console.WriteLine($"number one after increment {num1} and number Two {num2}");
            //// second number still have  same value because   we work in Stack not heap and this is value type not reference type 
            #endregion

            #region Q6 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Nodes  node1 = new Nodes();
            //Nodes node2 = new Nodes();
            //node1.FirstNode = 10;
            //node2 = node1;
            //node1.FirstNode = 90;
            //Console.WriteLine($"After increment node1 {node1.FirstNode} and node2 {node2.FirstNode}");
            //// when using reference type they point to same Address  so any change in any one  other has same value 
            #endregion


            #region Q7 Write C# program that take two string variables and print them as one variable 
            //Console.WriteLine("enter First String  and Second String ");
            //string S1=Console.ReadLine(); 
            //string S2=Console.ReadLine();   
            //string concat = S1+S2;  
            //Console.WriteLine($"Final string is : {concat}");
            #endregion


            #region Q8
            //int d;
            //d = Convert.ToInt32(!(30 < 20));

            ////  b)A value 1 will be assigned to d
            ////Because (30 < 20) is False and You Want ( NOt ) so convert True To one 
            #endregion

            #region Q9
            //Console.WriteLine(13 / 2 + " " + 13 % 2);
            //// Answer is  13/2 is integers so 6.5 ==> 6 and 13%2 =1

            ////d)  6 1 
            #endregion

            #region Q10
            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z);
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);
            //// Answer is  7 7
            //// Because condition is True   so it's Pre incremect to num(2) then post increment(5) and Finaly pre to Z(7)
            #endregion
        }
    }
}
