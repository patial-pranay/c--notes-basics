internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Hello ");
        Console.WriteLine("Hello World!");


        //single line comment
        /*
         * comment but multi line
         */

        Console.WriteLine("\nVariables");

        int a = 45;
        //float b = 65.56;//give error as no  suffix added and is conisidered double by default ; 
        float c = 34.67f;//no error
        bool b = true;
        long d = 42352;
        string str = "This is a String";
        char e = 'e';
        //string inp_Str = Console.ReadLine();
        //Console.WriteLine(inp_Str);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(str);
        Console.WriteLine(e);



        Console.WriteLine("\nTypeCasting");

        /*
         * char->int->long->float->double
         * Two types of casting 
         * -->implicit: moving up the order i.e. smaller to bigger so automatically done
         * -->Explicit: moving down the orde so must be done manually
         */
        char x = 'A';
        int y = x;// putting smaller x into bigger y ;so implicit
        Console.WriteLine(y);
        int z = (int)6573.22;//here must conver nuber to int as double is bigger i.e. explicit
        Console.WriteLine(z);
        char x1 = (char)y;
        Console.WriteLine(x1);
        //Using METHODS
        string str2 = Convert.ToString(y);//converting int to string using methods
        int y1 = Convert.ToInt32(str2);
        Console.WriteLine("This is a integer converted to string: " + str2);
        Console.WriteLine(y1);



        Console.WriteLine("\nTaking user input");//to avoid repetion when checking op

        //Console.Write("Enter your name:");
        //string name=Console.ReadLine();
        //Console.Write("Enter your age:");
        //string age=Console.ReadLine();
        //Console.WriteLine("Hi "+ name+ "in 4 years you will be " + (Convert.ToInt32(age) + 4));
        ////must add bracket to ensure order ; otherwise it will be converted after print
        //Console.Write("Enter date:");
        //int date = int.Parse(Console.ReadLine());
        //Console.WriteLine("Date after 1 more date will be: "+ (date+1));
        ////Even here when already using int we must add bracket otherwise the plus and print function is carried out first

        Console.WriteLine("\nOperators");

        /*
         * Arithematic + - / *
         * Assignment = -= += /= *=
         * Logical && || !
         * Comparison == < > <= >= != 
         */
        int j = 9;
        int k = j;
        Console.WriteLine(k == j);
        Console.WriteLine(k != j);
        k *= k;
        Console.WriteLine(k == j);
        Console.WriteLine(true && false);
        Console.WriteLine(true || false);


        Console.WriteLine("\nMath class");

        //int a = Math.Sqrt(6);// gives error as sqrt returns double
        int az = Convert.ToInt32(Math.Sqrt(121));
        Console.WriteLine(az);
        Console.WriteLine(Math.Abs(-65));
        Console.WriteLine(Math.Round(56.51));//56.5 stays 56 i.e. rounds to lower side
        Console.WriteLine(Math.Min(32, 43));
        Console.WriteLine(Math.Max(32, 43));


        Console.WriteLine("\nString Operations");

        string s = "This is the String we will be \"Practising\" on";
        Console.WriteLine(s);
        Console.WriteLine(s.ToUpper());
        Console.WriteLine(s.ToLower());
        Console.WriteLine(s);// the origanal line stays as is
        Console.WriteLine(s.IndexOf('S'));
        Console.WriteLine(s.IndexOf('s'));//case sensitivity and returns first insstance
        Console.WriteLine(s.Length);
        Console.WriteLine(s.Substring(5, 37));//length ; make sure to not go out of bounds
        Console.WriteLine(string.Concat(s, "."));
        Console.WriteLine(s);
        string s1 = "Pranay";
        string s2 = "14";
        Console.WriteLine($"Your name is {s1} and the number you selected is {s2}");



        Console.WriteLine("\nCondition Operators");

        //Console.Write("Enter your marks:");
        //int marks = int.Parse(Console.ReadLine());
        //Console.Write("Enter validity:");
        //bool vlty =bool.Parse(Console.ReadLine());

        //if (marks > 60 && vlty) {
        //    Console.WriteLine("You have passed");
        //}

        //else if(marks==60 && vlty)
        //{
        //    Console.WriteLine("Passed on edge");
        //}
        //else if(marks>60 && !vlty)
        //{
        //    Console.WriteLine("Passed but not eligible");
        //}
        //else
        //{
        //    Console.WriteLine("Failed");
        //}

        //switch (marks){
        //    case 60:
        //        Console.WriteLine("Passed on edge");
        //        break;
        //    case 100:
        //        Console.WriteLine("Maximum marks");
        //        break;
        //    default:
        //        Console.WriteLine("Nothing to note");
        //        break;
        //}

        Console.WriteLine("\nLoops");

        int f = 0;
        while (f < 5)
        {
            Console.WriteLine(f + 1);//direct add as no string
            f++;
        }
        Console.WriteLine();
        f = 0;
        do//must add do
        {
            Console.WriteLine(f + 1);
            f++;
        } while (f < 5);
        Console.WriteLine();
        for (int jk = 0; jk <= 10; jk += 2)//to increment by 2 use 
        {
            if (jk == 2)
            {
                continue;//skip the current iteration of loop
            }
            if (jk == 8)
            {
                break;//stop the whole loop
            }
            Console.WriteLine(jk);
        }

        Console.WriteLine("\nMethods");

        Greet();
        Greet("Pranay");


        Console.ReadLine();
    }

    static void Greet()
    {
        Console.WriteLine("Good day");
    }
    static void Greet(String name)//Method Overloading : nt possible for local functions
    {
        Console.WriteLine("Good day " + name);
    }
}