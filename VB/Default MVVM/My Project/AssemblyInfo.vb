﻿' Developer Express Code Central Example:
' How to show images in a column filter drop-down window
' 
' You can determine your custom column filter drop-down window via the
' GridColumn.CustomColumnFilterPopupTemplate property
' (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_CustomColumnFilterPopupTemplatetopic.htm).
' In this case, the GridColumn.FilterPopupMode property
' (ms-help://DevExpress.NETv11.2/DevExpress.Wpf/DevExpressXpfGridColumnBase_FilterPopupModetopic.htm)
' should be set to Custom. Simply place ListBoxEdit within DataTemplate and
' override its ItemTemplate property, so it is possible to show an image along
' with a text for every item.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3941


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("Default MVVM")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("")>
<Assembly: AssemblyProduct("Default MVVM")>
<Assembly: AssemblyCopyright("Copyright ©  2012")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

'In order to begin building localizable applications, set 
'<UICulture>CultureYouAreCodingWith</UICulture> in your .csproj file
'inside a <PropertyGroup>.  For example, if you are using US english
'in your source files, set the <UICulture> to en-US.  Then uncomment
'the NeutralResourceLanguage attribute below.  Update the "en-US" in
'the line below to match the UICulture setting in the project file.

'[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.Satellite)]


	'(used if a resource is not found in the page, 
	' or application resource dictionaries)
	'(used if a resource is not found in the page, 
	' app, or any theme specific resource dictionaries)
<Assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)>


' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Build and Revision Numbers 
' by using the '*' as shown below:
' [assembly: AssemblyVersion("1.0.*")]
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
