using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exam1_Restaurant
{
    public static class FileReader
    {
        
        public static List<string> ReadContent(string path)
        {
            List<string> result = new List<string>();
            try
            {
                result = File.ReadLines(path).ToList();
            }
            catch(FileNotFoundException ex)
            {
                GetExceptionMessage(ex);
            }
            catch (DirectoryNotFoundException ex)
            {
                GetExceptionMessage(ex);
            }
            catch(PathTooLongException ex)
            {
                GetExceptionMessage(ex);
            }
            catch (ArgumentNullException ex)
            {
                GetExceptionMessage(ex);
            }
            catch (ArgumentException ex)
            {
                GetExceptionMessage(ex);
            }
            catch(IOException ex)
            {
                GetExceptionMessage(ex);
            }
            catch(SecurityException ex)
            {
                GetExceptionMessage(ex);
            }
            catch(UnauthorizedAccessException ex)
            {
                GetExceptionMessage(ex);
            }
            return result;
        }
        private static void GetExceptionMessage(SystemException ex)
        {
            Console.WriteLine(ex.Message);
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
  
    }


}
