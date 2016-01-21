using NgTradeOnline.Core;
using NgTradeOnline.Data.Core.Query;
using NgTradeOnline.Data.Core.QueryResult.List;
using NgTradeOnline.Data.QueryService;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.Core.QueryHandler.List
{
    public class StateQueryHandler : IQueryHandler<BaseByIdQuery, StateQueryResult>
    {
        private readonly IListQueryRepository _listQueryRepository;

        public StateQueryHandler(IListQueryRepository listQueryRepository)
        {
            _listQueryRepository = listQueryRepository;
        }

        public async Task<StateQueryResult> Retrieve(BaseByIdQuery query)
        {
            var states = await _listQueryRepository.GetAllStates();

            return new StateQueryResult
            {
                States = states
            };
        }
    }
}