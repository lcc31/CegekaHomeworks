using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class Conjured : Item
    {
        public override void UpdateItemQuality(Item item)
        {
            item.SellIn--;
         
            if (item.SellIn < 0)
            {
                item.Quality -= 4;
            }
            else
            {
                item.Quality -= 2;
            }

            item.Quality = (item.Quality < 0) ? 0 : item.Quality;
        }
    }
}
