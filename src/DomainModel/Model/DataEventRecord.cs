﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace DomainModel.Model
{
    using System.ComponentModel.DataAnnotations;

    public class DataEventRecord
    {
        [Key]
        public long DataEventRecordId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        [ForeignKey("SourceInfoId")]
        public SourceInfo SourceInfo { get; set; }
        public long SourceInfoId { get; set; }
    }
}
