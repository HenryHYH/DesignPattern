using System;

namespace Pattern.StatePattern
{
    public class RedState : State
    {
        public RedState(State state)
        {
            Balance = state.Balance;
            Account = state.Account;
            Interest = 0.0;
            LowerLimit = -100.0;
            UpperLimit = 0.0;
        }

        public override void Deposit(double amount)
        {
            Balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            Console.WriteLine("没有利息");
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("没钱可取");
        }

        private void StateChangeCheck()
        {
            if (Balance > UpperLimit)
                Account.State = new SilverState(this);
        }
    }
}
