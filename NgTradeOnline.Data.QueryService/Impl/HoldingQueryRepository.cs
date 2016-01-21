using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService.Impl
{
    public class HoldingQueryRepository : BaseRepository, IHoldingQueryRepository
    {
        public Task<IEnumerable<Holding>> GetHoldings(string userId)
        {
            throw new System.NotImplementedException();
        }
    }
}