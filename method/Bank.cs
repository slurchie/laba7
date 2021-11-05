using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method
{
    class Bank
    {
        enum account { incorrect, saving, current };
        private int number;
        private account type;
        private decimal balance;
        private static int num = 1;
        public void PutItOnTheAccount(decimal temp)
        {
            Console.WriteLine("Введите сумму, которую хотите положить на счет");
            bool result = decimal.TryParse(Console.ReadLine(), out temp);
            if (result)
            {
                balance += temp;
            }
            else
            {
                Console.WriteLine("Ошибка при вводе баланса");
            }
        }
        public void WithdrawFromTheAccount(decimal temp)
        {
            Console.WriteLine("Введите сумму, которую хотите cнять с счета");
            bool result = Int32.TryParse(Console.ReadLine(), out int tempo);
            //if (result)
            //{
            if (temp <= balance)
            {
                balance -= temp;
            }
            else if (temp > balance)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                Console.WriteLine("Ошибка при вводе баланса");
            }
        }
        public void IncreaseNum()
        {
            number = num++;
        }
        public void Print()
        {
            Console.WriteLine($"Account number: {number}" +$"\n balance: {balance}" +$" \type: {type}");

        }
        public void GetBank_Account()
        {
            Console.WriteLine("Введите баланс:");
            bool result = decimal.TryParse(Console.ReadLine(), out decimal temp1);
            if (result)
            {
                balance = temp1;
            }
            else
            {
                Console.WriteLine("Ошибка при вводе баланса");
            }
            Console.WriteLine("Выберите тип счета: saving или current\nВведите 1 или 2");
            result = Int32.TryParse(Console.ReadLine(), out int temp);
            switch (temp)
            {
                case 1:
                    type = account.saving;
                    break;
                case 2:
                    type = account.current;
                    break;
                default:
                    Console.WriteLine("Нужно вводить только 1 или 2");
                    break;
            }
        }
        public void Transfer(ref Bank from, decimal sum)
        {
            if (sum <= from.balance)
            {
                from.WithdrawFromTheAccount(sum);
                PutItOnTheAccount(sum);
            }
            else
            {
                Console.WriteLine("не получается");
            }

        }
    }
}
