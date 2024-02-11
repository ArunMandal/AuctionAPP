using AuctionAPP.Models;

namespace AuctionAPP.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
    }
}
