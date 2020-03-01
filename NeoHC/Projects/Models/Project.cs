using System;
using System.Collections.Generic;
using NeoHC.Explorations;

namespace NeoHC.Projects
{
    public class Project
    {
        public Project(
            string name,
            string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Exploration> Explorations { get; set; }
    }
}
