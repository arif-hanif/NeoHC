using System;
using NeoHC.Projects;

namespace NeoHC.Explorations
{
    public class Exploration
    {
        public Exploration()
        {
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public Project Projects { get; set; }
        public string Data { get; set; }
        public string Settings { get; set; }
        public string ImagesInfo { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedLastBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
