using System;
using System.Collections.Generic;
using System.Text;
using PFSC.Models.Factory;
using PFSC.Models.Home;

namespace PFSC.Services.Abstract.Factory
{
    public interface IFactoryService
    {
        IEnumerable<TopRatedFactoryInfo> GetTopRated();
        FactoryModel GetFullFactoryInfo(int factoryId);
    }
}
