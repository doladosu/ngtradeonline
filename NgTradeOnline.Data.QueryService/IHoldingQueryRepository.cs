using NgTradeOnline.Core;
using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService
{
    public interface IHoldingQueryRepository : IRepository
    {
        Task<IEnumerable<Holding>> GetHoldings(string userId);
    }
}