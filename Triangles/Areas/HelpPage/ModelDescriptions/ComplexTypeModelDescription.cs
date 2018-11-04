using System.Collections.ObjectModel;

// Disable all XML Comment warnings in this file //
#pragma warning disable 1591

namespace Triangles.Areas.HelpPage.ModelDescriptions
{
    public class ComplexTypeModelDescription : ModelDescription
    {
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        public Collection<ParameterDescription> Properties { get; private set; }
    }
}