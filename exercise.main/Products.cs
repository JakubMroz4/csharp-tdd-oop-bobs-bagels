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

        public static Bagel BGLO()
        {
            return new Bagel("BGLO", 0.49m);
        }

        public static Bagel BGLP()
        {
            return new Bagel("BGLP", 0.39m);
        }

        public static Bagel BGLE()
        {
            return new Bagel("BGLE", 0.49m);
        }

        public static Bagel BGLS()
        {
            return new Bagel("BGLS", 0.49m);
        }

        public static Coffee COFB()
        {
            return new Coffee("COFB", 0.99m);
        }

        public static Coffee COFW()
        {
            return new Coffee("COFB", 1.19m);
        }

        public static Coffee COFC()
        {
            return new Coffee("COFC", 1.29m);
        }

        public static Coffee COFL()
        {
            return new Coffee("COFL", 1.29m);
        }

        public static Filling FILB()
        {
            return new Filling("FILB", 0.12m);
        }

        public static Filling FILE()
        {
            return new Filling("FILE", 0.12m);
        }

        public static Filling FILC()
        {
            return new Filling("FILC", 0.12m);
        }

        public static Filling FILX()
        {
            return new Filling("FILX", 0.12m);
        }

        public static Filling FILS()
        {
            return new Filling("FILS", 0.12m);
        }

        public static Filling FILH()
        {
            return new Filling("FILH", 0.12m);
        }
    }
}
