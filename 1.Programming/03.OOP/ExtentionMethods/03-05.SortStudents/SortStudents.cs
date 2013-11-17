/*3. Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.*/
/*4. Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/
/*5. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_05.SortStudents
{
    class SortStudents
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(new Students("az", "sym"));
            students.Add(new Students("az", "nesym"));
            students.Add(new Students("blabla", "sdawdadym"));
            students.Add(new Students("ggggg", "rrrrr"));

            //sort students alphabetically
            var sortedAlphabetically =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var item in sortedAlphabetically)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            //sort students by age
            var result =
            from student in students
            where student.Age > 18 && student.Age < 24
            select new { student.FirstName, student.LastName };

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            //sort by first and last name descending
            var resultLambdaExpression = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in resultLambdaExpression)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            var resultLINQExpression =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in resultLINQExpression)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();
        }
    }
}
