import java.io.PrintStream;

public abstract class Account {

    protected String addMessage = "Your account balance has just been added! \n And you now have $";

    protected String checkMessage = "Your current account balance for your ";

    protected String withdrawMessage = "Wait... Your money will soon be ready to withdraw\n Your new account balance is $";

    protected String transferMessage = "Your funds have just been sent to ";


    protected Long accountNumber;
    protected Integer accountBranch;
    protected String accountOwner ;
    protected Double accountBalance;
    protected String accountType;

    public abstract void add(Double money) throws Exception;

    public abstract void transfer(Double money, String contact) throws Exception;

    public abstract void checkBalance(Double accountBalance) throws Exception;

    public Long getAccountNumber() {
        return accountNumber;
    }

    public void setAccountNumber(Long accountNumber) {
        this.accountNumber = accountNumber;
    }

    public Integer getAccountBranch() {
        return accountBranch;
    }

    public void setAccountBranch(Integer accountBranch) {
        this.accountBranch = accountBranch;
    }

    public String getAccountOwner() {
        return accountOwner;
    }

    public void setAccountOwner(String accountOwner) {
        this.accountOwner = accountOwner;
    }

    public Double getAccountBalance() {
        return accountBalance;
    }

    public void setAccountBalance(Double accountBalance) {
        this.accountBalance = accountBalance;
    }

    public String getAccountType() {
        return accountType;
    }

    public void setAccountType(String accountType) {
        this.accountType = accountType;
    }



}
