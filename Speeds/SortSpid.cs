using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Speeds
{
    class SortSpid
    {
        private static string ChekLineFide(string item)
        {
            
             return item.EndsWith("\r") ? item.Remove(item.Length - 1):item;
           
        }

        public static Dictionary<string,double> ListSpeeds(List<string> list)
        {
            Dictionary<string, double> spid = new Dictionary<string, double>();
         
            foreach (string item in list)
            {

                if (Regex.IsMatch(item, "\\bkmh\\b"))
                {
                   
                    spid.Add(ChekLineFide(item), Math.Round(double.Parse(Regex.Match(item, @"\d+").Value) / 3.6, 3));
                  
                }
                if (Regex.IsMatch(item, "\\bmph\\b"))
                {
                 

                    spid.Add(ChekLineFide(item), Math.Round(double.Parse(Regex.Match(item, @"\d+").Value) / 2.237, 3));
                   
                }
                if (Regex.IsMatch(item, "\\bkn\\b"))
                {
                  
                    spid.Add(ChekLineFide(item), Math.Round(double.Parse(Regex.Match(item, @"\d+").Value) / 1.944, 3));
                   
                }
                if (Regex.IsMatch(item, "\\bm/s\\b"))
                {
                    
                    spid.Add(ChekLineFide(item), double.Parse(Regex.Match(item, @"\d+").Value));
                 
                }
            }
                    
            return spid;
        }

        public static Dictionary<string, double> ListSpeedName(List<string> list)
        {       
            Dictionary<string, double> spidName = new Dictionary<string, double>();

            foreach (string item in list)
            {

                if (Regex.IsMatch(item, "\\bkmh\\b"))
                {
                   
                    spidName.Add(ChekLineFide(item), 3.6);
                  
                }
                if (Regex.IsMatch(item, "\\bmph\\b"))
                {
                    
                    spidName.Add(ChekLineFide(item), 2.237);
                   
                }
                if (Regex.IsMatch(item, "\\bkn\\b"))
                {
                    spidName.Add(ChekLineFide(item), 1.944);
                   
                }
                if (Regex.IsMatch(item, "\\bm/s\\b"))
                {
                   
                    spidName.Add(ChekLineFide(item), 1);
                }
            }

            return spidName;
        }
    }
}
