namespace GildedRose
{
    public class Product
    {
        public string Name { get; }
        public int SellIn { get; set; }
        public int Quality { get; set; }
        public DateTime ExpDate { get; set; }


        public Product(string v1, int v2, int v3, DateTime v4)
        {
            this.Name = v1;
            this.SellIn = v2;
            this.Quality = v3;
            this.ExpDate = v4;
        }

        public void updateProduct()
        {
            DateTime today = DateTime.Now;
            int PlusQuality=0;


            if (SellIn <= 10 && SellIn > 5)
            {
                PlusQuality = 2;
            }
            else if(SellIn <= 5 && SellIn > 0)
            {
                PlusQuality = 3;
            }
            

            if(Name == "Aged Brie")
            {
                if(PlusQuality==0)
                this.Quality = Quality < 0 ? this.Quality = 0 : Quality > 50 ? this.Quality = 50 : this.Quality + 1;
                else
                this.Quality = Quality < 0 ? this.Quality = 0 : Quality > 50 ? this.Quality = 50 : this.Quality + PlusQuality;

            }
            else
            {
                if (Name == "Sulfuras")
                {
                    this.Quality = Quality < 0 ? this.Quality = 0 : Quality > 50 ? this.Quality = 50 : this.Quality = Quality;
                }
                else
                {
                    if (today > ExpDate)
                    {
                        this.Quality = Quality < 0 ? this.Quality = 0 : this.Quality - 2;
                    }
                    else
                    {
                        this.Quality = Quality < 0 ? this.Quality = 0 : this.Quality - 1;
                        this.SellIn = SellIn < 0 ? this.SellIn = 0 : this.SellIn - 1;
                    }
                }
                
            }

            

        }
    }
}
