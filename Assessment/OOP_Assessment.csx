
//1.Create a class called Customer.The class should have three properties:
//  Name, Gender, and Purchase.You should also create an Enum called Gender.
// The 0 spot should be Unknown, the 1 spot should be Male, and the 2 spot
// should be Female.

//2.Create a constructor for the Customer class that allows you to more
//easily create Customer objects.The constructor should have parameters 
//for name, gender, and purchase. Remember that gender will be an enum,
//so the enum name will be its type.

//3.Create a method in your Customer class that simulates sending a thank 
//you to the customer after their purchase by writing the message to the 
//console.Your console message might read something like this:
///Hello { Name}, thank you for purchasing the { product}. We hope you enjoy
///it!

//4.Create two more methods.They should both be called SendSaleNotice.One 
//should accept only a date as a parameter and the other one is an overload
//of that same method which should accept both a date and a string as 
//parameters.Use these methods to announce sales. Your methods should print
//something similar to these messages:
///Hello Dave, We wanted to let you know there's a sale coming up on
///4/1/2016.
///Hello Dave, We wanted to let you know there's a sale on Apple iPhones
///coming up on 4/1/2016.

//5.Create a subclass of Customer called InactiveCustomer.The class should 
//have an int property called MonthsInactive, and other programmers SHOULD
//NOT be able to create subclasses from it. (hint: Sealed Modifier)

//6.In the InactiveCustomer subclass, create a constructor that uses the 
//base keyword that adds a monthsInactive parameter.

//7.In the InactiveCustomer subclass create a method that sends a message 
//to a customer who has been inactive for over four months.The console 
//would read something like this:
///Thanks for shopping with us { Name}. We saw that you purchased an 
///{ product } from us { monthsInactive }
///months ago.We'd like to know if you'd like to take a look at some of 
///our current deals.

//8.You should, of course, create instances of these classes, set the 
//properties via the constructors, and test the methods on those objects.

//9.Add an overidable method to the Customer class called 
//PrintCustomerInfo. (hint: Virtual Modifier) The method should print the
//name purchase, and gender of the customer.It could go like this:
///Paul - Fender Jazz Bass Guitar - Male.

//10.Add an enum to the InactiveCustomer class that gives a couple reasons 
//why a customer might not be purchasing.The reasons might be Irate, 
//Moved, Uninterested

//11.Add a property to the InactiveCustomer class that indicates why the 
//customer is inactive

//12.Add a method called PrintCustomerInfo that overrides the one from the
//Customer class. You should print Name, product purchased, gender, 
//months inactive, and reason for inactivity.For example:
///Michael - desk - Male - 4 - Moved
///========================================

// Task 1 Class
using System;
public enum Gender { Unknown = 0, Male, Female };

class Customer
{
    // Task 2 Constructor with parameters
    public Customer(string name, Gender gender, string purchase)
    {
        Name = name;
        Gender = gender;
        Purchase = purchase;
    }
    // Basic getter and setter methods
    public string Name { get; set; }
    public Gender Gender { get; set; }
    public string Purchase { get; set; }

    // Task 3 ThankYou Method
    public void sendThankYou()
    {
        Console.WriteLine($"Thank you {Name} for purchasing {Purchase}.");
    }
    //// Task 4 Two Methods - Different Parameter Signatures
    public DateTime Date { get; set; }
    public String Product { get; set; }
    // First Signature, One Parameter
    public void sendSalesNotice(DateTime date)
    {
        Date = date;

        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale coming up on {Date.ToString("d")}.");

    }
    // Second Signature, Two Parameters
    public void sendSalesNotice(DateTime date, string product)
    {
        Date = date;
        Product = product;
        Console.WriteLine($"Hello {Name}, We wanted to let you know there's a sale for {Product} coming up on {Date.ToString("d")}.");

    }



    // Task 9 TODO: Create an overidable method of the Customer class
    // called PrintCustomerInfo. 
    virtual public void PrintCustomerInfo()
    {
        Date = date;
        Product = product;
        Console.WriteLine($"{Name} - {Purchase} - {Gender}");

    }

}

// testing and using class. 

var c = new Customer("Donald", Gender.Male, "Art of Deal Book");
c.sendThankYou();

var d = new Customer("Melania", Gender.Female, "Designer Dress");
d.sendThankYou();

DateTime date1 = new DateTime(2016, 7, 4);
DateTime date2 = new DateTime(2016, 7, 21);
string product1 = "Red Hats";
c.sendSalesNotice(date1);
c.sendSalesNotice(date2, product1);


//Subclass: Tasks 5 -12
public enum Reason { Unknown = 0, Irate, Moved, Uninterested };
class InactiveCustomer : Customer
{ // Task 6: Constructor
    public InactiveCustomer(
        string Name,
        Gender Gender,
        string Purchase,
        int monthsInactive)
    {
        {
            Name = base.name;
            Gender = base.gender;
            Purchase = base.purchase;
            MonthsInactive = monthsInactive;
        }
    }

    // Task 5: sealed property
    sealed override int MonthsInactive { get; set; }


    // Task 6: Message Sender   
    public void sendInactiveCustomerMessage()
    {
        if (MonthsInactive > 4)
        {
            Console.WriteLine($"Thank you for shopping with us {Name}. ");
            Console.Write($"We saw that you purchased a {Product} from us {monthsInactive} months ago. ");
            Console.Write($"We'd like to know if you'd like to take a look at some of our current deals.");
        }
    }



    public void InactiveWhy(Reason reason) 
        {
            Reason = reason;
        }

    // Basic getter and setter method
    public Reason Reason { get; set; }

    override public void PrintCustomerInfo()
    {
        Date = date;
        Product = product;
        Reason = "Irate";
        Console.WriteLine($"{Name} - {Purchase} - {Gender} - {Reason}");

    }
}


