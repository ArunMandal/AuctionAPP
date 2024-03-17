

using AuctionAPP.Models;

namespace AuctionAPP.Data.Services
{
    public interface ICommentsService
    {
        Task Add(Comment comment);
    }
}
