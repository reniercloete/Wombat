﻿/*Copyright (C) 2024 RCL Consulting
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see <http://www.gnu.org/licenses/>
 */

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wombat.Data
{
    public class AssessmentForm : BaseEntity
    {
        public string Name { get; set; }

        public List<OptionCriterion> OptionCriteria { get; set; }

        public AssessmentForm()
        {
            this.OptionCriteria = new List<OptionCriterion>();
            Name = "";
        }

        public ICollection<EPAForm> EPAs { get; set; }

        public bool CanDelete { get; set; } = true;

        public const int kTemplateId = 1;
    }
}
