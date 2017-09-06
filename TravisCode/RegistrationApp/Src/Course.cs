using System;
namespace RegistrationApp.Src
{
  public class Course
  {
    protected int ID { get; set; }
    protected string SubjectCode { get; set; }
    protected string CourseName { get; set; }
    protected int InstructorID { get; set; }
    protected string DWstring { get; set; }
    protected string StartTime { get; set; }
    protected string EndTime { get; set; }
    protected int TotalSpots { get; set; }
    protected int SpotsAvail { get; set; }
    protected int CreditHours { get; set; }
  }
}
