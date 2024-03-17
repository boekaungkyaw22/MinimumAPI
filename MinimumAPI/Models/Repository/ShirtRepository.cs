namespace MinimumAPI.Models.Repository
{
    public static class ShirtRepository
    {
        private static  List<Shirts> shirts = new List<Shirts>()
        {
            new Shirts { ShirtId = 1, Brand = "My Brand", Color = "Blue", Gender = "Men", Price = 30, Size = 10 },
            new Shirts { ShirtId = 2 , Brand = "My Brand", Color = "Black", Gender = "Men", Price = 35, Size = 12},
            new Shirts { ShirtId = 3 , Brand = "Your Brand", Color = "Green", Gender = "Women", Price = 45, Size = 8 },
            new Shirts { ShirtId = 4, Brand = "Your Brand", Color = "Yelloe" , Gender = "Women", Price = 45, Size = 9}
        };

        public static bool ShirtExist (int id)
        {
            return shirts.Any(x => x.ShirtId == id);     
        }

        public static List<Shirts> GetShirts ()
        {
            return  shirts.ToList();    
        }

        public static Shirts? GetShirtById( int id)
        {
            return shirts.FirstOrDefault(x => x.ShirtId == id);
        }
    }
}
