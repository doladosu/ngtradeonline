using NgTradeOnline.Core;
using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService
{
    public interface IQuoteQueryRepository : IRepository
    {
        Task<IEnumerable<Quote>> GetAllQuotes();
        Task<IEnumerable<Quote>> GetDayGainers(int? take);
        Task<IEnumerable<Quote>> GetDayLosers(int? take);
    }
}