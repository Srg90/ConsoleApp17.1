using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank<int> bank1 = new Bank<int>("Роберт", 560, 20780.90);
            Bank<string> bank2 = new Bank<string>("Том", "800", 7800.30);
            Bank<double> bank3 = new Bank<double>("Джерри", 205.8 , 9500.20);
            bank1.ShowInfo();
            bank1.Print("Роберт", 560, 20780.90);
            Console.WriteLine();
            bank2.ShowInfo();
            bank2.Print("Том", "800", 7800.30);
            Console.WriteLine();
            bank3.ShowInfo();
            bank3.Print("Джерри", 205.8, 9500.20);



            Console.ReadKey();
        }

    }

    class Bank<T> 
    {
        private string Name;
        private T Number;
        private double Balance;

        public Bank(string name, T number, double balance)
        {
            this.Name = name;
            this.Number = number;
            this.Balance = balance;
        }

        public string NameID
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        
        public T NumberID
        {
            get { return this.Number; }
            set { this.Number = value; }
        }
        
        public double BalanceID
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }

        public void Print<I, E, U>(I value1, E value2, U value3)
        {
            Type tp1 = typeof(I);
            Type tp2 = typeof(E);
            Type tp3 = typeof(U);
            Console.WriteLine("Type:  {0},  {1},  {2}", tp1.Name, tp2.Name, tp3.Name);
            //Console.WriteLine("value = {0}, {1}, {2}", value1, value2, value3);
        }

            public void ShowInfo()
        {
            Console.WriteLine("Информация о клиенте: ");
            Console.WriteLine("ФИО клиента: {0}, номер счета: {1}, баланс: {2}", NameID, NumberID, BalanceID);
        }

    }
}
       
