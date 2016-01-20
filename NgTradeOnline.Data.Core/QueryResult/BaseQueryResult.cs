using NgTradeOnline.Core;

namespace NgTradeOnline.Data.Core.QueryResult
{
    public class BaseQueryResult : IQueryResult
    {
        public int TotalRecords { get; set; }
    }
}