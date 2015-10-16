using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWithUs.Class
{
    public class Item
    {
        string _StyleNo;
        public string styleNo
        {
            get
            {
                return this._StyleNo;
            }
            set
            {
                this._StyleNo = value;
            }
        }
        string _SKU;
        public string sku
        {
            get
            {
                return this._SKU;
            }
            set
            {
                this._SKU = value;
            }
        }
        double _cost;
        public double cost
        {
            get
            {
                return this._cost;
            }
            set
            {
                this._cost = value;
            }
        }
        public Item()
        {
        }

        public Item(string styleNo, string sku, double cost)
        {
            _StyleNo = styleNo;
            _SKU = sku;
            _cost = cost;
        }


    }
}
