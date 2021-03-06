﻿using System.Collections.Generic;

namespace Necruit.Domain.Entities
{
    public class RecruitmentStage : Entity
    {
        public RecruitmentStage() : base()
        {
        }

        public string Name { get; set; }
        public int Order { get; set; }
        public ICollection<Recruitment> Recruitments { get; set; }
    }
}