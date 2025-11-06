namespace AccountManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();

            do
            {

                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Add New Saving Account");
                Console.WriteLine("3. Update Account Info");
                Console.WriteLine("4. Delete Account Info");
                Console.WriteLine("5. Search Account");
                Console.WriteLine("6. Quit");

                char selection = Convert.ToChar(Console.ReadLine());

                switch(selection)
                {
                    case '1':
                        {
                            Console.WriteLine("Enter Id: ");
                            string id = Console.ReadLine();

                            Console.WriteLine("Enter Name: ");
                            string name = Console.ReadLine();

                            Console.WriteLine("Enter Email: ");
                            string email = Console.ReadLine();

                            Console.WriteLine("Enter Password: ");
                            string password = Console.ReadLine();

                            Console.WriteLine("Enter Phone: ");
                            string phone = Console.ReadLine();

                            Console.WriteLine("Enter Age: ");
                            int age = Convert.ToInt32(Console.ReadLine());

                            Account account = new(id, "423432", "OM00000000423432", name, 0, phone, email, password, 30, AccountType.Account);

                            accounts.Add(account);
                            Console.WriteLine("Add Account Successfully");
                        }
                        break;
                }

            } while (true);
        }
    }
}
