using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public static class DB
    {
        public static void IncarcaMasini()
        {
            string[] liniitext = RentACar.Properties.Resources.Masini.Split('\n');
            DataSet1TableAdapters.masiniTableAdapter tba = new DataSet1TableAdapters.masiniTableAdapter();
            foreach(string text in liniitext)
            {
                string[] date = text.Split(',');
                tba.Insert(date[0], date[1], int.Parse(date[2]), date[3], date[4], float.Parse(date[5]), int.Parse(date[6]));
            }
        }
    }
}
