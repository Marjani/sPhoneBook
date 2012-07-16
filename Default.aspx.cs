using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }
    }

    

    [WebMethod]
    public static List<Person> getAllPersons()
    {
        DAL oDAL = new DAL();
        List<Person> collection = new List<Person>();
        collection = oDAL.getAllPersons();
        return collection;
    }

    [WebMethod]
    public static int addPerson(string fname, string lname, string tel)
    {
        DAL oDAL = new DAL();
        int ID = oDAL.addPerson(fname, lname, tel);
        return ID;
    }

    [WebMethod]
    public static void deletePerson(int Id)
    {
        DAL oDAL = new DAL();
        oDAL.deletePerson(Id);
    }
}