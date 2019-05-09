using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCM.Web.Business.Domain.Organisation;


namespace TCM.Web.Business.Domain
{

   


    public partial class OrganizationRepository
    {





        public TCM.Web.Business.ProxyXFMOrganization.CriteriaOptions Options { get; set; }

        public string CriteriaType { get; set; }


        public System.Nullable<long> TotalRecords { get; set; }


        public List<OrganizationInfo> OrganizationList { get; set; }


        public List<TCM.Web.Business.ProxyXFMOrganization.GeneralCriterion> SearchCriteria { get; set; }


        public List<TCM.Web.Business.ProxyXFMOrganization.SimpleCriterion> ListCriteria { get; set; }


        public List<TCM.Web.Business.ProxyXFMOrganization.OrganizationIdentity> IdentityCriteria { get; set; }




    }
}
