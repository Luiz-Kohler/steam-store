﻿using Shared.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.SteamStore.IRepositories.IBaseRepository
{
    public interface ISearchByNameRepository <T>
    {
        Task<DataResponse<T>> GetObjectByName(string name);
    }
}
