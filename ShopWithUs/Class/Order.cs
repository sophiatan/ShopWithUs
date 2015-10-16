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

            for (int i = 0; i < listofItem.Count(); i++)
            {
                finalbill = finalbill + listofItem[i].cost;
            }

            return finalbill - DiscountAmount(listofItem);
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

        public double DiscountAmount(Item[] listofItem)
        {
            double discountAmount = 0.0; 
            bool discounted = false;
            string pre_sku = "";
            string pre_style = "";
            
            for (int i = 0; i < listofItem.Count(); i++)
            {
                if ((listofItem[i].sku == pre_sku) && (discounted == false) && (!IsOdd(i+1)))
                {
                    discountAmount = discountAmount + (listofItem[i].cost * 0.3);
                    pre_sku = "";
                    discounted = true;
                }
                else if ((listofItem[i].styleNo == pre_style) && (discounted == false) && (!IsOdd(i+1)))
                {
                    discountAmount = discountAmount + (listofItem[i].cost * 0.5);
                    pre_style = "";
                    discounted = true;
                }
                else
                {
                    pre_sku = listofItem[i].sku;
                    pre_style = listofItem[i].styleNo;
                    discounted = false;
                }
            }

            return discountAmount;
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}