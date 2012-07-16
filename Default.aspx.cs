using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=persons;Data Source=.\sqlexpress";
        con.Open();
        SqlCommand cmd = new SqlCommand("getAllPersons",con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;

        SqlDataReader read = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
        List<Person> collection = new List<Person>();

        while(read.Read())
        {
            collection.Add(new Person(
                read["Id"] == DBNull.Value ? Int16.MinValue : (int)read["Id"],
                read["FName"] == DBNull.Value ? string.Empty : (string)read["FName"],
                read["LName"] == DBNull.Value ? string.Empty : (string)read["Lname"],
                read["Tel"] == DBNull.Value ? string.Empty : (string)read["Tel"]
                ));
        }
        var a = collection;
    }
}