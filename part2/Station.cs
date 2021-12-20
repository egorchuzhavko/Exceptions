using System.Collections.Generic;
using System.Security.Cryptography;

namespace part2
{
    public class Station : IComparer<Train>
    {
        private List<Train> trains;

        public Station(List<Train> trains)
        {
            this.trains = trains;
        }


        public int Compare(Train t1, Train t2)
        {
            if (t1.Vrotpravleniya > t2.Vrotpravleniya)
                return 1;
            else if (t1.Vrotpravleniya < t2.Vrotpravleniya)
                return -1;
            else
                return 0;
        }
    }
}