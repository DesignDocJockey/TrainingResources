using System;
using System.Collections.Generic;
using System.Text;

namespace Resources.Core.Companies.Models.Domain
{
    public class Company
    {
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public string CEO { get; set; }
        public string Website { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public IEnumerable<Industry> Industries { get; set; }
        public IEnumerable<Company> Subsidiaries { get; set; }
    }
}
