using System;

namespace Xilium.CefGlue.Common;

[AttributeUsage(AttributeTargets.Method)]
public class JavascriptMemberNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
