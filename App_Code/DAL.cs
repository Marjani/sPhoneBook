using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DAL
/// </summary>
public class DAL
{
    public DAL()
    {
    }

    public List<Person> getAllPersons()
    {
        List<Person> collection = null;
        using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PersonsDB"].ConnectionString))
        {
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("getAllPersons", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                collection = new List<Person>();

                while (reader.Read())
                {
                    collection.Add(new Person(
                        reader[0] == DBNull.Value ? int.MinValue : (int)reader[0],
                        reader[1] == DBNull.Value ? string.Empty : (string)reader[1],
                        reader[2] == DBNull.Value ? string.Empty : (string)reader[2],
                        reader[3] == DBNull.Value ? string.Empty : (string)reader[3]
                        ));
                }
                return collection;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
    }
    public int addPerson(string firstName, string lastName, string telephone)
    {

        using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PersonsDB"].ConnectionString))
        {
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("addPerson", con);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@firstName", firstName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastName", lastName));
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@tel", telephone));

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                int id = (int)cmd.ExecuteScalar();
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
    }

    public void deletePerson(int id)
    {
        using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["PersonsDB"].ConnectionString))
        {
            try
            {
                con.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("deletePerson", con);
                cmd.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", id));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }
        }
    }
}