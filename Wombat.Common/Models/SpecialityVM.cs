﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wombat.Common.Models
{
    public class SpecialityVM
    {
        public SpecialityVM()
        {
            Name = "";
            SubSpecialities = new List<SubSpecialityVM>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        [DisplayName("Subspecialities")]
        public List<SubSpecialityVM>? SubSpecialities { get; set; }
    }

}
