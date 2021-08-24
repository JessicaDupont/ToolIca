using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryUser<TModel, TForm>
        where TModel : IModelBase
        where TForm : IFormBase
    {
        public TModel Check(TForm form);
    }
}
