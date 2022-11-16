using System;
using System.Xml;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;

namespace _1027
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100000];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(200000, 5500000);
                Console.WriteLine(array[i]);
            }

            //XmlTextWriter textWriter = new XmlTextWriter("C:\\Users\\CCFG8D\\source\\repos\\file.xml", null);
            XmlTextWriter textWriter = new XmlTextWriter("C:\\Users\\Dominik\\source\\repos\\file.xml", null);
            textWriter.WriteStartDocument();
            Stopwatch clock = Stopwatch.StartNew();
            clock.Start();
            textWriter.WriteStartElement("Payments");
            for (int i = 0; i < array.Length; i++)
            {
                textWriter.WriteStartElement("Payment");
                textWriter.WriteString(array[i].ToString());
                textWriter.WriteEndElement();
            }
            textWriter.WriteEndElement();
            clock.Stop();
            Console.WriteLine("XML-be írás ideje " + clock.ElapsedMilliseconds + "ms");
            textWriter.WriteEndDocument();
            textWriter.Close();
            string utvonal = "C:\\Users\\Dominik\\source\\repos\\fizetesek.csv";
            Stopwatch csv = Stopwatch.StartNew();
            csv.Start();
            StreamWriter fiz = new StreamWriter(utvonal);
            foreach (int item in array)
            {
                fiz.Write("Fizetes: " + item);
                fiz.WriteLine();
            }
            fiz.Close();
            csv.Stop();
            Console.WriteLine("CSV-be írás ideje " + csv.ElapsedMilliseconds + "ms");
            //int[] array2 = new int[100000]; 
            //XmlTextReader textReader = new XmlTextReader("C:\\Users\\CCFG8D\\source\\repos\\file.xml");
            XmlTextReader textReader = new XmlTextReader("C:\\Users\\Dominik\\source\\repos\\file.xml");
            //var document = XDocument.Load("C:\\Users\\CCFG8D\\source\\repos\\file.xml");
            var document = XDocument.Load("C:\\Users\\Dominik\\source\\repos\\file.xml");
            Stopwatch clock2 = Stopwatch.StartNew();
            var array2 = new int[100000];
            var array3 = document.Descendants("Payment").Select(x => (int)x).ToArray();
            clock2.Start();
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array3[i];
            }
            clock2.Stop();
            Console.WriteLine("XML-ből olvasás ideje " + clock2.ElapsedMilliseconds + "ms" );
            Stopwatch csv2 = Stopwatch.StartNew();
            csv2.Start();
            var column = new List<string>();
            using (var rd = new StreamReader(utvonal))
            {
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine();
                    column.Add(splits);
                }
            }
            csv2.Stop();
            Console.WriteLine("CSV-ből olvasás ideje " + csv2.ElapsedMilliseconds + "ms");
            // print column1
            /*Console.WriteLine("Column 1:");
            foreach (var element in column)
                Console.WriteLine(element);*/
        }
    }

}
