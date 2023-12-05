using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp.Clasess
{
    public class User 
    {
        public List<string> save = new List<string>();
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        private string accountNumber;
        public string AccountNumber {
            get {
                return accountNumber;
            }
            set {
                Random rand = new Random();
                accountNumber = Convert.ToString(rand.Next(1000000, 9999999));

            } }
        public double Balance { get; set; }


        public bool Check(string login, string password)
        {
            bool check = false;
            if (login == LoginName && password == Password)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return check;
        }

        public string AddUser(string name, string email, string phoneNumber, string login, string password)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            LoginName = login;
            Password = password;
            this.AccountNumber = AccountNumber;
            Balance = 0;


            string newUser = $"name : {Name} email : {Email} phoneNumber : {PhoneNumber} " +
                $"login : {LoginName} password : {Password} account : {AccountNumber} balance : {Balance}";
            save.Add(newUser);
            return newUser;
        }
        public void UseData()
        {
            int count =0;
            foreach (var data in save)
            {
                Console.WriteLine(data);
                count++;
            }
            if (count > 0)
            {
                Console.WriteLine("All users. ");
            }
            else
            {
                Console.WriteLine("user does not exist.");
            }
        }
    
            public void Delete(string account)
        {
            save.Remove(account);
        }
        public void ShowBalance()
        {
            Console.WriteLine("Your balance : "+Balance);
        }
        public double Deposit(double deposit)
        {
            this.Balance = Balance + deposit;
            return Balance+deposit;
        }

        public string WithdrawMoney(double money)
        {
            string res;
            if (this.Balance > money)
            {
                res = Convert.ToString(this.Balance - money);
                string res2 =""+ res;
                this.Balance = Convert.ToDouble(res2);
                return res;
            }
            else
            {
                res = "Don't enough your money";
                return res;
            }
        }

        
    }
}
