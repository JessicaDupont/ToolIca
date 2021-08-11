﻿using System.Collections.Generic;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryRead<TModel, Tid>
        where TModel : IModel
    {
        public TModel Read(Tid id);
        public IEnumerable<TModel> Read();
    }
}