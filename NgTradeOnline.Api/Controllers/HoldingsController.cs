using NgTradeOnline.Core;
using System.Web.Http;

namespace NgTradeOnline.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/Holdings")]
    public class HoldingsController : BaseApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandDispatcher"></param>
        /// <param name="queryDispatcher"></param>
        public HoldingsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(commandDispatcher, queryDispatcher)
        {
        }
    }
}
