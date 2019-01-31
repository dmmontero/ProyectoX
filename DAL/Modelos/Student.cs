namespace DAL.Modelos
{
    using System;

    /// <summary>
    /// Defines the <see cref="Student" />
    /// </summary>
    internal class Student
    {
        /// <summary>
        /// Gets or sets the StudentID
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Gets or sets the StudentName
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Gets or sets the DateOfBirth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the Photo
        /// </summary>
        public byte[] Photo { get; set; }

        /// <summary>
        /// Gets or sets the Height
        /// </summary>
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the Weight
        /// </summary>
        public float Weight { get; set; }

        /// <summary>
        /// Gets or sets the GradeId
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// Gets or sets the Grade
        /// </summary>
        public Grade Grade { get; set; }
    }
}
