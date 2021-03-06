﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQMFramework.OA.DataModel.Entites
{
    public class PageGroup : EntityBase
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public List<Page> Pages { get; set; }
    }
}
