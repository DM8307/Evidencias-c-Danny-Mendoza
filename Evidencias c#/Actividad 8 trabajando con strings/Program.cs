// See https://aka.ms/new-console-template for more information
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Actividad_9_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string miString = "My \"so-called\" life";            //quotes ("") en el texto
            //string miString = "What if I needa]nnew line?";      //new line salto de linea
            //string miString = "Go to your C:\\ drive";         //backslsh colocar \ en el string
            //string miString = @"Go to your C:\ drive";        //blackslash 2 @ para colocar el \

            //string miString = String.Format("{1} = {0}", "First", "Second");

            //string miString = String.Format("{0:C}", 1234);
            //string miString = String.Format( "{0:N}", 123456789);
            //string miString = String.Format("Percentage: {0:P}", .1234);
            //string miString = String.Format("Phone Number: {0:(###)-(###)-(####)", 1234567890);

            //string miString = ("That summer we took three across the bard ");

            ////miString = miString.Substring(6, 14);
            //miString = miString.ToUpper();
            //miString = miString.Replace(" ", "--");
            //miString = miString.Remove(6, 14);

            /*
            miString = String.Format("Length before : {0} -- length after: {1}",
                miString.Length, miString.Trim().Length);
             */

            StringBuilder miString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                miString.Append("--");
                miString.Append(i);
            }

            Console.WriteLine(miString);
            Console.ReadLine();
        }
    }
}
