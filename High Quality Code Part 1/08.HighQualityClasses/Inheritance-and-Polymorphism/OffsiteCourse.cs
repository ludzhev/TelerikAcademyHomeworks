// <copyright file="OffsiteCourse.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of static class Mathematics.</summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    /// <summary>
    /// Represent a offsite course with name, teacher, town and students.
    /// </summary>
    public class OffsiteCourse : Course
    {
        /// <summary>
        /// Town of the <see cref="OffsiteCourse"/> instance.
        /// </summary>
        private string town;

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="OffsiteCourse"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="OffsiteCourse"/> instance.</param>
        /// <param name="town">Town of the <see cref="OffsiteCourse"/> instance.</param>
        public OffsiteCourse(string courseName, string teacherName, string town)
            : base(courseName, teacherName)
        {
            this.Town = town;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OffsiteCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="OffsiteCourse"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="OffsiteCourse"/> instance.</param>
        /// <param name="town">Town of the <see cref="OffsiteCourse"/> instance.</param>
        /// <param name="students">Students of the <see cref="OffsiteCourse"/> instance.</param>
        public OffsiteCourse(string courseName, string teacherName, string town, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        /// <summary>
        /// Gets or sets the town of the <see cref="OffsiteCourse"/> instance.
        /// </summary>
        /// <value>Town of the <see cref="OffsiteCourse"/> instance.</value>
        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Town cannot be null or empty string!");
                }

                this.town = value;
            }
        }

        /// <summary>
        /// Generate text representing the <see cref="OffsiteCourse"/> instance.
        /// </summary>
        /// <returns>Generated text.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{base.ToString()}; Town = {this.Town} }}");

            return result.ToString();
        }
    }
}
