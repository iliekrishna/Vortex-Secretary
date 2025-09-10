using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretary.Models
{
    public class CategoriaComFaqs
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Faq> Faqs { get; set; } = new List<Faq>();
    }
}
