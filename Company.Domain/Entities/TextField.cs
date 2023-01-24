using Company.Domain.EntityBaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; } = "";

        [Display(Name = "Заголовок")]
        public override string Title { get; set; } = "FAQ";

        [Display(Name = "Описание")]
        public override string Description { get; set; } = "Заполняется админом";
    }
}
