using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Delete NAMESPACE, becuase Why? The reason is that you want your clsDates class 
// to be usable in other programs you might
// develop, without your having to use the project’s namespace as part of the class hierarchy


public class User:clsPerson
{
    // =============== symbolic constants ==================
    #region PropertyMethods
    //Using Code Snippets in Visual Studio
    private string _password;
    private string _userName;
    public static readonly int SetDefaultRole = 2; // book: pro_.net_best_practices pag: 117
    public int Role { get; set; } //Other way to declare one line property
    private int _userID;

    public int UserID
    {
        get { return _userID; }
        set { _userID = value; }
    }


    public string UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }

    public string Password
    {
        get { return _password; }
        set
        { //Some Validation
            if (value.Length >= 6)
            {
                _password = value;
            }
            else
            {
                throw new Exception("Password must be at least 6 characters");
            }
        }
    }

    #endregion



    // =============== constructors ==================
    #region Constructors
    private int GetNextID()
    {
        return 1;
    }

    public User()
    {
       // _userID = GetNextID();
    }

     public User(int userID) // Constructor with parameter
    {
        //Constructors for existing user
      //  if (userID == 1)
      //  {
           // _userID = 1;
           // _role = 1;
           // Email = "nino_gilberto@hotmail.com";
           // UserName = "Gilberto";
        //}
       // else
        // {
           // throw new Exception("Invalid User");
        // }
    }
    #endregion 
   
   

    // =============== helper methods ======================
    #region HelperMethods
     public static bool IsAdmin(User user)
     {
         if (user.Role==1)
         {
             return true; 
         }
         else
         {
         return false;
         }
     }

     public static string CompleteInfo(User user)
     {
         string userName = user.UserName + " ";
         string email = user.Email;
         string completeName = userName + email;
         return completeName;
     }
     
     #endregion



    // =============== general methods ======================
    // The general methods are those methods that become part of your API for the class. As such, all general
    // methods are written using the public access specifi er.
    #region GeneralMethods
    /*****
    * Purpose: To valid access user
    *          taken from the book Beginning Object-Oriented Programming with c#
    *          18/07/2012, p. 258.
    *
    * Parameter list:
    *           string UserName is not the name of employee
    *           string Password is secret word not display
    *
    * Return value:
    *           boolean true if a valid user, false is not valid
    *****/

    /// <summary cref="C &lt; T &gt;">
    /// Login Gil
    /// </summary>
    /// <example>  
    /// This sample shows how to call the <see cref="Login"/> method.
    /// <code> 
    /// class TestClass  
    /// { 
    ///     static int Main()  
    ///     { 
    ///         return GetZero(); 
    ///     } 
    /// } 
    /// </code> 
    /// </example> 
    /// <returns>valor gil</returns>
    /// <remarks>Remarks</remarks>
    public bool Login(string UserName, string Password)
    {
        if (UserName == "gil" & Password == "123123")
        {
            _userID = 1;
            return true;
        }
        else
        {
            return false;
        }
    }


    public int AddUser(string UserName, string Password)
    {
        return 0;
        
    }

    public string Update(string UserName, string Password)
    {
        return "Security info update";
    }

    public string Update(string UserName) //Overloading a class method
    {
        return "User update";
    }

    
    #endregion
}

