
# Title: Reference Package Sample

**Abstract:** Provides the minimum requirements that a package needs to work
as an extension.[ View this sample online](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

* Technologies: Visual Studio 2015 SDK
* Topics: Visual Studio Shell, VSX
* Last Updated: 05/18/2015

** Description**

This sample demonstrates how to add an entry into the Visual Studio Help
dialog. This is the bare minimum requirement for a functional Visual Studio
Package.



**Requirements**

[ Visual Studio 2015 ](http://www.microsoft.com/visualstudio/en-us/try/default.mspx#download)

[ Visual Studio 2015 SDK ](https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs.aspx)



**Build the sample**

  * Download the zip file associated with the sample 
  * Unzip the sample to your machine 
  * Double click on the .sln file to launch the solution 



**Run the sample**

  1. To run the sample, hit **F5** or choose the **Debug &gt; Start Debugging** menu command. A new experimental instance of Visual Studio will launch. 
  2. Once loaded, navigate to **Help &gt; About Microsoft Visual Studio**. 
  3. There is a new entry on the list titled _C# Package Reference Sample_. 



**Project Files**

* **AssemblyInfo.cs**

This file contains assembly custom attributes.

* **BasicPackage.cs**

This file contains the Package implementation. Adds a new entry in the
Help&gt;About dialog.



**Functional Tests**

  * Verify the sample builds in all configurations
  * Verify that the sample was registered. The About box should list the product as installed
  * Verify that the example can be uninstalled from **Tools &gt; Extensions and Updates**



**Related topics**

  * [ Editor Documentation ](https://msdn.microsoft.com/en-us/library/dd885242(v=vs.140).aspx)
  * [ Menu Documentation ](https://msdn.microsoft.com/en-us/library/bb165937(v=vs.140).aspx)
  * [ Visual Studio SDK Documentation ](https://msdn.microsoft.com/en-us/library/bb166441(v=vs.140).aspx)



