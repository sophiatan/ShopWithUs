using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWithUs.Class
{
    public class order
    {
        public double totalbill(Item[] listofItem)
        {
            double finalbill = 0.0;
            int count = 0;


            foreach (Item i in listofItem)
            {
                finalbill = finalbill + i.cost;
                count++;
            }

            for (int i = 0; i < listofItem.Count(); i++)
            {

            }

            return finalbill;
        }

        public double CalTotalAmountWithOutDis(Item[] listofItem)
        {
            double calTotal = 0.0;

            for (int i = 0; i < listofItem.Count(); i++)
            {
                calTotal = calTotal + listofItem[i].cost;
            }

            return calTotal;
        }
    }
}