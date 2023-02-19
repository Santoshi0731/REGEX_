namespace RegexAssig
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("-----------Regex_UC1--------------");

            //Console.WriteLine("Please Enter the name");

            //string value=Console.ReadLine();

            //Regex_UC1 regex = new Regex_UC1();
            //bool val= regex.validateName(value);

            //if(val)
            //{
            //    Console.WriteLine("Name is Match");
            //}
            //else
            //{
            //    Console.WriteLine("Name is not Match");
            //}


            //Console.WriteLine("-----------Regex_UC2--------------");

            //Console.WriteLine("Please Enter the name");

            //string value = Console.ReadLine();

            //Regex_UC2 regex = new Regex_UC2();

            //bool val = regex.validateName(value);

            //if (val)
            //{
            //    Console.WriteLine("Name is Match");
            //}
            //else
            //{
            //    Console.WriteLine("Name is not Match");
            //}

            //Console.WriteLine("-----------Regex_UC3--------------");

            //Console.WriteLine("Please Enter the name");

            //string value = Console.ReadLine();

            //Regex_UC3 regex = new Regex_UC3();

            //bool val = regex.validateName(value);

            //if (val)
            //{
            //    Console.WriteLine("gmail pattern is Match");
            //}
            //else
            //{
            //    Console.WriteLine("gmail pattern is not Match");
            //}

            //Console.WriteLine("-----------Regex_UC3--------------");

            //Console.WriteLine("Please Enter the name");

            //string value = Console.ReadLine();

            //Regex_UC4 regex = new Regex_UC4();

            //bool val = regex.validateName(value);

            //if (val)
            //{
            //    Console.WriteLine("Mobile Number is Match");
            //}
            //else
            //{
            //    Console.WriteLine("Mobile Number is not Match");
            //}

            //Console.WriteLine("-----------Regex_UC5,6,7,8--------------");

            //Console.WriteLine("Please Enter the name");

            //string value = Console.ReadLine();

            ////Regex_UC5 regex = new Regex_UC5();
            ////Regex_UC6 regex = new Regex_UC6();
            ////Regex_UC7 regex = new Regex_UC7();
          
            
            //Regex_UC8 regex = new Regex_UC8();


            //bool val = regex.validateName(value);

            //if (val)
            //{
            //    Console.WriteLine("pincode is Match");
            //}
            //else
            //{
            //    Console.WriteLine("pincode is not Match");
            //}


            Console.WriteLine("-----------Regex_UC3--------------");

            Console.WriteLine("Please Enter the name");

            string value = Console.ReadLine();

            Regex_UC9 regex = new Regex_UC9();

            bool val = regex.validateName(value);

            if (val)
            {
                Console.WriteLine(" Gmail Pattern is Match");
            }
            else
            {
                Console.WriteLine("Gmail Pattern Number is not Match");
            }
        }
    }
}