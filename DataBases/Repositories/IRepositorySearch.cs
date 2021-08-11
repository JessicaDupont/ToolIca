﻿using System;
using System.Collections.Generic;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositorySearch<TModel, Tid>
        where TModel : IModel
    {
        public IEnumerable<TModel> Search(string champ, bool valeur);
        public IEnumerable<TModel> Search(string champ, int valeur);
        public IEnumerable<TModel> Search(string champ, string valeur);
        public IEnumerable<TModel> Search(string champ, DateTime valeur);
        public IEnumerable<TModel> Search(string champ, TimeSpan valeur);
        public IEnumerable<TModel> Search(IDictionary<string, object> filtres);
    }
}