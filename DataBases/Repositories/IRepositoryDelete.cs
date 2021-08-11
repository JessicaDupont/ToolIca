using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepositoryDelete<TModel, Tid>
        where TModel : IModel
    {
        public TModel Delete(TModel model);
        public TModel Delete(Tid id);
    }
}