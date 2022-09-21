using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class NewCalss
    {
        public static int c = 0;


        public NewCalss()
        {
            c++;
        }
        ~NewCalss()
        {
            c--;
        }

    }
}
