using System;
using System.Collections.Generic;
using System.Text;

namespace csharpcore.Items
{
    class LegendarySulfuras : Item
    {
        public override void UpdateItemQuality(Item item)
        {
            item.Quality = 80;
        }
    }
}
