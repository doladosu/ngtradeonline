using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService.Impl
{
    public class QuoteQueryRepository : BaseRepository, IQuoteQueryRepository
    {
        public async Task<IEnumerable<Quote>> GetAllQuotes()
        {
            throw new System.NotImplementedException();

            // return await Db.Quotes.ToListAsync();
        }

        public Task<IEnumerable<Quote>> GetDayGainers(int? take)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Quote>> GetDayLosers(int? take)
        {
            throw new System.NotImplementedException();
        }
    }
}
