// <copyright file="Student.cs" company="CurrentCompany">
//  All rights reserved.
// </copyright>
// <author>CurrentEmployee</author>
// <summary>Holds implementation of class Student.</summary>
using System;

namespace Methods
{
    /// <summary>
    /// Represent a Student with first and last name, town and date of birth.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">First name of the <see cref="Student"/> instance.</param>
        /// <param name="lastName">Last name of the <see cref="Student"/> instance.</param>
        /// <param name="bornTown">Born town of the <see cref="Student"/> instance.</param>
        /// <param name="dateOfBirth">Date of birth of the <see cref="Student"/> instance.</param>
        /// <exception cref="ArgumentException">Thrown when any of the arguments is null or empty <see cref="string"/>.</exception>
        public Student(string firstName, string lastName, string bornTown, DateTime dateOfBirth)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty!");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty!");
            }

            if (string.IsNullOrEmpty(bornTown))
            {
                throw new ArgumentException("Borntown cannot be null or empty!");
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.BornTown = bornTown;
            this.DateOfBirth = dateOfBirth;
        }

        /// <summary>
        /// Gets the First name of the <see cref="Student"/> instance.
        /// </summary>
        /// <value>First name of the <see cref="Student"/> instance.</value>
        public string FirstName { get; private set; }

        /// <summary>
        /// Gets the Last name of the <see cref="Student"/> instance.
        /// </summary>
        /// <value>Last name of the <see cref="Student"/> instance.</value>
        public string LastName { get; private set; }

        /// <summary>
        /// Gets the born town of the <see cref="Student"/> instance.
        /// </summary>
        /// <value>Born town of the <see cref="Student"/> instance.</value>
        public string BornTown { get; private set; }

        /// <summary>
        /// Gets the date of birth of the <see cref="Student"/> instance.
        /// </summary>
        /// <value>Date of birth of the <see cref="Student"/> instance.</value>
        public DateTime DateOfBirth { get; private set; }

        /// <summary>
        /// Check if the <see cref="Student"/> instance is older than other <see cref="Student"/> instance.
        /// </summary>
        /// <param name="other">The other <see cref="Student"/> instance to check against.</param>
        /// <returns>Rather the <see cref="Student"/> instance is older or not.</returns>
        public bool IsOlderThan(Student other)
        {
            bool isOlder = this.DateOfBirth < other.DateOfBirth;
            return isOlder;
        }
    }
}
