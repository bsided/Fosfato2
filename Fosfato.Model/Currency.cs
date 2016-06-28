using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fosfato.Model
{
    [Table("CURRENCY")]
    public class Currency
    {
        // 3 chars
        [Key]
        [MaxLength(3)] // ISO 4217 http://www.currencysymbols.in/
        public string CurrencyId { get; set; }
        public string Name { get; set; }

        public Country CountryId { get; set; }

        [MaxLength(5)] // ISO 4217 http://www.currencysymbols.in/
        public string Symbol { get; set; }
    }
}

