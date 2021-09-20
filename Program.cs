using System;

namespace bankAccount
{
    public class Client
    {
        private string last;
        private string first;
        private string ID;
        public Client(string lastName, string firstName, string id)
        {
            this.ID = id;
            this.last = lastName;
            this.first = firstName;

        }

        public string Name => $"{last} {first}";
        public string id => $"{ID}";
        public string klant => $"Lastname : {last} firstname: {first} ID: {ID}";

    }

    public class BankAccount
    {
        private string client;
        private string id;
        private int account;


        public BankAccount(string client, string id, int account)
        {
            this.client = client;
            this.id = id;
            this.account = account;
        }

        public string Account => $"{client} {id} {account}";
    }

    public class Access
    {
        public static void Main()
        {
            int balance = 15000;
            Console.WriteLine("Please enter your name");
            string surName = Console.ReadLine();
            Console.WriteLine($"Welcome {surName}. Can I please get your firstname?");
            string voorNaam = Console.ReadLine();
            Console.WriteLine($"{surName} {voorNaam} just one last security check, I require your ID");
            string id = Console.ReadLine();
            var client = new Client(surName, voorNaam, id);
            var naam = client.Name;
            var idNr = client.id;
            var bankAccount = new BankAccount(naam, idNr, 123456789);
            // Console.WriteLine(client);
            Console.WriteLine(client.Name);
            Console.WriteLine(client.klant);
            Console.WriteLine(bankAccount.Account);
            Action(balance);
        }

        private static void Action(int balance)
        {
            Console.WriteLine("Would like you like to: ");
            Console.WriteLine("1. Check your balance");
            Console.WriteLine("2. Make a withdrawel");
            Console.WriteLine("3. Make a deposit");
            Console.WriteLine("4. Get card back");

            int keuze = int.Parse(Console.ReadLine());

            if (keuze == 1)
            {
                Console.WriteLine(balance);
                Action(balance);
            }
            else if (keuze == 2)
            {
                Withdraw(balance);
            }
            else if (keuze == 3)
            {
                Deposit(balance);
            }
            else
            {
                Console.WriteLine("Thank you for your confidence in Becode Bank");
            }
        }

        private static void Withdraw(int balance)
        {
            Console.WriteLine($"How much do you wish to withdraw? Your current balance is {balance}");
            int withdrawel = int.Parse(Console.ReadLine());
            if (withdrawel < balance)
            {
                balance -= withdrawel;
                Console.WriteLine($"you're current balance is {balance}");
                Action(balance);
            }
            else
            {
                Console.WriteLine($"You can not withdraw this amount, max amount possible = {balance}");
                Action(balance);
            }
        }
        private static void Deposit(int balance)
        {
            Console.WriteLine($"How much do you wish to deposit? Your current balance is {balance}");
            int deposit = int.Parse(Console.ReadLine());
            balance += deposit;
            Console.WriteLine($"you're current balance is {balance}");
            Action(balance);
        }
    }
    // public class Example
    // {
    //     public static void Main_example()
    //     {
    //         var client = new Client("Heinen", "Diogo", "006");
    //         var naam = client.Name;
    //         var idNr = client.id;
    //         var bankAccount = new BankAccount(naam,idNr, 123456789);
    //         // Console.WriteLine(client);
    //         Console.WriteLine(client.Name);
    //         Console.WriteLine(client.klant);
    //         Console.WriteLine(bankAccount.Account);
    //     }
    // }
}
