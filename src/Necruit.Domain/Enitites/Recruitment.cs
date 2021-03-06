﻿using System.Collections.Generic;

namespace Necruit.Domain.Entities
{
    public class Recruitment : Entity
    {
        public Recruitment() : base()
        {
        }

        public Talent Talent { get; set; }
        public Job Job { get; set; }
        public RecruitmentStage Stage { get; set; }
        public ICollection<Interview> Interviews { get; set; }
    }
}