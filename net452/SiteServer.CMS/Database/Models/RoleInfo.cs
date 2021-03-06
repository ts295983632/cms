using Datory;

namespace SiteServer.CMS.Database.Models
{
    [Table("siteserver_Role")]
    public class RoleInfo : Entity
    {
        [TableColumn]
        public string RoleName { get; set; }

        [TableColumn]
        public string CreatorUserName { get; set; }

        [TableColumn]
        public string Description { get; set; }
    }
}
