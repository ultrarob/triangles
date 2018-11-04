using System.Collections.Generic;
using System.Collections.ObjectModel;

// Disable all XML Comment warnings in this file //
#pragma warning disable 1591

namespace Triangles.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}