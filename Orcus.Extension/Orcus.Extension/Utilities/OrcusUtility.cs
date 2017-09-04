public static class OrcusUtility
{
    public static string TryGetDomainUserName()
    {
        var windowsIdentity = System.Security.Principal.WindowsIdentity.GetCurrent();
        return windowsIdentity.Name;
    }
}
