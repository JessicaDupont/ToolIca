using ToolIca.Forms;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryUpdate<TModel, Tid>
        where TModel : IModel
    {
        public TModel Update(Tid id, TModel model);
    }
    public interface IRepositoryUpdate<TModel, TForm, Tid>
        where TModel : IModel
        where TForm : IForm
    {
        public TModel Update(Tid id, TForm form);
    }
}