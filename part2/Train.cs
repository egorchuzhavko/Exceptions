using System;

namespace part2
{
    public class Train
    {
        private string punktnaznach;
        private string idpoezda;
        private DateTime vrotpravleniya;

        public string Punktnaznach { get { return punktnaznach; } }
        public string Idpoezda { get { return idpoezda; } }
        public DateTime Vrotpravleniya { get { return vrotpravleniya; } }

        public Train(string punktnaznach, string idpoezda, DateTime vrotpravleniya)
        {
            this.punktnaznach = punktnaznach;
            this.idpoezda = idpoezda;
            this.vrotpravleniya = vrotpravleniya;
        }

        public static bool operator ==(Train t1, Train t2)
        {
            return t1.Vrotpravleniya == t2.Vrotpravleniya ? true : false;
        }
        public static bool operator !=(Train t1, Train t2)
        {
            return t1.Vrotpravleniya != t2.Vrotpravleniya ? true : false;
        }
    }
}