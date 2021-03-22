using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class NormalItem : Item
    {
        public override void UpdateItemQuality(Item item)
        {
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 1;
            }

            item.Quality = (item.Quality < 0) ? 0 : item.Quality;
        }
    }
}
