using NgTradeOnline.Core;

namespace NgTradeOnline.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class QuotesController : BaseApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandDispatcher"></param>
        /// <param name="queryDispatcher"></param>
        public QuotesController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(commandDispatcher, queryDispatcher)
        {
        }
    }
}