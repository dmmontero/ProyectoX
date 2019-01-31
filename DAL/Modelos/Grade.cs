namespace DAL.Modelos
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Grade" />
    /// </summary>
    internal class Grade
    {
        /// <summary>
        /// Gets or sets the GradeId
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// Gets or sets the GradeName
        /// </summary>
        public string GradeName { get; set; }

        /// <summary>
        /// Gets or sets the Section
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Gets or sets the Students
        /// </summary>
        public ICollection<Student> Students { get; set; }
    }
}
