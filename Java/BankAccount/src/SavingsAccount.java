import java.io.PrintStream;
import java.util.Date;
import java.util.Scanner;

import static java.lang.Integer.parseInt;

public class SavingsAccount extends Account {


    Scanner scan = new Scanner(System.in);
    Double money;
    Integer option;
    String contact;

    public void add(Double money) throws Exception{
            System.out.println("How much money do you want to add?");
            if( scan.hasNext()) {
                while(true) {
                    try {
                        money = Double.parseDouble(scan.next());
                        break;
                    }catch(Exception ignore){
                        System.out.println("Invalid amount, only numbers are allowed\nTry again.");
                    }
                }
            }

            accountBalance = accountBalance += money;
            System.out.println(addMessage.concat(accountBalance.toString()).concat(" available to spend!\n"));
    }

    public void checkBalance(Double accountBalance) throws Exception{
        accountBalance = this.getAccountBalance();
        System.out.println(checkMessage.concat( (this.getAccountType().equals("2") ?  "Savings" : "Chequing") + " account is $" + this.accountBalance.toString()).concat(" with an interest rate of 2%.\n"));
    }

    public void transfer(Double money, String contact) throws Exception{
        System.out.println("How much you need to transfer to Chequing account?");
        if( scan.hasNext()) {
            while(true) {
                try {
                    money = Double.parseDouble(scan.next());
                    break;
                }catch(Exception ignore){
                    System.out.println("Invalid amount, only numbers are allowed\nTry again.");
                }
            }
        }
        if (money != 0)
            if (this.accountBalance >= 0) {
                if ((accountBalance - money) >= -500) {
                    System.out.println("Processing...");
                } else {
                    System.out.println("You don't have enough money to transfer now...");
                }
                accountBalance = this.accountBalance - money;
            }
        System.out.println(transferMessage.concat("your Chequing account.").concat("Your new account balance is now $").concat(accountBalance.toString()).concat(".\n"));
    }

    @Override
    public String toString() {
        return " Account Info:" +
                "\n Account number:" + accountNumber +
                "\n Branch number:" + accountBranch +
                "\n Owner:" + accountOwner  +
                "\n Balance:" + accountBalance +
                "\n Type:" + (accountType.equals("2") ? "Savings" : "Chequing") + '\n';
    }


    public void showSavingsAccountMenu() {
        System.out.println("-----------------------------------------------------");
        System.out.println("| 1 - Add funds to your account                     |");
        System.out.println("| 2 - Check your account balance                    |");
        System.out.println("| 3 - Transfer money to chequing account            |");
        System.out.println("-----------------------------------------------------\n");

    }

    public void bankOperation() throws Exception{
        showSavingsAccountMenu();
        Integer option = scan.nextInt();
        switch (option) {
            case 1:
                add(money);
                break;
            case 2:
                accountBalance = this.getAccountBalance();
                checkBalance(this.accountBalance);
                break;
            case 3:
                transfer(money, contact);
                break;
            default:
                System.out.println("Invalid option\n");
                bankOperation();
                break;


        }
    }

    public void callBankOperation() throws Exception{
        String answer;
        do {
            System.out.println("Do you want to make another operation? \n 1 - Yes\n 2 - No \n");
            answer = scan.next();
            if(Integer.parseInt(answer) > 2) {
                System.out.println("Invalid option, please try again...");
                callBankOperation();
            } else if (answer.equals("1") ) {
                if (this.getAccountType().equals("2")) {
                    bankOperation();
                }
            }
            else
                return;

        }while(answer.equals("1"));

    }
}