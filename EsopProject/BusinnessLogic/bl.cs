using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            int a = 1;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "some\\DataFile.txt");
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            if (File.Exists("DataFile.txt"))
            {
                File.AppendAllText(@"..\Files\DataFile.txt", "" + DateTime.Now + "Factorial of Number " + InputNumber + " = " + Output + Environment.NewLine);
            }
            //File.AppendAllText(
            //"FileAppendAllText.txt",
            //"line1" + Environment.NewLine +
            //"line2" + Environment.NewLine +
            //"line3" + Environment.NewLine);

            //using (StreamWriter stream = File.AppendText("FileAppendText.txt"))
            //{
            //    stream.WriteLine("line1");
            //    stream.WriteLine("line2");
            //    stream.WriteLine("line3");
            //}

            return Output;
        }
    }
}