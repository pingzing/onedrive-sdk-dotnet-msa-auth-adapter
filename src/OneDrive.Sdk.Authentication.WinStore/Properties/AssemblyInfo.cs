﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("OneDrive.Sdk.Authentication.WinStore")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OneDrive.Sdk.Authentication.WinStore")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: ComVisible(false)]

#if DEBUG
[assembly: InternalsVisibleTo("Microsoft.OneDrive.Sdk.Authentication.UWP")]
[assembly: InternalsVisibleTo("Test.OneDrive.Sdk.Authentication.UWP")]
#else
[assembly: InternalsVisibleTo("Microsoft.OneDrive.Sdk.Authentication.UWP")]
[assembly: InternalsVisibleTo("Test.OneDrive.Sdk.Authentication.UWP")]
#endif