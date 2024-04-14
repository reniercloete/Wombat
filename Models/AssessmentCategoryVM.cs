﻿using System.ComponentModel.DataAnnotations;
using Wombat.Data;

namespace Wombat.Models
{
    public class AssessmentCategoryVM
    {
        public AssessmentCategoryVM()
        {
            Name = "";
            OptionCriteria = new List<OptionCriterionVM>();
        }
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")] 
        public string Name { get; set; }

        public List<OptionCriterionVM> OptionCriteria { get; set; }

        public List<OptionSetVM>? OptionSets { get; set; }
    }
}
