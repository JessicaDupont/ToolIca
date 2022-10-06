using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolIca.DataBases.EntityFramework.Bases
{
    public interface IEntityActiveBase
    {
        public bool Active { get; set; }
        [Column("date_active", TypeName = "DateTime2")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastActive { get; set; }
    }
}
