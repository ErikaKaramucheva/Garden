using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework2
{
    class Garden
    {
        public List<IGardenItem> gardenItems { get; set; } = new List<IGardenItem>();

        
        public List<IFood> Foods {
            get
            {
                var foodItem = gardenItems.Where(x => x.GetType() is IFood);
                return (List<IFood>)foodItem; } }

        public List<IBeauty> Beauties
        {
            get
            {
                var beautyItem = gardenItems.Where(x => x.GetType() is IBeauty);
                return (List<IBeauty>)beautyItem;
            }
        }
    }
}
