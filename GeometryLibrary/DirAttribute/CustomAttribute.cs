using System;

namespace GeometryLibrary.DirAttribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class CustomAttribute : Attribute

    {
    public string Description { get; set; }

    public CustomAttribute(string description)
    {
        Description = description;
    }
    }
}