using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolIca.DataBases.EntityFramework.Bases
{
    public interface IEntityAlertBase
    {
        public bool Alert { get; set; }
        [Column("date_alert", TypeName = "DateTime2")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastAlert { get; set; }
        public int NbAlert { get; set; }
    }
}
