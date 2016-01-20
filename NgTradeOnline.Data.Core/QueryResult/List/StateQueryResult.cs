using NgTradeOnline.Models.Output;
using System.Collections.Generic;

namespace NgTradeOnline.Data.Core.QueryResult.List
{
    public class StateQueryResult : BaseQueryResult
    {
        public IEnumerable<State> States { get; set; }
    }
}