// See https://aka.ms/new-console-template for more information
using RFP_DAY20_REGEX_AND_MSTEST_ASSIGNMENT;
Console.WriteLine("Welcome to REGEX PROGRAM!\n");
Console.WriteLine("ENTER \n1 FOR VALIDATE FIRSTNAME REGEX PROGRAM \n2 FOR VALIDATE LASTNAME REGEX PROGRAM\n3 FOR VALIDATE EMAIL REGEX PROGRAM\n4 FOR VALIDATE MOBILE REGEX PROGRAM \n5 FOR VALIDATE PASSWORD MINIMUM 8 CHARACTERS REGEX PROGRAM\n6 FOR VALIDATE PASSWORD ATLEAST 1 UPPERCASE CHARACTERS REGEX PROGRAM\n7 FOR VALIDATE PASSWORD ATLEAST 1 NUMERIC CHARACTERS REGEX PROGRAM\n8 FOR VALIDATE PASSWORD ATLEAST 1 SPECIAL CHARACTERS REGEX PROGRAM\n9 FOR VALIDATE EMAIL SAMPLE REGEX PROGRAM\n");
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

    case 4:
        ValidateMobile MobileObj = new ValidateMobile();    
        if(MobileObj.Validate_Mobile("91 8734233456"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 5:
        ValidatePassword PasswordObj = new ValidatePassword();
        if(PasswordObj.Password("%Ankush4u344&"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 6:
        PasswordMin1UpperCase PwdUpperObj = new PasswordMin1UpperCase();
        if(PwdUpperObj.PwdUpperCase("Ankush234"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 7:
        PasswordMin1Num PwdMin1NumObj = new PasswordMin1Num();
        if (PwdMin1NumObj.Min1NumPwd("anKush234"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;


    case 8:
        PWD_Special_Char Min1SpecialCharObj = new PWD_Special_Char();
        if (Min1SpecialCharObj.one_SpecialChar_Pwd("AnkushRA4u@"))
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
        break;

    case 9:
        EmailSamples EmailSamplesObj = new EmailSamples();
        string[] EmailArray = new string[]
        {
          "abc@yahoo.com",
          "abc-100@yahoo.com",
          "abc.100@yahoo.com",
          "abc111@abc.com",
          "abc-100@abc.net",
          "abc.100@abc.com.au",
          "abc@1.com",
          "abc@gmail.com.com",
          "abc+100@gmail.com"
        };

        foreach(string i in EmailArray)
        {

        if (EmailSamplesObj.emailSample(i))
        {
            Console.WriteLine(i+" is Valid");
        }
        else
        {
            Console.WriteLine(i+" is Invalid");
        }

        }
        break;

}
