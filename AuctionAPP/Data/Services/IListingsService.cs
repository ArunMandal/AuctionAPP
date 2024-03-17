using AuctionAPP.Models;

namespace AuctionAPP.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();

        Task Add(Listing listing);

        Task<Listing> GetById(int? id);

        Task Update(Listing listing);

        Task SaveChanges();
    }
}
