namespace System
{
    /// <summary>
    /// Marker for bad code.
    /// </summary>
    [Obsolete("This code is bad, and you should feel bad")]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class ಠ_ಠAttribute : Attribute
    { }
    
    [Obsolete("What the actual")]
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public sealed class ¬_¬Attribute : Attribute
    { }
}
