﻿// See https://aka.ms/new-console-template for more information
using RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT;
Console.WriteLine("Welcome to REGEX PROGRAM!\n");
Console.WriteLine("ENTER \n1 FOR VALIDATE FIRSTNAME REGEX PROGRAM \n2 FOR VALIDATE LASTNAME REGEX PROGRAM\n3 FOR VALIDATE EMAIL REGEX PROGRAM\n");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        ValidFirstName nameObj = new ValidFirstName();
        if (nameObj.Validate_Name("Ankush"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 2:
        ValidFirstName lastNameObj = new ValidFirstName();
        if (lastNameObj.Validate_Name("rawat"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 3:
        ValidateEmail EmailObj = new ValidateEmail();
        if (EmailObj.Validate_Email("abc.xyz@bl.co.in"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

}
