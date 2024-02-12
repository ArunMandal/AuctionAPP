using AuctionAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace AuctionAPP.Data.Services
{
    public class ListingsService : IListingsService
    {
        private readonly ApplicationDbContext _context;

        public ListingsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Listing listing)
        {

            _context.Listings.Add(listing);
            await _context.SaveChangesAsync();


        }

        public IQueryable<Listing> GetAll()
        {
            var itmList = _context.Listings.Include(l => l.User);
            return itmList;
        }

        public async Task<Listing> GetById(int? id)
        {
            var itm=await _context.Listings.FindAsync(id);
          
            return itm;

        }
    }
}
