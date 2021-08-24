using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Repositories
{
    public interface IRepository<TModel, Tid> :
        IRepositoryCreate<TModel, Tid>,
        IRepositoryRead<TModel, Tid>,
        IRepositoryUpdate<TModel, Tid>,
        IRepositoryDelete<TModel, Tid>,
        IRepositorySearch<TModel, Tid>
        where TModel : IModelBase
    {
    }
    public interface IRepository<TModel, TForm, Tid> :
        IRepositoryCreate<TModel, TForm, Tid>,
        IRepositoryRead<TModel, Tid>,
        IRepositoryUpdate<TModel, TForm, Tid>,
        IRepositoryDelete<TModel, Tid>,
        IRepositorySearch<TModel, Tid>
        where TModel : IModelBase
        where TForm : IFormBase
    {
    }
}
