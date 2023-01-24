using Company.Domain.EntityBaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Выберите услугу")]
        [Display(Name ="Название услуги")]
        public override string Title { get; set; }

        [Display(Name ="Краткое описание услуги")]
        public override string SubDescription { get; set; }

        [Display(Name ="Описание услуги")]
        public override string Description { get; set; }
    }
}
