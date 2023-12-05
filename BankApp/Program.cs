using BankApp.Clasess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            User user = new User();
            Console.WriteLine("Welcome our BankApp");

            key:
            Console.WriteLine("Ro'yxatdan o'tganmisiz ?\n 1.Enter the website\n 2.Create account\n3.Delete account\n4.show users");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                
                bool check1=true;

                while (check1 == true)
                {
                    check1 = true;
                    Console.WriteLine("Login va parolni kiriting :");
                    Console.Write("Login : ");
                    string login = Console.ReadLine();
                    Console.Write("Passwod : ");
                    string password = Console.ReadLine();
                    
                bool check = user.Check(login, password);
                    //Console.WriteLine(check);
                    if (check == true)
                    {
                        check1 = false;
                        Console.WriteLine("Saytga marhamat");

                        bool check2 = true;
                        while (check2 == true)
                        {
                            check2 = true;
                            Console.WriteLine("1.Deposit money\n2.Your Balance\n3.Withdraw money");
                            int userChoice = Convert.ToInt32(Console.ReadLine());
                            if (userChoice == 1)
                            {
                                Console.WriteLine("How much do you want to add deposit");
                                double deposit = Convert.ToDouble(Console.Read());
                                user.Deposit(deposit);
                                Console.WriteLine("Money is transferred successfully");
                                
                                
                            }
                            
                            else if (userChoice == 2)
                            {
                                user.ShowBalance();
                                
                            }
                            else if (userChoice == 3)
                            {
                                Console.WriteLine("How much do you withdraw money");
                                double money = Convert.ToDouble(Console.ReadLine());
                                double balance;
                                balance = Convert.ToDouble(user.WithdrawMoney(money));
                                Console.WriteLine("Your balance : " + balance);
                                
                            }
                            
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("Qaytadan urinib ko'ring !");
                        check1 = true;
                    }
                    goto key;
                    }
            }
            else if(choice == 2)
            {
                //create account
                Console.Write("Enter your name : ");
                string name = Console.ReadLine();
                Console.Write("Enter your email : ");
                string email = Console.ReadLine();
                Console.WriteLine("Enter your phone number");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Login : ");
                string login = Console.ReadLine();
                Console.WriteLine("Password : ");
                string password = Console.ReadLine();
                user.AddUser(name, email, phoneNumber, login, password);
                Console.WriteLine("You have successfully registered");
                goto key;
            }
            else if(choice == 3)
            {
                //delete account
                Console.Write("Enter your account number : ");
                string account = Console.ReadLine();
                user.Delete(account);
                Console.WriteLine("Deleted was succesfully");
                goto key;
            }
            else if(choice == 4)
            {
                // show about users
                user.UseData();
                goto key;
            }
           

            Console.ReadKey();
        }
    }
}
