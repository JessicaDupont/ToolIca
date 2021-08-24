using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryCreate<TModel, Tid>
        where TModel : IModelBase
    {
        public TModel Create(TModel model);
    }
    public interface IRepositoryCreate<TModel, TForm, Tid>
        where TModel : IModelBase
        where TForm : IFormBase
    {
        public TModel Create(TForm form);
    }
}