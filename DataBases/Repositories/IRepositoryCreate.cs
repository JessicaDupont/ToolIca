using ToolIca.Forms;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryCreate<TModel, Tid>
        where TModel : IModel
    {
        public TModel Create(TModel model);
    }
    public interface IRepositoryCreate<TModel, TForm, Tid>
        where TModel : IModel
        where TForm : IForm
    {
        public TModel Create(TForm form);
    }
}