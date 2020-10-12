﻿using Necruit.Application.Mapping;
using Necruit.Domain.Entities;

namespace Necruit.Application.Service.Jobs.Dto
{
    public class JobInfo : MapFrom<Job>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
        public int Quantity { get; set; }
        public UserInfo User { get; set; }
        public int RecruitmentCount { get; set; }
    }
}