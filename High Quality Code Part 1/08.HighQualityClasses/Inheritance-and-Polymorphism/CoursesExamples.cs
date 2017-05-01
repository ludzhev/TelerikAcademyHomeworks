// <copyright file="CoursesExamples.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    /// <summary>
    /// Represent example application with courses.
    /// </summary>
    public class CoursesExamples
    {
        /// <summary>
        /// Represent the starting point of the examples.
        /// </summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases", "Svetlin Nakov", "Enterprise");
            Console.WriteLine(localCourse);

            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);

            localCourse.AddStudent("Milena");
            localCourse.AddStudent("Todor");
            Console.WriteLine(localCourse);

            var students = new List<string>() { "Thomas", "Ani", "Steve" };
            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", "Ultimate", students);
            Console.WriteLine(offsiteCourse);
        }
    }
}
