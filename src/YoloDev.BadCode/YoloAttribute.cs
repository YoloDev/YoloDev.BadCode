namespace System
{
    /// <summary>
    /// Marker for very fancy amazing great but terribly hacked code.
    /// </summary>
    [Obsolete("This code is awesome, yet you should feel bad")]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class YOLOAttribute : Attribute
    { }
}
