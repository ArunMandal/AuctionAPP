using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionAPP.Models
{
    public class ListingVM
    {


        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int price { get; set; }
        public IFormFile Image { get; set; }

        public bool IsSold { get; set; }=false;

        [Required]
        public string IdentityUserId { get; set; }

        [ForeignKey("IdentityUserId")]

        public IdentityUser? User { get; set; }

    }
}
