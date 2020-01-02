using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sap.Data.Hana;

namespace SapHanaPetapoco
{
    public class HANAConsole
    {
        static void Main(string[] args)
        {

            HanaConnection conn = new HanaConnection("Server=$userHost$:$userPort$;UserName=$userName$;Password=$userPassword$");
            conn.Open();
            HanaCommand cmd = new HanaCommand("select 'Hello, World' from DUMMY", conn); // Exception
            try
            {
                HanaDataReader reader = cmd.ExecuteReader();
                reader.Read();
                Console.WriteLine(reader.GetString(0));
            }
            catch (Exception e)
            {
                String errorMsg = e.ToString();
                Console.WriteLine(errorMsg);
            }
        }
    }
}
