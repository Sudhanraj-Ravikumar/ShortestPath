using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    public class Logger
    {
        private string m_exePath = string.Empty;
        
        public void LogWrite(string logMessage1, string logmessage2, string logmessage3, string logmessage4)
        {
            m_exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            try
            {
                using (StreamWriter w = File.AppendText(m_exePath + "\\" + "log.txt"))
                {
                    Log(logMessage1,logmessage2, logmessage3, logmessage4, w);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void Log(string logMessage1, string logmessage2, string logmessage3, string logmessage4, TextWriter txtWriter)
        {
            try
            {
                txtWriter.Write("\r\nToken Entry : ");
                //txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    //DateTime.Now.ToLongDateString());
                //txtWriter.WriteLine("  :");
                txtWriter.WriteLine("  Token created in Node {3} with token message : Source Node {0} destination node {1} distance {2} "
                    , logMessage1,logmessage2,logmessage3,logmessage4);
                //txtWriter.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
            }
        }
    }
}
