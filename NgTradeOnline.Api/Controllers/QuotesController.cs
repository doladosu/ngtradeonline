using NgTradeOnline.Core;
using System.Web.Http;

namespace NgTradeOnline.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Quotes")]
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