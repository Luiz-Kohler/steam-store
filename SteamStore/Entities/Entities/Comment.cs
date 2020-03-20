﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Entities
{
    public class Comment
    {
        public string Message { get; private set; }
        public DateTime DateTimeComment { get; private set; }
        public int WritterID { get; private set; }
        public virtual User Writter { get; private set; }
        public int ForUserID { get; private set; }
        public virtual User ForUser { get; private set; }
    }
}
