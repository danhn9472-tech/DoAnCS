using DoAnCS.Models;

namespace DoAnCS.Data
{
    public class FData
    {
        public static List<Tip> Tips = new List<Tip>
        {
            new Tip {
                Id = 1,
                Title = "Cách nấu ức gà không bị khô",
                Content = "Luộc với gừng và không nấu quá lâu...",
                Category = "Gym",
                ImageUrl = "/images/OIP.jpg",
                CreatedAt = DateTime.Now
            },
            new Tip {
                Id = 2,
                Title = "5 thực phẩm giúp giảm cân",
                Content = "Yến mạch, trứng, ức gà...",
                Category = "Giảm cân",
                ImageUrl = "/images/h.jpg",
                CreatedAt = DateTime.Now
            }
        };
    }
}
