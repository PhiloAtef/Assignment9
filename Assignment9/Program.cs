﻿using Assignment9.Classes;
using Assignment9.Interface;
using System.Text;

namespace Assignment9
{
    internal class Program
    {
        static void Print10Nums(IMySeries series)
        {
            if (series == null)
                return;
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"{series.Current}\t");
                series.GetNext();
            }
            series.Reset();
            System.Console.WriteLine();
        }

        static void Main(string[] args)
        {
            #region part 1

            #region interface
            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //Print10Nums(seriesByTwo);
            //Print10Nums(seriesByThree);
            //#endregion

            //#region explicit interface
            //IMoveable moveable = new Airplane();
            //IFlyable flyable = new Airplane();
            //moveable.Backward();
            //flyable.Backward();
            #endregion

            #region deep vs shallow (array of value types)
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //System.Console.WriteLine($"Hashcode Arr01 = {Arr01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Arr02 = {Arr02.GetHashCode()}");

            ////Shallow copy
            //Arr02 = Arr01;

            //System.Console.WriteLine($"Hashcode Arr01 = {Arr01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 100;
            //System.Console.WriteLine(Arr01[0]);

            ////Deep copy
            //Arr02 = (int[])Arr01.Clone();

            //System.Console.WriteLine($"Hashcode Arr01 = {Arr01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Arr02 = {Arr02.GetHashCode()}");

            //Arr02[0] = 150;
            //System.Console.WriteLine(Arr01[0]);
            #endregion

            #region deep vs shallow (array of ref types immutable)
            // string[] Name01 = { "omar" };
            // string[] Name02 = new string[1];
            // System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            // System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            // //Shallow copy
            // Name02 = Name01;

            // System.Console.WriteLine("After shallow copy");
            // System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            // System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            // System.Console.WriteLine(Name01[0]);
            // System.Console.WriteLine(Name02[0]);
            // Name02[0] = "mona";
            // System.Console.WriteLine(Name01[0]);
            // System.Console.WriteLine(Name02[0]);

            // //Deep copy
            // Name02 = (string[])Name01.Clone();

            // System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            // System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            // System.Console.WriteLine(Name01[0]);
            // System.Console.WriteLine(Name02[0]);

            // Name02[0] = "aya";
            // System.Console.WriteLine(Name01[0]);
            // System.Console.WriteLine(Name02[0]);
            #endregion

            #region deep vs shallow (array of ref types mutable)
            //StringBuilder[] Name01 = { new StringBuilder("omar") };
            //StringBuilder[] Name02 = new StringBuilder[1];
            //System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            ////Shallow copy
            //Name02 = Name01;

            //System.Console.WriteLine("After shallow copy");
            //System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            //System.Console.WriteLine(Name01[0]);
            //System.Console.WriteLine(Name02[0]);
            //Name02[0].Append(" ahmed");
            //System.Console.WriteLine("After change");
            //System.Console.WriteLine(Name01[0]);
            //System.Console.WriteLine(Name02[0]);

            ////Deep copy
            //Name02 = (StringBuilder[])Name01.Clone();

            //System.Console.WriteLine($"Hashcode Name01 = {Name01.GetHashCode()}");
            //System.Console.WriteLine($"Hashcode Name02 = {Name02.GetHashCode()}");

            //System.Console.WriteLine(Name01[0]);
            //System.Console.WriteLine(Name02[0]);

            //Name02[0].Append(" ahmed");
            //System.Console.WriteLine(Name01[0]);
            //System.Console.WriteLine(Name02[0]);
            #endregion

            #region ICloneable
            //Employee emp01 = new Employee()
            //{
            //    Id = 10,
            //    Name = "Ali",
            //    Salary = 3_000,
            //    Department = new Department()
            //    {
            //        Id = 10,
            //        Name = "Department 1"
            //    }
            //};

            //Employee emp02 = new Employee()
            //{
            //    Id = 20,
            //    Name = "Mona",
            //    Salary = 5_000,
            //    Department = new Department()
            //    {
            //        Id = 10,
            //        Name = "Department 2"
            //    }
            //};

            //System.Console.WriteLine($"hashcode of emp01 = {emp01.GetHashCode()}");
            //System.Console.WriteLine($"hashcode of emp02 = {emp02.GetHashCode()}");

            ////shallow copy
            //Employee emp03 = emp01;
            //System.Console.WriteLine($"hashcode of emp01 = {emp01.GetHashCode()}");
            //System.Console.WriteLine($"hashcode of emp03 = {emp03.GetHashCode()}");
            //emp03.Department.Name = "Sales";
            //System.Console.WriteLine(emp01);
            //System.Console.WriteLine(emp03);

            ////deep copy
            //Employee emp04 = (Employee)emp01.Clone();
            //System.Console.WriteLine($"hashcode of emp01 = {emp01.GetHashCode()}");
            //System.Console.WriteLine($"hashcode of emp04 = {emp04.GetHashCode()}");
            //emp04.Department.Name = "Sales";
            //System.Console.WriteLine(emp01);
            //System.Console.WriteLine(emp04);
            //#endregion

            //#region IComparable
            //Employee[] empArr =
            //{
            //    new Employee() { Id = 10, Name = "omar", Salary = 3000},
            //    new Employee() { Id = 20, Name = "ali", Salary = 5000},
            //    new Employee() { Id = 30, Name = "ahmed", Salary = 7000},
            //};

            //Array.Sort(empArr);

            //foreach (var item in empArr)
            //{
            //    System.Console.WriteLine(item);
            //}
            #endregion

            #endregion

            #region part 2

            //Question 1: b) To define a blueprint for a class
            //Question 2: a) private
            //Question 3: b) No
            //Question 4: b) Yes, interfaces can inherit from multiple interfaces
            //Question 5: d) implements
            //Question 6: a) Yes
            //Question 7: a) Yes, for all members
            //Question 8: b) To provide a clear separation between interface and class members
            //Question 9: b) No, interfaces cannot have constructors
            //Question 10: c) By separating interface names with commas

            #endregion

            


            #region Question 1 part 3
            //Circle circle = new Circle();
            //circle.Radius = 10;
            //circle.DisplayShapeInfo();

            //Rectangle rectangle = new Rectangle();
            //rectangle.Length = 10;
            //rectangle.Width = 10;
            //rectangle.DisplayShapeInfo(); 
            #endregion

            #region Question 2 part 3
            //IAuthenticationService authService = new BasicAuthenticationService();

            //string username = "Ahmed";
            //int password = 1;

            //bool isAuthenticated = authService.AuthenticateUser(username, password);
            //Console.WriteLine($"isAuthenticaled = {isAuthenticated}");

            //string role = "Admin";
            //bool isAuthorized = authService.AuthorizeUser(username, role);
            //Console.WriteLine($"isAuthorized = {isAuthorized}"); 
            #endregion

            #region Question 3 part 3
            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //string recipient = "hambozo@gmail.com";
            //string message = "test message";

            //emailService.SendNotification(recipient, message);
            //smsService.SendNotification(recipient, message);
            //pushService.SendNotification(recipient, message); 
            #endregion


        }
    }
}
