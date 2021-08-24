using System;
using System.Collections.Generic;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositorySearch<TModel, Tid>
        where TModel : IModelBase
    {
        public IEnumerable<TModel> Search(Filtre filtre);
        public IEnumerable<TModel> Search(IEnumerable<Filtre> filtres);
    }
}