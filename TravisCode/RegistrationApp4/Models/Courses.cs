using System;
using System.Collections.Generic;

namespace RegistrationApp4
{
    public partial class Courses
    {
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string CourseName { get; set; }
        public int? InstructorId { get; set; }
        public string Dwstring { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? TotalSpots { get; set; }
        public int? SpotsAvail { get; set; }
        public int? CreditHours { get; set; }
    }
}
