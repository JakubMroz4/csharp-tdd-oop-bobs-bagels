using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise.main.Items;

namespace exercise.main
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

        public static IInventoryProduct BGLO()
        {
            return new Bagel("BGLO", 0.49m);
        }

        public static IInventoryProduct BGLP()
        {
            return new Bagel("BGLP", 0.39m);
        }

        public static IInventoryProduct BGLE()
        {
            return new Bagel("BGLE", 0.49m);
        }

        public static IInventoryProduct BGLS()
        {
            return new Bagel("BGLS", 0.49m);
        }

        public static IInventoryProduct COFB()
        {
            return new Coffee("COFB", 0.99m);
        }

        public static IInventoryProduct COFW()
        {
            return new Coffee("COFB", 1.19m);
        }

        public static IInventoryProduct COFC()
        {
            return new Coffee("COFC", 1.29m);
        }

        public static IInventoryProduct COFL()
        {
            return new Coffee("COFL", 1.29m);
        }

        public static IInventoryProduct FILB()
        {
            return new Filling("FILB", 0.12m);
        }

        public static IInventoryProduct FILE()
        {
            return new Filling("FILE", 0.12m);
        }

        public static IInventoryProduct FILC()
        {
            return new Coffee("FILC", 0.12m);
        }

        public static IInventoryProduct FILX()
        {
            return new Coffee("FILX", 0.12m);
        }

        public static IInventoryProduct FILS()
        {
            return new Coffee("FILS", 0.12m);
        }

        public static IInventoryProduct FILH()
        {
            return new Coffee("FILH", 0.12m);
        }
    }
}
