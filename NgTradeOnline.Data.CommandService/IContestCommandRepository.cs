using NgTradeOnline.Core;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.CommandService
{
    public interface IContestCommandRepository : IRepository
    {
        Task EnterContestTask();
    }
}