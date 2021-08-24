using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.DataBases.EntityFramework.Bases;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.EntityFramework.Mapping
{
    public interface IMapping<TEntity, TModel>
        where TEntity : IEntityBase
        where TModel : IModelBase
    {
        public TEntity Mapping(TModel model);
        public TModel Mapping(TEntity entity);
    }
    public interface IMapping<TEntity, TModel, TForm>
        where TEntity : IEntityBase
        where TModel : IModelBase
        where TForm : IFormBase
    {
        public TEntity Mapping(TForm form);
        //public TEntity Mapping(TModel model);
        public TModel Mapping(TEntity entity);
    }
}
