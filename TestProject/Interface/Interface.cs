using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.InterfaceTest
{

    class MyInterface
    {
        Boolean flag;
        public MyInterface(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Transaction t1 = new Transaction("001", "8/10/2012", 78900.00);
                Transaction t2 = new Transaction("002", "9/10/2012", 451900.00);
                Transaction t3 = new Transaction();
                t1.showTransaction();
                t2.showTransaction();
                t3.showTransaction();

                Console.ReadKey();
            }
        }
    }
    
    public interface ITransactions
    {
        // 接口成员
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);   // Transaction: 001   002
            Console.WriteLine("Date: {0}", date);           // Date: 8 / 10 / 2012    9 / 10 / 2012
            Console.WriteLine("Amount: {0}", getAmount());  // Amount: 78900  451900
        }
    }
}
