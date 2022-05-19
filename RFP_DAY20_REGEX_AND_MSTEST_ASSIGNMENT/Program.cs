// See https://aka.ms/new-console-template for more information
using RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT;
Console.WriteLine("Welcome to VALIDATE FIRSTNAME REGEX PROGRAM!\n");
ValidFirstName nameObj = new ValidFirstName();
if (nameObj.Validate_Name("Ankush"))
{
Console.WriteLine("Valid");
}
else
{
Console.WriteLine("Invalid");
}
        
