package org.dio;

import java.util.Scanner;

import org.dio.exceptions.InvalidParameterException;

public class Counter {

    private Integer firstNumber;
    private Integer secondNumber;

    Scanner scan = new Scanner(System.in);

    public void count() throws InvalidParameterException{

        do {
            System.out.println("You will be asked to type two Integer numbers below\n");
            System.out.println("Type the first number(this is the number in which the counter will start):\n");
            if (scan.hasNext()) {
                String numberString = scan.next();

                while (numberString.isEmpty() || numberString.matches(".*[a-zA-Z\\D].*")) {
                    System.out.println("Please enter a value");
                    try {
                        firstNumber = Integer.parseInt(numberString);
                    } catch (Exception ignore) {
                        System.out.println("Value must be a number, please try again");
                    }
                    numberString = scan.next();
                }
                firstNumber = Integer.parseInt(numberString);
            }

            System.out.println("Type the second number(this is the number in which the counter will stop):\n");
            if (scan.hasNext()) {
                String numberString = scan.next();
                while (numberString.isEmpty() || numberString.matches(".*[a-zA-Z\\D].*")) {
                    System.out.println("Please enter a value");
                    try {
                        secondNumber = Integer.parseInt(numberString);
                    } catch (Exception ignore) {
                        System.out.println("Value must be a number, please try again");
                    }
                    numberString = scan.next();
                }
                secondNumber = Integer.parseInt(numberString);
            }

            try {
                if (validate(firstNumber, secondNumber)) {
                    Integer difference = secondNumber - firstNumber;
                    for (Integer i = firstNumber; i < secondNumber; i++) {
                        System.out.println("Number: " + i.toString().concat(" needs ").concat(difference.toString())
                                .concat(difference.equals(1) ? " interaction " : " interactions " )
                                .concat("to reach ").concat(secondNumber.toString().concat(".")));
                        difference--;
                    }
                    System.out.println("The first number has reached the second.");

                } else {
                    System.out.println("The program encountered a problem, and has been terminated");
                }
            } catch (InvalidParameterException ignore) { // Caught here
                System.out.println("Please try again, providing numbers in correct order");
            }
        } while( firstNumber >= secondNumber );

    }

    public boolean validate(Integer firstNumber, Integer secondNumber) throws InvalidParameterException{
        if (firstNumber >= secondNumber) {
            System.out.println("The second number needs to be greater than the first to ensure that the counter will work correctly");
            throw new InvalidParameterException("The first number is equal or greater than the second, the program has stopped...\n Please start again");
        } else {
            return true;
        }
    }

    public Integer getFirstNumber() {
        return firstNumber;
    }

    public void setFirstNumber(Integer firstNumber) {
        this.firstNumber = firstNumber;
    }

    public Integer getSecondNumber() {
        return secondNumber;
    }

    public void setSecondNumber(Integer secondNumber) {
        this.secondNumber = secondNumber;
    }

}
