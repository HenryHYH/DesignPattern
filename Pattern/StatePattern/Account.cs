using System;

namespace Pattern.StatePattern
{
    public class Account
    {
        public State State { get; set; }

        public string Owner { get; private set; }

        public Account(string owner)
        {
            Owner = owner;
            State = new SilverState(0.0, this);
        }

        public double Balance { get { return State.Balance; } }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
            Console.WriteLine("存款金额：{0:C}", amount);
            ShowInfo();
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
            Console.WriteLine("提现金额：{0:C}", amount);
            ShowInfo();
        }

        public void PayInterest()
        {
            State.PayInterest();
            Console.WriteLine("利息支付");
            ShowInfo();
        }

        private void ShowInfo()
        {
            Console.WriteLine("账户余额：{0:C}", Balance);
            Console.WriteLine("账户状态：{0:C}", State.GetType().Name);
            Console.WriteLine();
        }
    }
}
