using csharpcore.Items;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (Item item in Items)
            {
                Item newItem;

                switch (item.Name)
                {
                    case "Aged Brie":
                        newItem = new AgedBrie();
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        newItem = new BackstagePasses();
                        break;
                    case "Conjured Mana Cake":
                        newItem = new Conjured();
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        newItem = new LegendarySulfuras();
                        break;
                    default:
                        newItem = new Item();
                        break;
                }

                newItem.UpdateItemQuality(item);
            }
        }

    }
}
