import java.io.PrintStream;
import java.util.Scanner;

import static java.lang.Integer.parseInt;

public class ChequingAccount extends Account {


    Scanner scan = new Scanner(System.in);

    PrintStream ps = new PrintStream(System.out);
    Double money;

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
        System.out.println( checkMessage.concat( (this.getAccountType().equals("1") ? "Chequing" : "Savings") + " account is $").concat(this.accountBalance.toString()).concat(".\n"));
    }


    public void transfer(Double money, String contact) throws Exception{
        System.out.println("How much do you want to transfer?\n");
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

        System.out.println("To whom?");
        if( scan.hasNext()) {
            while (true) {
                try {
                    contact = scan.next();
                    break;
                }catch(Exception ignore) {
                    System.out.println("Invalid contact, please try again...\n");
                }
            }
        }

        if (money!=0)
            if( this.accountBalance >= 0 ) {
                if((accountBalance - money) >= -500) {
                    System.out.println("Processing...\n");
                } else {
                    System.out.println("You don't have enough money to transfer now...\n");
                }
                accountBalance = this.accountBalance - money;
            }
        System.out.println(transferMessage.concat(contact).concat(" ($").concat(money.toString()).concat("). \nYour new account balance is now $").concat(accountBalance.toString()).concat(".\n"));
    }

    public void withdraw(Double money) throws Exception{
        System.out.println("How much do you want to withdraw?\n");
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

        if (money!=0)
            if( this.accountBalance >= 0 ) {
                if((accountBalance - money) >= -500) {
                    System.out.println("Processing...");
                } else {
                    System.out.println("You don't have enough money to withdraw now...\n");
                }
                accountBalance = this.accountBalance - money;
            }
        System.out.println(withdrawMessage.concat(this.accountBalance.toString()).concat(".\n"));
    }

    @Override
    public String toString() {
        return " Account Info:" +
                "\n Account number:" + accountNumber +
                "\n Branch number:" + accountBranch +
                "\n Owner:" + accountOwner  +
                "\n Balance:" + accountBalance +
                "\n Type:" + (accountType.equals("1") ? "Chequing" : "Savings") + '\n';
    }

    public void showChequingAccountMenu() {
        System.out.println("-----------------------------------------------------");
        System.out.println("| 1 - Add funds to your account                     |");
        System.out.println("| 2 - Check your account balance                    |");
        System.out.println("| 3 - Transfer money                                |");
        System.out.println("| 4 - Withdraw                                      |");
        System.out.println("-----------------------------------------------------\n");
    }

    public void bankOperation() throws Exception{
        showChequingAccountMenu();
        Integer option = scan.nextInt();
        switch(option) {
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
            case 4:
                withdraw(money);
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
                if (this.getAccountType().equals("1")) {
                    bankOperation();
                }
            }
            else
                return;

        }while(answer.equals("1"));

    }


}
