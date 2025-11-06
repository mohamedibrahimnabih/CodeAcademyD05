using System.Xml.Linq;

namespace AccountManagementSystem
{
    //class Utilities<T>
    //{
    //    public static void PrintDetails(List<T> accounts)
    //    {
    //        foreach (var item in accounts)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            //List<SavingAccount> savingAccounts = new List<SavingAccount>();

            //Utilities<Account>.PrintDetails(accounts);
            //Utilities<SavingAccount>.PrintDetails(savingAccounts);

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
                    case '2':
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

                            SavingAccount account = new(id, "423432", "OM00000000423432", name, 0, phone, email, password, 30, 1,AccountType.SavingAccount);

                            accounts.Add(account);
                            Console.WriteLine("Add Saving Account Successfully");
                        }
                        break;
                    case '3':
                        {
                            Console.WriteLine("Enter Your Account Number / Id");
                            string query = Console.ReadLine();

                            bool founded = false;

                            foreach (var item in accounts)
                            {
                                if (item.Id == query || item.AccountNumber == query)
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

                                    item.Id = id;
                                    item.Name = name;
                                    item.Email = email;
                                    item.Password = password;
                                    item.Phone = phone;
                                    item.Age = age;

                                    Console.WriteLine("Update Account Successfully");
                                    founded = true;
                                }
                            }

                            if(!founded)
                                Console.WriteLine("Not Founded Account");
                        }
                        break;
                    case '4':
                        {
                            Console.WriteLine("Enter Your Account Number / Id");
                            string query = Console.ReadLine();

                            bool founded = false;

                            foreach (var item in accounts)
                            {
                                if(item.Id == query || item.AccountNumber == query)
                                {
                                    accounts.Remove(item);
                                    Console.WriteLine("Remove Account Successfully");
                                    founded = true;
                                    break;
                                }
                            }

                            if (!founded)
                                Console.WriteLine("Not Founded Account");
                        }
                        break;
                    case '5':
                        {
                            try
                            {
                                Console.WriteLine("Enter Your Account Number / Id");
                                string query = Console.ReadLine();

                                bool founded = false;

                                foreach (var item in accounts)
                                {
                                    if(item.Id == query || item.AccountNumber == query)
                                    {
                                        Console.WriteLine($"Name: {item.Name}");
                                        Console.WriteLine($"Name: {item.Phone}");
                                        Console.WriteLine($"Name: {item.Id}");
                                        Console.WriteLine($"Name: {item.Balance}");

                                        founded = true;
                                    }
                                }

                                if (!founded)
                                    Console.WriteLine("Not Founded Account");
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        break;
                    case 'Q':
                        {
                            try
                            {
                                Console.WriteLine("Are Your sure? (Y/N)");
                                string choice = Console.ReadLine();

                                if (choice == "Y")
                                    Environment.Exit(0);
                                else
                                    Console.WriteLine("good");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error: {ex.Message}");
                            }
                        }
                        break;
                }

            } while (true);
        }
    }
}
