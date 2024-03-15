using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseClasses
{
    public class Account
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id { get; set; }
        [Required] public string login { get; set; }
        [Required] public string password { get; set; }
    }
}
