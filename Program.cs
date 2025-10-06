using System;
class Test
{
    public static void Main(string[] args)
    {
        double salary = 100000.45;
        Console.WriteLine("Salary: " + salary);

        int salary2 = (int)salary;
        Console.WriteLine("Salary: " + salary2);
    }
}

// Implicit / Automatic casting 
// Explicit / Manual casting

// ছোট থেকে বড় হলে আটোমেটিক কাস্টিং বা চেংজ হয়।
// বড় থেকে ছোট হলে ্মেনুয়াল কাস্টিং করতে হয়।