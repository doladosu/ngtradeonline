using AutoMapper;
using NgTradeOnline.Core;
using NgTradeOnline.Data.Core.Query;
using NgTradeOnline.Data.Core.QueryResult.Contest;
using NgTradeOnline.Data.QueryService;
using NgTradeOnline.Models.Output;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.Core.QueryHandler.Contest
{
    public class ContestQueryHandler : IQueryHandler<BaseByIdQuery, ContestQueryResult>
    {
        private readonly IContestQueryRepository _contestRepository;

        public ContestQueryHandler(IContestQueryRepository contestRepository)
        {
            _contestRepository = contestRepository;
        }

        public async Task<ContestQueryResult> Retrieve(BaseByIdQuery query)
        {
            var allData = await _contestRepository.GetAllContests();
            if (!string.IsNullOrEmpty(query.UserId))
            {
                //Get data from Contest entry table and map to Contests record
            }
            var result = new ContestQueryResult
            {
                Contests = Mapper.Map<IEnumerable<Contests>>(allData),
                TotalRecords = allData.Count()
            };
            return result;
        }
    }
}