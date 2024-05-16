namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var passwordlegth = new PasswordLength();
            var passwordnumber = new NumberControll();
            var upperchar = new UpperControll();
            var specialcharacter = new SpecialCharacterControll();

          

            passwordlegth.SetSuccessor(passwordnumber)
                        .SetSuccessor(upperchar)
                        .SetSuccessor(specialcharacter);

            Console.WriteLine("Inserisci una passowrd");
            string password = Console.ReadLine();
            passwordlegth.ProcessNew(password);





            //while (true)
            //{
            //    Console.WriteLine("per riprovare digitare 1");
            //    int a = int.Parse(Console.ReadLine());
            //    if( a == 1)
            //    {
            //        Console.WriteLine("Inserisci una passowrd");
            //        string password2 = Console.ReadLine();
            //        passwordlegth.ProcessNew(password2);
            //    }
            //    else 
            //        break;
            //}
            


        }
    }
}
