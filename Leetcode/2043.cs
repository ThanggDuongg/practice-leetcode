namespace Leetcode
{
    public class Bank
    {
        public readonly long[] balances;

        public Bank(long[] balance)
        {
            balances = balance;
        }

        public bool Transfer(int account1, int account2, long money)
        {
            if (
                account1 < 1
                || account1 > balances.Length
                || account2 < 1
                || account2 > balances.Length
            )
            {
                return false;
            }
            var account1Money = balances[account1 - 1];
            if (account1Money < money)
            {
                return false;
            }
            balances[account1 - 1] -= money;
            balances[account2 - 1] += money;
            return true;
        }

        public bool Deposit(int account, long money)
        {
            if (account < 1 || account > balances.Length)
            {
                return false;
            }
            balances[account - 1] += money;
            return true;
        }

        public bool Withdraw(int account, long money)
        {
            if (account < 1 || account > balances.Length)
            {
                return false;
            }
            var accountMoney = balances[account - 1];
            if (accountMoney < money)
            {
                return false;
            }
            balances[account - 1] -= money;
            return true;
        }
    }

    /**
     * Your Bank object will be instantiated and called as such:
     * Bank obj = new Bank(balance);
     * bool param_1 = obj.Transfer(account1,account2,money);
     * bool param_2 = obj.Deposit(account,money);
     * bool param_3 = obj.Withdraw(account,money);
     */
}
