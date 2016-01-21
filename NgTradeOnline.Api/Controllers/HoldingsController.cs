using NgTradeOnline.Core;

namespace NgTradeOnline.Api.Controllers
{
    public class HoldingsController : BaseApiController
    {
        public HoldingsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(commandDispatcher, queryDispatcher)
        {
        }
    }
}
