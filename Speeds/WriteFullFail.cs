using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class WriteFullFail
    {
        public static void writeFile() {

          
            if (!File.Exists("input.txt"))
            {
                string inputFile = "1 m/s\n\n1 kmh\n\n1 mph\n\n1 kn\n\n2 m/s\n\n2 kmh\n\n2 mph\n\n2 kn\n\n3 m/s\n\n3 kmh\n\n3 mph\n\n3 kn";
                WorkFaile.WriteFaile(inputFile, "input.txt");
            }
           

            List<string> list = WorkFaile.ListSpeeds().Split('\n').ToList();

            list.RemoveAll(r => r.Length == 1);

            StringBuilder spids1 = new StringBuilder();

            foreach (var item in SortSpid.ListSpeeds(list).OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                spids1.Append(item.Key + "\n\n");
            }

            spids1.Append("\n\n");

            foreach (var item in SortSpid.ListSpeedName(list).OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value))
            {
                spids1.Append(item.Key + "\n\n");
            }

            spids1.Append("\n\n");

            foreach (var item in SortSpid.ListSpeeds(list))
            {
                spids1.Append(item.Key + "=" + item.Value + " m/s \n\n");
            }

            WorkFaile.WriteFaile(spids1.ToString(), "output.txt");
        }
    }
}
