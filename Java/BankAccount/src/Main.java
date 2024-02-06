import java.util.Scanner;

import static java.lang.Integer.parseInt;

public class Main {

    public static void main(String[] args) throws Exception {

        Account chequingAccount = new ChequingAccount();

        Account savingsAccount = new SavingsAccount();

        Scanner scan = new Scanner(System.in);

        Account account = new Account() {
            @Override
            public void add(Double money) {
            }

            @Override
            public void transfer(Double money, String contact) {
            }

            @Override
            public void checkBalance(Double accountBalance) {
            }

        };

        chequingAccount.setAccountBalance(500.00);
        savingsAccount.setAccountBalance(500.00);

        System.out.println("What's your account Number?(6 Numerical digits)");


         if (scan.hasNext()) {
            String accountNumber = scan.next();
            while (accountNumber.length() != 6 ) {
                System.out.println("Account number must have 6 numerical digits...");
                try {
                    Long.parseLong(accountNumber);
                } catch (Exception ignore) {
                    System.out.println("Invalid account number, please try again...");
                }
                accountNumber = scan.next();
            }
             account.setAccountNumber(Long.parseLong(accountNumber));
        }

        System.out.println("Enter your account Branch(4 Numerical digits)");

        if( scan.hasNext()) {
            String accountBranch = scan.next();
            while(accountBranch.length() != 4 ) {
                System.out.println("Account branch must have 4 numerical digits...");
                try{
                    Integer.parseInt(accountBranch);
                } catch (Exception ignore) {
                    System.out.println("Invalid account branch, please try again...");
                }
                accountBranch = scan.next();
            }
            account.setAccountBranch(Integer.parseInt(accountBranch));
        }

        System.out.println("What's your name?");

        if(scan.hasNext()) {
            String accountOwner = scan.next();
            while( (accountOwner.length() < 3) || (accountOwner.matches(".*\\d+.*"))) {
                System.out.println("Invalid name, names must have at least three letters, \n and must not contain numbers...");
                try{
                    accountOwner.replaceAll("\\d", "");
                }catch (Exception ignore){
                    System.out.println("Invalid name, names must have at least three letters, \n and must not contain numbers...");
                }
                accountOwner = scan.next();
            }
            account.setAccountOwner(accountOwner);
        }

        if (account.accountOwner != null) {
            do {
                System.out.println("What account do you want to access? \n 1 - Chequing \n 2 - Savings");
                account.setAccountType(scan.next());
            }while (parseInt(account.accountType) > 2);

            if (account.accountType != null && (account.getAccountType().equals("1") || account.getAccountType().equals("2"))) {
                if(account.accountType.equals("1")){
                    chequingAccount.setAccountOwner(account.accountOwner);
                    chequingAccount.setAccountNumber(account.getAccountNumber());
                    chequingAccount.setAccountBranch(account.accountBranch);
                    chequingAccount.setAccountType(account.accountType);
                    System.out.println(chequingAccount.toString());
                }else {
                    savingsAccount.setAccountOwner(account.accountOwner);
                    savingsAccount.setAccountNumber(account.getAccountNumber());
                    savingsAccount.setAccountBranch(account.accountBranch);
                    savingsAccount.setAccountType(account.accountType);
                    System.out.println(savingsAccount.toString());
                }


                    System.out.println("Select one operation from the menu below: ");
                    if (account.accountType.equals("1")) {
                        ((ChequingAccount) chequingAccount).bankOperation();
                        ((ChequingAccount) chequingAccount).callBankOperation();
                    } else {
                        ((SavingsAccount) savingsAccount).bankOperation();
                        ((SavingsAccount) savingsAccount).callBankOperation();
                    }
                }
            }
    }
}