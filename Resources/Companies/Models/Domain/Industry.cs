using System;
using System.Collections.Generic;
using System.Text;

namespace Resources.Core.Companies.Models.Domain
{
    public class Industry
    {
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
