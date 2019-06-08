using System;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PortableNetbeans
{
    public static void Main(string[] args)
    {

        FileXML maven;

        try
        {            
            string currentPath = Directory.GetCurrentDirectory();
            string filePath = currentPath + @"\netbeans\java\maven\conf";
            maven = new FileXML(filePath, "settings");
            maven.GetElementsByTagName("localRepository")[0].InnerText = currentPath + @"\m2LocalRepository\";
            maven.SaveAndWriteXMLFile();
        }
        catch (Exception) { }

        System.Diagnostics.Process.Start(@"netbeans\bin\netbeans64.exe");

        ReadKey();
    }
}