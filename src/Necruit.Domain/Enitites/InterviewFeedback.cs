﻿using Necruit.Domain.Enums;

namespace Necruit.Domain.Entities
{
    public class InterviewFeedback : Entity
    {
        public InterviewFeedback() : base()
        {
        }

        public int UserId { get; set; }

        public User User { get; set; }
        public string Comment { get; set; }
        public InterviewRating Rating { get; set; }
        public Interview Interview { get; set; }
    }
}