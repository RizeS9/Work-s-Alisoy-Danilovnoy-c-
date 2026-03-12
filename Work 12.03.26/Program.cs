using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chel Mell = new Raper("Mellstroy", 9999);
            Mell.MultiplyBalance();
            Mell.Burmalname("Mellstroy");
            Mell.Print();
            Raper nineMice = new Raper("9mice", 676767);
            nineMice.MultiplyBalance();
            nineMice.Burmalname("Bobert");
            nineMice.Voice();
            nineMice.Print();
        }
    }
    public abstract class Chel
    {
        private string _name;
        private int _balance;

        public abstract string Slot { get; }
        public Chel(string name, int balance)
        {
            _name = name;
            _balance = balance;
        }
        public abstract void Voice();
        public virtual void Print()
        {
            Console.WriteLine("Name chela " + _name);
            Console.WriteLine("Balance " + _balance);
        }
        public virtual void Burmalname(string name)
        {
            Console.WriteLine("9" + _name);
        }
        public void MultiplyBalance()
        {
            if (_name == "Mellstroy")
            {
                _balance *= 67;
            }else
            {
                _balance *= 9;
            }
            Console.WriteLine("balance from MultiplyBalance (chel): " + _balance);
        }
    }

    public class Raper : Chel
    {
        public override string Slot => "Dog House";

        public Raper(string name, int balance) : base(name, balance) { }

        public override void Voice()
        {
            Console.WriteLine("еще посидим");
        }

        public override void Burmalname(string name)
        {
            Console.WriteLine("Бурмал" + name);
        }
        public void MultiplyBalance(string name, int balance)
        {
            if (name == "9mice")
            {
                balance *= 67;
               
            }
            else
            {
                balance *= 9;
            }
            Console.WriteLine("balance from MultiplyBalance (raper): " + balance);
        }


    }
}

