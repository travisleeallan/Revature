using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace RegistrationApp.Src 
{
  public class Student 
  {
    protected int ID { get; set; }
    protected string FirstName { get; set; }
    protected string LastName { get; set; }
    protected string Major { get; set; }
    protected string Classification { get; set; }


    protected int RetrieveStudent() {

      return 0;
    }
    protected int EditStudent() {
      return 0;
    }
    protected int DeleteStudent() {
      return 0;
    }
    protected int AddCourse() {
      return 0;
    }
    protected int ViewCourse() {
      return 0;
    }
    protected int DropCourse() {
      return 0;
    }
  }
}