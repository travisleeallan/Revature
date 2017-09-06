using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
namespace Datanet.EF
{
  public class SqlWeek3 : DbContext
  {
      public DbSet<Contact> Contacts { get; set; }
      public DbSet<Phone> Phones { get; set; }
      public DbSet<Email> Emails { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        builder.UseSqlServer("Server=tlarevdb1.database.windows.net;database=TLARevDB1;user id=tradmin;password=L0n3r1sm;");
      }
  }


  public class Contact
  {
    public int ContactId { get; set; }
    //[Required]
    //[StringLength(30)]
    public string First { get; set; }
    //[Required]
    public string Last { get; set; }
    
  }

  public class Phone 
  {
    public int PhoneId { get; set; }
    public Contact Contact { get; set; }
    public string number {get; set;}

  }

  public class Email
  {
    public int EmailId { get; set; }
    public Contact Contact {get; set; }
    public string Myproperty {get; set;}

  }
}