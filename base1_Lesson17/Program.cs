using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите строковой № счета: ");
            string accountnumber1 = Console.ReadLine(); 
            Console.Write(" Введите балланс счета: ");
            double balans1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Введите ФИО владельца счета: ");
            string namesurename1 = Console.ReadLine();
            Bankaccount<string> bankaccount1 = new Bankaccount<string>(accountnumber1, balans1, namesurename1); //заполнение через getset
            
            Console.Write(" Введите числовой № счета: ");
            int accountnumber2 = Convert.ToInt32(Console.ReadLine());
            
            Bankaccount<int> bankaccount2 = new Bankaccount<int>(accountnumber2, balans1, namesurename1); ////заполнение через getset

            Console.WriteLine(bankaccount1.ToString()); // Вывод на печать (на экран)
            Console.WriteLine(bankaccount2.ToString()); // Вывод на печать (на экран)
            Console.ReadKey();
        }

    }
    class Bankaccount<T>
    {
        T Accountnumber { get; set; }
        double Balans { get; set; }
        string Namesurename { get; set; }
        public Bankaccount (T accountnumber, double balans, string namesurename) 
        {
            Accountnumber = accountnumber;
            Balans = balans;
            Namesurename = namesurename;
        }
        public override string ToString() => $"Accountnumber - {Accountnumber}, Balans - {Balans}, Namesurename - {Namesurename}";

    }
}
