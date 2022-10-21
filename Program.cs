using System;



public class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullNAme()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


public class PartTimeEmployee:Employee
{

    //use new keyword to hide
    public new void PrintFullNAme()
    {
        base.PrintFullNAme();
       // Console.WriteLine(FirstName + " " + LastName + " - constructor");
    }
}

public class FullTimeEmployee:Employee
{

}
public  class Program
    {
   public static void Main()
        {
         FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Full Time ";
        FTE.LastName = "Employee";
        FTE.PrintFullNAme();


        Employee PTE = new PartTimeEmployee();
       // PartTimeEmployee PTE =new PartTimeEmployee();
        PTE.FirstName = "Part Time ";
        PTE.LastName = "Employee";
        PTE.PrintFullNAme();
       // ((Employee)PTE).PrintFullNAme();  //to show parent class
        }
    }
