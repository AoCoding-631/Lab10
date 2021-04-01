using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Employee");

  Employee John = new Employee("John","Smith", "S0089", 38);//constructor with parameters
    John.Yearlysalary = 50000;
    John.Intro();  

    Employee Robert = new Employee("Robert","Downey", "12321", 12);//constructor with parameters
    Robert.Yearlysalary = 100;
    Robert.Intro();  


    Employee Rob = new Employee("Robert","Downey", "S0089", 38);//constructor with parameters
    Rob.Yearlysalary = 50000;
    Rob.IncreaseSalary = 0.10;
    Rob.Intro();  

    Employee Maria = new Employee("Maria","Lambert", "S0100", 26, -2);//constructor with parameters
    Console.WriteLine("yearly salary " + Maria.Yearlysalary);
    Maria.Yearlysalary = 80000 ;
    Maria.RemoveEmployee();
    Maria.Intro();

  }
}