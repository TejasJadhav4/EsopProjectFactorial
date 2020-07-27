using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web;

namespace EsopProject.BusinnessLogic
{
    public class Implementation
    {
       public static double SaveText(int InputNumber)
        {
            double Output = 1;
            for (int i = InputNumber; i > 1; i--)
            {
                Output = Output * i;
            }
            string pathToFiles = HttpContext.Current.Server.MapPath("/App_Data") + @"\DataFile.txt";
            pathToFiles = pathToFiles.Replace(@"\\", @"/");
            pathToFiles = pathToFiles.Replace(@"\", @"/");
            if (File.Exists(pathToFiles))
            {
                File.AppendAllText(pathToFiles, "" + DateTime.Now + "- Factorial of Number " + InputNumber + " = " + Output + Environment.NewLine);
            }
            return Output;
        }
    }
}