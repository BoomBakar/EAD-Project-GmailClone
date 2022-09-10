﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace WebApplication4.Models
{
    public partial class User
    {
        public User()
        {
            MessageReceiverEmailNavigations = new HashSet<Message>();
            MessageSenderEmailNavigations = new HashSet<Message>();
            ThreadEmailNavigations = new HashSet<Thread>();
            ThreadReceiverEmailNavigations = new HashSet<Thread>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Cannot leave this field empty")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Cannot leave this field empty")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
       @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
       @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please Enter a valid Email")]
        public string Email { get; set; }
        //model validation for password and  regular expression helps to create a strong password
        [Required(ErrorMessage = "Cannot leave this field empty")]
        [RegularExpression(@"(?=^.{8,}$)(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "Password must contain atleast one uppercase,one lower and one digit")]
        public string Password { get; set; }
        public bool isActive { get; set; }

        public virtual ICollection<Message> MessageReceiverEmailNavigations { get; set; }
        public virtual ICollection<Message> MessageSenderEmailNavigations { get; set; }
        public virtual ICollection<Thread> ThreadEmailNavigations { get; set; }
        public virtual ICollection<Thread> ThreadReceiverEmailNavigations { get; set; }
    }
}
