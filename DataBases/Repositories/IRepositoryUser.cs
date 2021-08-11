using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.Forms;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryUser<TModel, TForm>
        where TModel : IModel
        where TForm : IForm
    {
        public TModel Check(TForm form);
    }
}
