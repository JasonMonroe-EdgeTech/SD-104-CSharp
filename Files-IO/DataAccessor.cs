using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_IO
{
    class DataAccessor
    {
       


        public DataAccessor()
        { 
            

            //Try to open text files
            try
            {
                //using block automatically disposes stream after use.
                using (StreamReader textFile1 = new StreamReader("wordbank.txt"))
                {
                    Console.Write(textFile1.ReadLine());
                }
                    
            }
            catch(Exception ex)
            {
                Console.WriteLine("The following exception occured: " + ex.ToString());
            }
            finally
            {
                //do some more stuff regardless of whether an exception was thrown. 
            }
            
        }
        
        //public string GetWord()
        //{

        //}


    }
}
