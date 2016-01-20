using NgTradeOnline.Models.Output;
using System.Collections.Generic;

namespace NgTradeOnline.Data.Core.QueryResult.Contest
{
    public class ContestQueryResult : BaseQueryResult
    {
        public IEnumerable<Contests> Contests { get; set; }
    }
}
