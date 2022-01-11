using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class WriteFullFail
    {
        public static void writeFile() {

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

            WorkFaile.WriteFaile(spids1.ToString());
        }
    }
}
