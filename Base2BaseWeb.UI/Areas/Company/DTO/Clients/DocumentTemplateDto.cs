﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class DocumentTemplateDto
    {
        public int? DocumentTemplateId { get; set; }
        [Display(Name="Наименование шаблона")]
        public string Name { get; set; }
    }
}
