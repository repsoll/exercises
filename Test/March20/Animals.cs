using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.March20.Enums;

namespace Test.March20
{
    public class Animals
    {
        public int AnimalID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public Habitat Habitat { get; set; } 
        public DietType DietType { get; set; }
    }
}
