using System;
using System.Collections.Generic;
using System.Text;

namespace Resources.Core.Companies.Models.View
{
    public class SubsidiaryViewModel
    {
        public string Name { get; set; }
        public string Website { get; set; }
        public string Description { get; set; }
        public CompanyViewModel ParentCompany { get; set; }
        public IndustryViewModel Industry { get; set; }
    }
}
