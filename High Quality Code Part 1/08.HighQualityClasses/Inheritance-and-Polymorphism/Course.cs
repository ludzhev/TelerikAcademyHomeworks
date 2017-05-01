// <copyright file="Course.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceAndPolymorphism
{
    /// <summary>
    /// Represent a  course with name, teacher and students.
    /// </summary>
    public abstract class Course
    {
        /// <summary>
        /// Name of the <see cref="Course"/> instance.
        /// </summary>
        private string name;

        /// <summary>
        /// Name of the teacher of the <see cref="Course"/> instance.
        /// </summary>
        private string teacherName;

        /// <summary>
        /// Students of the <see cref="Course"/> instance.
        /// </summary>
        private IList<string> students;

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="Course"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="Course"/> instance.</param>
        protected Course(string courseName, string teacherName)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = new List<string>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Course"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="Course"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="Course"/> instance.</param>
        /// <param name="students">Students of the <see cref="Course"/> instance.</param>
        protected Course(string courseName, string teacherName, IEnumerable<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students.ToList();
        }

        /// <summary>
        /// Gets or sets the name of the <see cref="Course"/> instance.
        /// </summary>
        /// <value>Name of the <see cref="Course"/> instance.</value>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty string!");
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the name of the teacher of the <see cref="Course"/> instance.
        /// </summary>
        /// <value>Name of the teacher of the <see cref="Course"/> instance.</value>
        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("TeacherName cannot be null or empty string!");
                }

                this.teacherName = value;
            }
        }

        /// <summary>
        /// Gets or sets the students of the <see cref="Course"/> instance.
        /// </summary>
        /// <value>Students of the <see cref="Course"/> instance.</value>
        public IList<string> Students
        {
            get
            {
                return new List<string>(this.students);
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value), "Students cannot be null!");
                }

                this.students = value;
            }
        }

        /// <summary>
        /// Add student to the <see cref="Course"/> instance.
        /// </summary>
        /// <param name="studentName">Student name to add.</param>
        public void AddStudent(string studentName)
        {
            this.students.Add(studentName);
        }

        /// <summary>
        /// Remove student from the <see cref="Course"/> instance.
        /// </summary>
        /// <param name="studentName">Student name to remove.</param>
        public void RemoveStudent(string studentName)
        {
            this.students.Remove(studentName);
        }

        /// <summary>
        /// Generate text representing the <see cref="Course"/> instance.
        /// </summary>
        /// <returns>Generated text.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"LocalCourse {{ Name = {this.Name}; Teacher = {this.TeacherName}; Students = {this.GetStudentsAsString()}");

            return result.ToString();
        }

        /// <summary>
        /// Generate text representing the students of the <see cref="Course"/> instance.
        /// </summary>
        /// <returns>Generated text.</returns>
        private string GetStudentsAsString()
        {
            return $"{{ {string.Join(", ", this.Students)} }}";
        }
    }
}
