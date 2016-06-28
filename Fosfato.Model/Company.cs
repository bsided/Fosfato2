using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fosfato.Model
{
    [Table("COMPANY")]
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CountryId { get; set; }

        public string CurrencyId { get; set; }

    }

}
