using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsPerson
{
    private string _name;
    private string _lastname;
    private string _email;
    private int _personID;
    private string _phone;

    public string Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    

    public int PersonID
    {
        get { return _personID; }
        set { _personID = value; }
    }
    

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    

    public string Lastname
    {
        get { return _lastname; }
        set { _lastname = value; }
    }
    

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    
}
