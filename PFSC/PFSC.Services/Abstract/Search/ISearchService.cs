using PFSC.Entities.Entites;
using PFSC.Models.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace PFSC.Services.Abstract.Search
{
    public interface ISearchService
    {
        List<CriteriaModel> GetTechnologies();
        List<CriteriaModel> GetProduction();
        List<FactoryShortModel> SearchFactoriesShort(string searchQuery);
        List<SearchFactoryModel> SearchFactories();
    }
}
