using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public partial class Airplane
{

    public void print_passengers()
    {
        for (int i = 0; i < passengers.Length; i++)
        {
            passengers[i].get_info();
        }
    }

}