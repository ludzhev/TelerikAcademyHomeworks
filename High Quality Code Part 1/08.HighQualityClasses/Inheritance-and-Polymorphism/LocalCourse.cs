// <copyright file="LocalCourse.cs" company="CurrentCompany">
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
    /// Represent a local course with name, teacher, lab and students.
    /// </summary>
    public class LocalCourse : Course
    {
        /// <summary>
        /// Lab name of the <see cref="LocalCourse"/> instance.
        /// </summary>
        private string lab;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="LocalCourse"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="LocalCourse"/> instance.</param>
        /// <param name="lab">Lab name of the <see cref="LocalCourse"/> instance.</param>
        public LocalCourse(string courseName, string teacherName, string lab)
            : base(courseName, teacherName)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalCourse"/> class.
        /// </summary>
        /// <param name="courseName">Name of the <see cref="LocalCourse"/> instance.</param>
        /// <param name="teacherName">Name of the teacher of the <see cref="LocalCourse"/> instance.</param>
        /// <param name="lab">Lab name of the <see cref="LocalCourse"/> instance.</param>
        /// <param name="students">Students of the <see cref="LocalCourse"/> instance.</param>
        public LocalCourse(string courseName, string teacherName, string lab, IList<string> students)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        /// <summary>
        /// Gets or sets the lab name of the <see cref="LocalCourse"/> instance.
        /// </summary>
        /// <value>Lab name of the <see cref="LocalCourse"/> instance.</value>
        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Lab cannot be null or empty string!");
                }

                this.lab = value;
            }
        }

        /// <summary>
        /// Generate text representing the <see cref="LocalCourse"/> instance.
        /// </summary>
        /// <returns>Generated text.</returns>
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{base.ToString()}; Lab = {this.Lab} }}");

            return result.ToString();
        }
    }
}
