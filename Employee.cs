using System;

class Employee {

//attributes/fields
  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private string phonenumber;
  private string title;
  private string employmentstatus;

  private int age;
  private double yearlysalary;
  private double percent;

//Properties
  public string FirstName {get; set;}
  public string LastName {get; set;}

  public string Id{
    get{return id;}
    set{
        if (value.Length > 0)
          id = value;
      
      else{
          Console.WriteLine("Rejected id");
        }
    }
  }
  public string EmploymentStatus{
    get{return employmentstatus;}
    set{
        if (value.Length > 0)
          employmentstatus = value;
      
      else{
          Console.WriteLine("Rejected employmentstatus");
        }
    }
  }
    

public int Age{
    get{return age;}
    set{
        if (value > 18)
          age = value;
      
      else{
        Console.WriteLine("Rejected age.");
      }
    }
  }


public double Yearlysalary{
    get{return yearlysalary;}
    set{
        if (value > 1000)
          yearlysalary = value;
      
       else{
        Console.WriteLine("Rejected yearlysalary.");
      }
    }
  }

//Constructors
  public Employee()
  {    
    FirstName="Unknown";
    LastName="Unknown";
    Age= 0;

  }

  //Methods
    public void Intro()
    {
      Console.WriteLine("My name is : " + FirstName + LastName) ;
      Console.WriteLine("My id is : " + Id);
      Console.WriteLine("My age is :" + Age);
      Console.WriteLine("My employment status is :" + EmploymentStatus);
      Console.WriteLine("My yearly salaray is :" + Yearlysalary);

    }
    //constructor with parameters
    public Employee(string firstname, string lastname , string id, int age)
    {
    FirstName = firstname;
    LastName = lastname;
    Id = id;
    Age = age;
    EmploymentStatus = "active";
}


    public void IncreaseSalary()
    {
      if (yearlysalary)
        {
          Console.WriteLine("Successful salary increase!");
        }
        else{
          Console.WriteLine("unsuccessful salary.");
        } 
    }

    public void RemoveEmployee()
    {

        if (employmentstatus)
        {
          Console.WriteLine("Employee already inactive");
        }
        else{
          Console.WriteLine("Employee removed");
        }      
    }
}
