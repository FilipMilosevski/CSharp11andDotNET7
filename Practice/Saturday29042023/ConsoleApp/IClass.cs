using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filip.Shared;

public class IClass : Interface1, Interface2, IFColor
{


    public int calcarea1(int x, int y)
    {
        return x + y;
    }

    public int calcarea2(int x, int y)
    {
        return x * y;
    }
    public int calcarea3(int x, int y)
    {
        return x - y;
    }
    public string wcolor(string x)
    {
        return x += "White";
    }
    public string rcolor(string x)
    {
        return x += "Red";
    }
}
