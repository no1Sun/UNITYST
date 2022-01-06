using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
    string mName;
    int mGold;

    
    public string Name { get => mName; set => mName = value; }
    public int Gold { get => mGold; set => mGold = value; }
}