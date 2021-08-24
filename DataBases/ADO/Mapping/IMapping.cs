using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using ToolIca.DataBases.ADO.Bases;
using ToolIca.Models.Bases;

namespace ToolIca.DataBases.ADO.Mapping
{
    public interface IMapping<TData, TModel>
    where TData : DbDataReader
    where TModel : IModelBase
    {
        public Command Mapping(TModel model, CRUD type);
        public TModel Mapping(TData data);
    }
    public interface IMapping<TData, TModel, TForm>
        where TData : DbDataReader
        where TModel : IModelBase
        where TForm : IFormBase
    {
        public Command Mapping(TForm form, CRUD type);
        public TModel Mapping(TData data);
    }
}
