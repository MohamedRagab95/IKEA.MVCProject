using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkDev.IKEA.DAL.Models
{
    public class ModelBase
    {

        public int Id { get; set; }
        public bool IsDeleted { get; set; }

        #region Creation

        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        #endregion

        #region Modification

        public DateTime ModifiedOn { get; set; }
        public int ModifiedBy { get; set; } 

        #endregion




    }
}
