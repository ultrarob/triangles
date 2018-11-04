using System;
using System.Reflection;

// Disable all XML Comment warnings in this file //
#pragma warning disable 1591

namespace Triangles.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}