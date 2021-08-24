using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryUpdate<TModel, Tid>
        where TModel : IModelBase
    {
        public TModel Update(Tid id, TModel model);
    }
    public interface IRepositoryUpdate<TModel, TForm, Tid>
        where TModel : IModelBase
        where TForm : IFormBase
    {
        public TModel Update(Tid id, TForm form);
    }
}