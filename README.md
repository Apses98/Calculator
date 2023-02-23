# Calculator Program

This program is a simple calculator that can perform serial additions and multiplications. The program can handle the following:

- What happens when the equal button is pressed multiple times.
- Division by zero.
- User-friendly handling of numbers that exceed the maximum value of the data type used.
- The program works as a Windows calculator, which means that it does not consider priority rules.
- Automatic calculators are not allowed.

## Requirements

- Microsoft Visual Studio
- .NET Framework

## Usage

1. Clone the repository or download the zip file and extract it.
2. Open the solution file Calculator.sln in Microsoft Visual Studio.
3. Build the solution.
4. Run the program.

## How to Use

The calculator interface has number buttons and sign buttons that you can use to perform calculations. You can enter numbers and signs either by clicking on the buttons with your mouse or by typing them on your keyboard. The following buttons are available:

- Number buttons: 0-9.
- Sign buttons: +, -, x, /.
- Equal button: =.
- Clear button: C.

When you click the equal button, the program performs the calculation and displays the result in the main textbox. If you click the equal button multiple times, the program performs the same calculation again.

If you divide by zero, the program will display an error message. If you enter a number that exceeds the maximum value of the data type used, the program will handle it in a user-friendly way.

The program does not consider priority rules, and it does not support automatic calculators.

## Code Explanation

The program is written in C# and uses the .NET Framework. The program code is well-documented, and the comments explain what each part of the code does.

The program uses two lists to store terms and signs, and it uses an array to store the last number and sign used in the previous calculation. The program checks the input for invalid input, such as two signs used directly after each other or input that starts or ends with a sign.

