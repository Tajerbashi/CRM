﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEE
{
    public class User
    {
        public User()
        {
            Status = true;
            DeleteStatus = false;
            RegDate = DateTime.Now;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Picture { get; set; }

        public bool DeleteStatus { get; set; } = true;
        public bool Status { get; set; } = true;
        public DateTime RegDate { get; set; }

        public List<Activity> Activities { get; set; } = new List<Activity>();
        public List<Reminder> Reminder { get; set; } = new List<Reminder>();
        public List<InVoice> InVoices { get; set; } = new List<InVoice>();
        public UserGroup UserGroup { get; set; }
    }
}
