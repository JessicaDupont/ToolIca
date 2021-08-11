using System;
using System.Collections.Generic;
using System.Text;
using ToolIca.DataBases.EntityFramework.Bases;
using ToolIca.Forms;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.Mapping
{
    //pour ADO

    //pour Entity Framework
    public interface IMapping<TEntity, TModel>
        where TEntity : IEntity
        where TModel : IModel
    {
        public TEntity Mapping(TModel model);
        public TModel Mapping(TEntity entity);
    }
    public interface IMapping<TEntity, TModel, TForm>
        where TEntity : IEntity
        where TModel : IModel
        where TForm : IForm
    {
        public TEntity Mapping(TForm form);
        //public TEntity Mapping(TModel model);
        public TModel Mapping(TEntity entity);
    }
}
