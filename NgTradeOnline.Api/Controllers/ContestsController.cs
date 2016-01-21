using NgTradeOnline.Api.Hubs;
using NgTradeOnline.Api.Setup.Core;
using NgTradeOnline.Core;
using NgTradeOnline.Data.Core.Command.Contest;
using NgTradeOnline.Data.Core.Query;
using NgTradeOnline.Data.Core.QueryResult.Contest;
using NgTradeOnline.Models.Input;
using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.OData;

namespace NgTradeOnline.Api.Controllers
{
    /// <summary>
    /// Contests API class
    /// </summary>
    public class ContestsController : BaseApiControllerHub<ContestsHub>
    {
        /// <summary>
        /// Contests API class declaration
        /// </summary>
        /// <param name="commandDispatcher"></param>
        /// <param name="queryDispatcher"></param>
        public ContestsController(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher) : base(commandDispatcher, queryDispatcher)
        {
        }

        /// <summary>
        /// Gets all live contests.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [EnableQuery]
        [ResponseType(typeof(IEnumerable<Contests>))]
        public async Task<IHttpActionResult> GetAllContestsTask(ILoggedInPerson loggedInPerson)
        {
            return await TryAsync(async () =>
            {
                var baseByIdQuery = new BaseByIdQuery();
                var result = await QueryDispatcher.Dispatch<BaseByIdQuery, ContestQueryResult>(baseByIdQuery);
                return new CustomOkResult<IEnumerable<Contests>>(result.Contests, this)
                {
                    XInlineCount = result.TotalRecords.ToString()
                };
            }, memberParameters: new object[] { loggedInPerson });
        }

        /// <summary>
        /// Gets contest by Id.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("{id:int}")]
        [ResponseType(typeof(Contests))]
        public async Task<IHttpActionResult> GetContestByIdTask(ILoggedInPerson loggedInPerson, int id)
        {
            return await TryAsync(async () =>
            {
                var baseByIdQuery = new BaseByIdQuery { Id = id };
                var result = await QueryDispatcher.Dispatch<BaseByIdQuery, ContestByIdQueryResult>(baseByIdQuery);
                return Ok(result.Contest);
            }, memberParameters: new object[] { loggedInPerson });
        }


        /// <summary>
        /// Gets all contests entered by user
        /// </summary>
        /// <param name="loggedInPerson"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("User")]
        [EnableQuery]
        [ResponseType(typeof(IEnumerable<Contests>))]
        public async Task<IHttpActionResult> GetContestsForUserTask(ILoggedInPerson loggedInPerson)
        {
            return await TryAsync(async () =>
            {
                var baseByIdQuery = new BaseByIdQuery { UserId = loggedInPerson.Id };
                var result = await QueryDispatcher.Dispatch<BaseByIdQuery, ContestQueryResult>(baseByIdQuery);
                return new CustomOkResult<IEnumerable<Contests>>(result.Contests, this)
                {
                    XInlineCount = result.TotalRecords.ToString()
                };
            }, memberParameters: new object[] { loggedInPerson });
        }

        /// <summary>
        /// Enter user to a live contest
        /// </summary>
        /// <param name="loggedInPerson"></param>
        /// <param name="contestEntry"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        [ResponseType(typeof(CommandResult))]
        public async Task<IHttpActionResult> EnterContestTask(ILoggedInPerson loggedInPerson, [FromBody]ContestEntry contestEntry)
        {
            return await TryAsync(async () =>
            {
                var command = new EnterContestCommand { ContestEntry = contestEntry, UserId = loggedInPerson.Id };
                var result = await CommandDispatcher.Dispatch(command);
                Hub.Clients.All.enteredContest(contestEntry);
                return Ok(result);
            }, memberParameters: new object[] { loggedInPerson, contestEntry });
        }

        /// <summary>
        /// Update user contest entry
        /// </summary>
        /// <param name="loggedInPerson"></param>
        /// <param name="contestEntry"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("")]
        [ResponseType(typeof(CommandResult))]
        public async Task<IHttpActionResult> UpdateContestTask(ILoggedInPerson loggedInPerson, [FromBody]ContestEntry contestEntry)
        {
            return await TryAsync(async () =>
            {
                var command = new EnterContestCommand { ContestEntry = contestEntry, UserId = loggedInPerson.Id };
                var result = await CommandDispatcher.Dispatch(command);
                return Ok(result);
            }, memberParameters: new object[] { loggedInPerson, contestEntry });
        }
    }
}
