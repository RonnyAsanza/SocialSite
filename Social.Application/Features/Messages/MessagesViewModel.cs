﻿using Social.Domain.Enums;
using System;

namespace Social.Application.Features.Messages
{
    public class MessagesViewModel
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public bool Status { get; set; }
        public string Content { get; set; }
        public string Time { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool FromOther { get; set; }
    }
}
