using csharpcore.Items;
using System;

namespace csharpcore.Items
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public virtual void UpdateItemQuality(Item item){ }

    }
}
