﻿using System;

namespace Necruit.Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool IsActive { get; set; }
    }
}