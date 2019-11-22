using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities
{
    [Table("orgUser",Schema = "dbo")]
    public class OrgUser
    {
        public int userId { get; set; }

        [MaxLength(50)]
        public string username { get; set; }

        [MaxLength(50)]
        public string password { get; set; }

        public int loginCounter { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
