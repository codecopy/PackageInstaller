namespace PackageInstaller
{
    using System;
    
    /// <summary>
    /// Helper class that exposes all GUIDs used across VS Package.
    /// </summary>
    internal sealed partial class PackageGuids
    {
        public const string guidVSPackageString = "f91d6656-dccf-400f-843d-1ff49242cf4b";
        public const string guidVSPackageCmdSetString = "c0f38f12-aa45-4a08-9305-30003a67fecc";
        public const string guidVenusCmdIdString = "c7547851-4e3a-4e5b-9173-fa6e9c8bd82c";
        public static Guid guidVSPackage = new Guid(guidVSPackageString);
        public static Guid guidVSPackageCmdSet = new Guid(guidVSPackageCmdSetString);
        public static Guid guidVenusCmdId = new Guid(guidVenusCmdIdString);
    }
    /// <summary>
    /// Helper class that encapsulates all CommandIDs uses across VS Package.
    /// </summary>
    internal sealed partial class PackageIds
    {
        public const int InstallPackageId = 0x0100;
        public const int IDG_VENUS_CTX_REFERENCE = 0x001B;
        public const int IDG_CTX_REFERENCE = 0x0102;
    }
}
