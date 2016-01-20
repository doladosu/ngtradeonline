using NgTradeOnline.Core;
using NgTradeOnline.Models.Db;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService
{
    public interface IContestQueryRepository : IRepository
    {
        Task<IEnumerable<Contest>> GetAllContests();
        Task<Contest> GetContestById(int id);
    }
}