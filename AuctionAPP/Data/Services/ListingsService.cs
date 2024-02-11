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
        public IQueryable<Listing> GetAll()
        {
            var applicationDbContext = _context.Listings.Include(l => l.User);
            return applicationDbContext;
        }
    }
}
