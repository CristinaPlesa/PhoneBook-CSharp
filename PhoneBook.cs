using System;
using System.Collections.Generic;

class PhoneBook
{
  public static Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

  static void Main()
  {
    Console.WriteLine("MAIN MENU");
    // 1st menu prompt:
    Console.WriteLine("Would you like to add a person to your phone book? ['Y' for yes, 'Enter' for no]");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    // If yes, takes user to the AddContact() method fun
    {
      AddContact();
    }
    else
    // If no, continues to 2nd prompt
    {
      // 2nd menu prompt:
      Console.WriteLine("Would you like to look up a number in your phone book? ['Y' for yes, 'Enter' for no]");
      string lookUpAnswer = Console.ReadLine();
      if (lookUpAnswer == "Y" || lookUpAnswer == "y")
      // If yes, takes user to the LookUpContact() method magic
      {
          LookUpContact();
      }
      else
      // If no, continues to the 3rd prompt
      {
        // 3rd menu prompt:
        Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
        string finishedAnswer = Console.ReadLine();
        if (finishedAnswer == "Y" || finishedAnswer == "y")
        // If yes, exits the program
        {
          Console.WriteLine("Goodbye.");
        }
        else
        // If no, returns to the main menu (1st menu prompt, at the top)
        {
          Main();
        }
      }
    }
  }

// git commit -m "this was a really cool thing I did, I named a bear \"berar\" "
// char firstInitial = 'C';
  static void AddContact()
  {
    Console.WriteLine("NEW CONTACT");
    Console.WriteLine("Enter a new contact name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter a new contact phone number");
    string number = Console.ReadLine();
    if (phoneNumbers.ContainsKey(name))
    {
      Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
    }
    else
    {
      phoneNumbers.Add(name, number);
    }
    Main();
  }
  static void LookUpContact()
  {
    Console.WriteLine("CONTACT LOOKUP");
    Console.WriteLine("Whose number would you like to look up?");
    string friend = Console.ReadLine();
    if (phoneNumbers.ContainsKey(friend))
    {
      string value = phoneNumbers[friend];
      Console.WriteLine(friend + "\'s phone number is " + value);
      // this \ is saying to treat ' like a part of a string, not a single character value (aka: don't run this as code!)
    }
    else
    {
      Console.WriteLine("That person is not in your phone book.");
    }
    Main();
  }
}