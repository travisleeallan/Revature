using System.Data.SqlClient;
using System.Data;
using System.Threading;
namespace Datanet.Ado
{
  public class AdoData
  {
    private string connection = "data source=tlarevdb1.database.windows.net;initial catalog=TLARevDB1;user id=tradmin;password=L0n3r1sm;";
    public void ReadDisconnected()
    {
      DataSet ds = new DataSet();
      
      
      using (var con = new SqlConnection(connection))
      {
        string query = "select * from SalesLt.Customer;";
        SqlCommand command = new SqlCommand(query);
        SqlDataAdapter da = new SqlDataAdapter();

        command.Connection = con;
        da.SelectCommand = command;
        con.Open();
        da.Fill(ds);
      }

      foreach (DataRow item in ds.Tables[0].Rows) 
      {
        System.Console.WriteLine("{0} {1}", item[3], item["LastName"]);
      }
    }

    public void ReadConnected()
    {
      using (var con = new SqlConnection(connection))
      {
        
        SqlDataReader dr; // = new SqlDataAdapter();
        var q = "select * from SalesLt.Customer;";
        var command = new SqlCommand(q);

        con.Open();
        command.Connection = con;
        dr = command.ExecuteReader();

        while(dr.Read()) 
        {
          System.Console.WriteLine("{0} {1}", dr[3], dr["LastName"]);
          Thread.Sleep(1000);
        }
      }
    }
  }
}