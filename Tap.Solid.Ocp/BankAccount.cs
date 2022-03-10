namespace Tap.Solid.Ocp
{
    public abstract class BankAccount
    {
        public decimal AccountBalance { get;  set; }
        public AccountType AccountType { get; private set; }

        public BankAccount(decimal initialBalance, AccountType accountType)
        {
            AccountBalance = initialBalance;
            AccountType = accountType;
        }

        public abstract void ExtractMoney(decimal value);
    }
    public class RegularBankAccount : BankAccount
    {
        public RegularBankAccount(decimal initialBalance, AccountType accountType) : base(initialBalance, accountType)
        {
        }

        public override void  ExtractMoney(decimal value)
        {
            var comision = 0m;
            comision = value * 0.02m;
            AccountBalance = AccountBalance - (value + comision);
            
        }
    }
    public class GoldBankAccount : BankAccount
    {
        public GoldBankAccount(decimal initialBalance, AccountType accountType) : base(initialBalance, accountType)
        {
           
        }

        public override void ExtractMoney(decimal value)
        {
           var comision = 0m;
            comision = value * 0.01m;
            AccountBalance = AccountBalance - (value + comision);

        }
    }
  
}
