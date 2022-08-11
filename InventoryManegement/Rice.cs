using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManegement
{
    public class Rice
    {
        public List<TypeOfWheats> typeOfRice;
        public List<TypeOfWheats> typeOfWheats;
        public List<TypeOfPulses> typeOfPulses;
    }
    public class TypeOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypeOfWheats
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
}
