namespace TCM.Web.API.Core.Domain
{
    public class ClientContext
    {
        public ClientContext()
        {
            //this.Roles = new List<string>();
            this.IsAutheticated = false;
        }
        public Context Context { get; set; }
        public string Token { get; set; }

        //public List<string> Roles { get; set; }
        public bool IsAutheticated { get; set; }
    }
}
