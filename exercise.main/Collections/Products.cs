using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Items;

namespace exercise.main.Collections
{
    public static class Products
    {
        /*
BGLO	0.49	Bagel	Onion
BGLP	0.39	Bagel	Plain
BGLE	0.49	Bagel	Everything
BGLS	0.49	Bagel	Sesame

COFB	0.99	Coffee	Black
COFW	1.19	Coffee	White
COFC	1.29	Coffee	Capuccino
COFL	1.29	Coffee	Latte

FILB	0.12	Filling	Bacon
FILE	0.12	Filling	Egg
FILC	0.12	Filling	Cheese
FILX	0.12	Filling	Cream Cheese
FILS	0.12	Filling	Smoked Salmon
FILH	0.12	Filling	Ham
         */

        public static Bagel BGLO()
        {
            var sku = "BGLO";
            return new Bagel("Onion Bagel" ,sku, Prices.SkuToPriceMap[sku]);
        }

        public static Bagel BGLP()
        {
            var sku = "BGLP";
            return new Bagel("Plain Bagel", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Bagel BGLE()
        {
            var sku = "BGLE";
            return new Bagel("Everything Bagel", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Bagel BGLS()
        {
            var sku = "BGLS";
            return new Bagel("Sesame Bagel", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Coffee COFB()
        {
            var sku = "COFB";
            return new Coffee("Black Coffee", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Coffee COFW()
        {
            var sku = "COFW";
            return new Coffee("White Coffee", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Coffee COFC()
        {
            var sku = "COFC";
            return new Coffee("Capuccino", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Coffee COFL()
        {
            var sku = "COFL";
            return new Coffee("Latte", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILB()
        {
            var sku = "FILB";
            return new Filling("Bacon", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILE()
        {
            var sku = "FILE";
            return new Filling("Egg", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILC()
        {
            var sku = "FILC";
            return new Filling("Cheese", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILX()
        {
            var sku = "FILX";
            return new Filling("Cream Cheese", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILS()
        {
            var sku = "FILS";
            return new Filling("Smoked Salmon", sku, Prices.SkuToPriceMap[sku]);
        }

        public static Filling FILH()
        {
            var sku = "FILH";
            return new Filling("Ham", sku, Prices.SkuToPriceMap[sku]);
        }
    }
}
