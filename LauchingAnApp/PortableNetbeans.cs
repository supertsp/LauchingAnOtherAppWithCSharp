using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PortableNetbeans
{
    public static void Main(string[] args)
    {
        System.Diagnostics.Process.Start(@"netbeans\bin\netbeans64.exe");
    }
}