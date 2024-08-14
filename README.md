## Try-Catch Example: Number Square Calculator
This C# console application is a simple assignment designed to demonstrate the use of a try-catch block in error handling. The program prompts the user to input a number and then calculates and displays the square of that number. The application handles invalid inputs gracefully using exception handling.
## How It Works
User Input:

The application continuously prompts the user to enter a number.
If the input is valid (i.e., it can be converted to an integer), the program calculates the square of the number and displays it.
Input Validation and Error Handling:

The try-catch block is used to catch any exceptions that occur when converting the input to an integer. If an invalid input is entered (e.g., a non-numeric value), the program catches the exception, displays an error message, and prompts the user to try again until a valid number is entered.
## Purpose
This exercise is a basic assignment to practice the use of try-catch in C# for handling exceptions and ensuring the program continues to run smoothly despite invalid user inputs.

## Example

## Example

```csharp
Bir sayı giriniz: abc
Geçersiz giriş! Lütfen bir sayı giriniz.
Bir sayı giriniz: 5
Girdiğiniz sayının karesi : 25



## Requirements
.NET Core or .NET Framework for compiling and running the C# application.
