
using AuctionAPP.Models;

namespace AuctionAPP.Data.Services
{
    public interface IBidsService
    {
        Task Add(Bid bid);
        IQueryable<Bid> GetAll();
    }
}
