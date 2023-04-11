namespace TraversalCoreProje.Areas.Admin.Models
{
    public class RoleAssignViewModel
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        //Bu rol bu kullanıcıda var mı? 
        public bool RoleExist { get; set; }
    }
}
