using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolIca.DataBases.EntityFramework.Bases
{
    public interface IEntityDatesBase
    {
        [Column("date_insert", TypeName = "DateTime2")]
        public DateTime DateInsert { get; set; }
        [Column("date_update", TypeName = "DateTime2")]
        public DateTime DateUpdate { get; set; }
    }
}
