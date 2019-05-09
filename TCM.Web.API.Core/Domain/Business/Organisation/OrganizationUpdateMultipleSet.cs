using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.Web.Business.Domain
{
    public partial class OrganizationUpdateMultipleSet
    {

        private System.Collections.Generic.List<OrganizationMultiple> OrganizationMultipleListField;


        public List<OrganizationMultiple> OrganizationMultipleList
        {
            get
            {
                return this.OrganizationMultipleListField;
            }
            set
            {
                if ((object.ReferenceEquals(this.OrganizationMultipleListField, value) != true))
                {
                    this.OrganizationMultipleListField = value;

                }
            }
        }
    }
}
