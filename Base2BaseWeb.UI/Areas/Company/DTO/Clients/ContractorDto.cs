﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO
{
    public class ContractorDto
    {
        public int Id { get; set; }
        [Display(Name ="Исполнитель")]
        public string Name { get; set; }
    }
}
