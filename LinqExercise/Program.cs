using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            // - FINISHED - Print the Sum and Average of numbers
            #region NumbersMethod

            var sum = numbers.Sum();
            Console.WriteLine($"Sum: {sum}");    ///Calculates and returns sum

            var average = numbers.Average();
            Console.WriteLine($"Average: {average}"); ///Calcualtes and returns the average
            Console.WriteLine("");

            // - FINISHED - Order numbers in ascending order and decsending order. Print each to console.

            Console.WriteLine("Numbers Ascending: ");
            foreach (var number in numbers.OrderBy(x => x))
            {
                
                Console.WriteLine(number);
            }

            Console.WriteLine("");
            Console.WriteLine("Numbers Descending: ");
            foreach (var number in numbers.OrderByDescending(x => x))
            {
                
                Console.WriteLine(number);
            }


            // - FINISHED - Print to the console only the numbers greater than 6
            Console.WriteLine("");
            Console.WriteLine("Prints numbers greater than 6");
            foreach (var number in numbers.Where(x => x > 6).OrderBy(x => x))
            {
                Console.WriteLine(number);
            }

            // FINISHED - Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("");
            Console.WriteLine("Print 4 numbers in Decending Order: ");
            var fourNumbers = numbers.Take(4).OrderByDescending(x => x);
            foreach (var number in fourNumbers)
            {
                Console.WriteLine(number);
            }

            // - FINISHED - Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("");
            Console.WriteLine("Print the number 26 and numbers in descending order: ");
            numbers[4] = 26;
            var numbersAge = numbers.OrderByDescending(x => x);
            foreach (var number in numbersAge)
            {
                Console.WriteLine(number);
            }
            #endregion

         #region Array Practice

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();

            // - FINISHED - all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.

            var employeesFullName = employees.Where(emp => emp.FirstName.StartsWith("C") || emp.FirstName.StartsWith("S")).OrderBy(emp => emp.FirstName);
            foreach (Employee employee in employeesFullName)
            {
                Console.WriteLine(employee.FullName);
            }
            Console.WriteLine("");

            // - FINISHED - Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var employees26 = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            foreach (Employee employee in employees26)
            {
                Console.WriteLine($"Name: {employee.FirstName} | Age: {employee.Age}");
            }
            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35
            Console.WriteLine("");
            var YOEGreaterThan10 = employees.Where(emp => emp.YearsOfExperience < 10 && emp.Age > 35);
            var sumOfYOE = YOEGreaterThan10.Sum(emp => emp.YearsOfExperience);
            var averageOfYOE = YOEGreaterThan10.Average(emp => emp.YearsOfExperience);

            Console.WriteLine($"Sum of the employees years of experience is: {sumOfYOE}");
            Console.WriteLine($"Average of the employees years of experience is: {averageOfYOE}");
            Console.WriteLine("");
            // - FINISHED - Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Add employee to list without using employees.Add : ");
            var newList = employees.Append(new Employee("Whit", "Stroup", 24, 42));
            foreach (var employee in newList)
            {
                Console.WriteLine(employee.FullName);
            }

            Console.WriteLine();

            Console.ReadLine();
        }
        #endregion


        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("John", "Ward", 29, 50));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
