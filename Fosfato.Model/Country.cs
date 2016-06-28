using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fosfato.Model
{
    [Table("COUNTRY")]
    public class Country
    {
        // 3 chars
        [Key]
        [MaxLength(3)]
        public string CountryId { get; set; }

        public string Description { get; set; }
    }

}
