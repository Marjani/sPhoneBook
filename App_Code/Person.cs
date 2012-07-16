using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    #region Constractor
    public Person()
	{
    }

    public Person(int id, string firstName, string lastName, string telephone)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Telephone = telephone;
    }
    #endregion

    #region Prop
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Telephone { get; set; }
    #endregion

    #region Methods
    public string addPerson(string firstName, string lastName,string Telephone)
    {
        string Id = null;
        return Id;
    }

    public List<Person> getPersons ()
    {
        List<Person> collection = new List<Person>();
        return collection;
    }
    
    public void removePerson(string Id)
    {
    }
    #endregion

}