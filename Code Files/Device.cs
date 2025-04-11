using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFullMark
{
    public class Device { 


        public string name;
        public string OS;
        public int storage;
        public int RAM;


        public Device() { }


        public Device (string name, string OS, int storage , int RAM) {
            this.name = name; 
            this.OS = OS;
            this.storage = storage;
            this.RAM = RAM;
    
        }
 

    }

}
