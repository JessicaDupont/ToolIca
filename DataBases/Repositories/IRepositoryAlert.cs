using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryAlert<TModel, Tid>
        where TModel : IAlertBase
    {
        public TModel Alert(Tid id);
        public TModel NoAlert(Tid id);
        public IEnumerable<TModel> GetAlert();
    }
}
