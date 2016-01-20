using System.Collections.Generic;

namespace NgTradeOnline.Models.Input
{
    public class ContestEntry
    {
        public int Id { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}