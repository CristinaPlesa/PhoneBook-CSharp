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

// NOTES for For Each loops Lesson 8 of 9
// https://www.learnhowtoprogram.com/c-and-net/branching-and-looping/for-each-loops
//
// > string[] theEntireArray = {"zero index", "first index", "second index"};
//
// foreach (string individualEntry in theEntireArray)
// {
//   Console.WriteLine(individualEntry);
// }

// GroceryList.cs Example:
// using System;

// class GroceryList
// {
//   static void Main()
//   {
//     string[] myGroceryList = {"eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};
//     int[] groceryListPrices = { 3, 6, 4, 2, 4, 4};

//     Console.WriteLine("My grocery list:");
//     foreach (string groceryItem in myGroceryList)
//     {
//       Console.WriteLine(groceryItem);
//     }

//     int total = 0;
//     foreach (int price in groceryListPrices)
//     {
//       total += price;
//     }

//     Console.WriteLine("Your total for this shopping trip will be $" + total);
//   }
// }


// // LeapYear.cs Example:
// using System;

// class LeapYear
// {
//   static void Main()
//   {
//     Console.WriteLine("What year were you born in?");
//     string stringBirthYear = Console.ReadLine();
//     int birthYear = int.Parse(stringBirthYear);

//     Console.WriteLine("You were alive during these leap years:");
//     for (int year = birthYear; year <= 2021; year ++)
//     {
//       // "%" aka modulo is a weird operator that only looks at leftovers after dividing
//       if (year % 4 == 0)
//       {
//         Console.WriteLine(year);
//       }
//       // i.e., all leap years just happen to be divisible by 4 (it's a weird calendar thing)
//       // if year = 2016 (which is evenly divisible by 4), "2016 % 4" = 0 (no remainder)
//       // if year = 2017 (which is *not* evenly divisible by 4), "2017 % 4" = 1 (remainder 1)
//       // we know 2016 is a leap year because it has remainder "0"
//       // we know 2017 isn't one, because it has a leftover number after dividing by 4
//     }
//   }
// }