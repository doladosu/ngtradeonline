﻿using NgTradeOnline.Models.Output;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NgTradeOnline.Data.QueryService.Impl
{
    public class ListQueryRepository : BaseRepository, IListQueryRepository
    {
        public Task<IEnumerable<State>> GetAllStates()
        {
            throw new NotImplementedException();
            //var allStates = await Db.States.ToListAsync();
            //return Mapper.Map<IEnumerable<State>>(allStates);
        }
    }
}