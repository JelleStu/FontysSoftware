using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Channel
{
    private String name;
    private int channelnumber;

    public Channel(String name, int channelnumber)
    {
        this.name = name;
        this.channelnumber = channelnumber;
    }

    public String getName()
    {
        return name;
    }

    public int GetChannelnumber()
    {
        return channelnumber; 
    }
}