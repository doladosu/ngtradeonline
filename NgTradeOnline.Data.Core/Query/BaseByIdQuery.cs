using NgTradeOnline.Core;

namespace NgTradeOnline.Data.Core.Query
{
    public class BaseByIdQuery : IQuery
    {
        public int Id { get; set; }
        public string UserId { get; set; }
    }
}