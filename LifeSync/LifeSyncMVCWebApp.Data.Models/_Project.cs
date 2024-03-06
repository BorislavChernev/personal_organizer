﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeSyncMVCWebApp.Data.Models
{
    public class _Project
    {
        [Key]
        public int ProjectId { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime Deadline { get; set; }
        public string Status { get; set; } = null!; // Consider enum for Status
        public DateTime DateCreated { get; set; }

        // Navigation property
        public _ApplicationUser User { get; set; }
    }
}
