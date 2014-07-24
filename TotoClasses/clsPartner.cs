using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Partner :clsPerson
{
    private int _partnerID;
    private string _state;
    private DateTime _experirationDate;
    public static readonly string SetDefaultState = "vigente"; // book: pro_.net_best_practices pag: 117
    
    public DateTime ExperirationDate
    {
        get { return _experirationDate; }
        set { _experirationDate = value; }
    }
    

    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    
    public int PartnerID
    {
        get { return _partnerID; }
        set { _partnerID = value; }
    }
    
}
