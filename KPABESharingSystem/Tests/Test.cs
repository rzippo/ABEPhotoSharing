﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KPServices;

namespace Tests
{
    class Test
    {
        static void Main(string[] args)
        {
            //String universe = "canide eta=18 cosi";

            //KPService.UniverseFilename = "universe2";
            //KPService.SuitePath = @"D:\Documenti\GitHub\ABEPhotoSharing\KPABESharingSystem\Tests\bin\Debug\kpabe\";

            /*List<UniverseAttribute> attributes = new List<UniverseAttribute>
            {
                new SimpleAttribute("canide"),
                new NumericalAttribute("eta", 18),
                new SimpleAttribute("cosi")
            };
            */

            //KPService.Universe = new Universe(attributes);

            
            //KPService.Setup();

            Console.WriteLine(KPService.Universe);
            return;
            
        }
    }
}
