using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int rank)
        {
            Rank = rank;
        }
        [Required]
        public int Rank { get; set; }
        [Required]
        public string Name { get; set; }

        public string? FavDish { get; set; } = "N/A";
        [Required]
        public string Address { get; set; }

        public string? Phone { get; set; } = "N/A";
        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Home Phone")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Invalid phone number input")]

        public string? SiteLink { get; set; } = "No website";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                Name = "Aloha Plate",
                FavDish = "Katsu Plate Lunch",
                Address = "Cougareat Food Court Suite 2270, Provo, UT 84602",
                Phone = "(801) 422-4134",
                SiteLink = "https://www.facebook.com/Aloha-Plate-534614346951419/"
            };

            Restaurant r2 = new Restaurant(2)
            {
                Name = "Greek 'n' Go",
                FavDish = "Lamb Gyro",
                Address = "1523 N Canyon Rd, Provo, UT 84604",
                Phone = "(385) 230-0044",
                SiteLink = "https://www.facebook.com/GreeknGo/"
            };

            Restaurant r3 = new Restaurant(3)
            {
                Name = "Good Move Cafe",
                FavDish = "Battleship Burger",
                Address = "1 E Center St #100, Provo, UT 84601",
                Phone = "(801) 850-9113",
                SiteLink = "https://goodmovecafe.com/"
            };

            Restaurant r4 = new Restaurant(4)
            {
                Name = "Brick Oven Restaurant",
                FavDish = "Buffalo Chicken Pizza",
                Address = "111 E 800 N, Provo, UT 84606",
                Phone = "(801) 374-8800",
                SiteLink = "https://www.brickovenrestaurants.com/"
            };

            Restaurant r5 = new Restaurant(5)
            {
                Name = "Costa Vida",
                FavDish = "Sweet Pork Quesadilla",
                Address = "1200 N University Ave, Provo, UT 84606",
                Phone = "(801) 373-1876",
                SiteLink = "https://www.costavida.com/locations/ut/provo"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
