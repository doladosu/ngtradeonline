using NgTradeOnline.Api.Setup.Core;
using NgTradeOnline.Core;
using NgTradeOnline.Data.Core.Query;
using NgTradeOnline.Data.Core.QueryResult.List;
using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.OData;

namespace NgTradeOnline.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ListController : BaseApiController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="commandDispatcher"></param>
        /// <param name="queryDispatcher"></param>
        public ListController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(commandDispatcher, queryDispatcher)
        {
        }

        /// <summary>
        /// Gets all List.States
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("States")]
        [EnableQuery]
        [ResponseType(typeof(IEnumerable<State>))]
        public async Task<IHttpActionResult> GetAllStates(ILoggedInPerson loggedInPerson)
        {
            return await TryAsync(async () =>
            {
                var baseByIdQuery = new BaseByIdQuery();
                var result = await QueryDispatcher.Dispatch<BaseByIdQuery, StateQueryResult>(baseByIdQuery);
                return Ok(result.States);
            }, memberParameters: new object[] { loggedInPerson });
        }

        /// <summary>
        /// Get player information
        /// </summary>
        /// <param name="loggedInPerson"></param>
        /// <param name="playerId"></param>
        /// <param name="playerName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{playerId:int}/playerName")]
        [EnableQuery]
        [ResponseType(typeof(IEnumerable<State>))]
        public async Task<IHttpActionResult> GetPlayersTask(ILoggedInPerson loggedInPerson, int playerId, string playerName)
        {
            return await TryAsync(async () =>
            {
                var baseByIdQuery = new BaseByIdQuery();
                var result = await QueryDispatcher.Dispatch<BaseByIdQuery, StateQueryResult>(baseByIdQuery);
                return Ok(result.States);
            }, memberParameters: new object[] { loggedInPerson });
        }
    }
}