using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelebeCs
{
    public class TelebeBilgi
    {
        public string Name;
        public string Surname;
        public byte GroupPoint;
        public bool Graduated = true;

        public TelebeBilgi(string name, string surname, byte groupPoint, bool graduated)
        {
            Name = name;
            Surname = surname;
            GroupPoint = groupPoint;
            Graduated = graduated;
        }


    }
}
