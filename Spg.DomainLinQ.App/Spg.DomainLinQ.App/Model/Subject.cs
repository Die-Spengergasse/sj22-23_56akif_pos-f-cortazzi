﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {

        // TODO: Implementation
        public string Description { get; set; } = string.Empty;

        public Subject(string description)
        {
            Description = description;
        }
    }
}
