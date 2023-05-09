namespace sms.console
{
    internal class StartProgram
    {
        public static void Print()
        {
            Console.Clear();
            Console.WriteLine("[L] - Login   [R] Register   [E] Exit");

            while(true) {
                var input = char.ToUpper(Console.ReadKey().KeyChar);

                switch(input)
                {
                    case 'L':
                        LoginMenu loginMenu = new LoginMenu(); // create an instance of the LoginMenu class
                        loginMenu.Print(); break;
                    case 'R': /*RegisterMenu.Print();*/ break;
                    case 'E': Environment.Exit(0); break;
                    default: break;
                }
            }
        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}