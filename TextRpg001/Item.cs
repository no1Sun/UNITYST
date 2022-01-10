using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
    public Item() { }

   
    public Item(string _Name, int _Gold)
    {
        Name = _Name;
        Gold = _Gold;
    }

    private string mName;
        
    public string Name
    {
        get { return mName; }
        set { mName = value; }
    }

    private int mGold;

    public int Gold
    {
        get { return mGold; }
        set { mGold = value; }
    }

    

}