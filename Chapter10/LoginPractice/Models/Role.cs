using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPractice.Models
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid RoleId { get; set; }

        [Required]
        public RoleName RoleName { get; set; }  

        public virtual ICollection<User> Users { get; set; }
    }

    public enum RoleName
    {
        Admin = 1,
        Guest = 2,
        Vip = 3,
        Regular = 4
    }

}
