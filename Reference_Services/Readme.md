﻿

# Title: Reference Services Sample
**Abstract:** Demonstrates how to be a Visual Studio service provider and
consume Visual Studio services.[ View this sample online](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

* Technologies: Visual Studio 2015 SDK
* Topics: Visual Studio Shell, VSX
* Last Updated: 05/21/2015

**Description**

This sample shows how to create and expose services inside Visual Studio. It
creates two services with two different levels of visibility. The service with
global visibility is available for any of Visual Studio's other components.
The service with local visibility is available only from within the package
itself or when the **IServiceProvider** interface implemented by the package
is inside the chain of active providers.

The sample creates two assemblies, one with the definition of the interfaces
used and one with the actual implementation of the packages and services. The
assembly with the implementation, created by the _Reference.Services_ project,
defines two packages. One package exposes the services and a second package
uses them. The services are implemented with two helper classes.

The ServicesPackage class demonstrates how to proffer services. Specifically:

  1. In the class declaration we use the **ProvideServiceAttribute** registration attribute defined in the **Managed Package Framework** to add information about the global service to the registry. 
  2. The constructor adds the proffered service types to the services list provided by the package. At this point we don’t create any instance of the service, we provide a callback function to call the first time a client queries for a specific service. This optimizes performance, we don’t want to construct something that might never be used. 
  3. The callback function used to create a new instance of the services. 



**Requirements**

[ Visual Studio 2015 ](http://www.microsoft.com/visualstudio/en-us/try/default.mspx#download)

[ Visual Studio 2015 SDK ](https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs.aspx)



**Build the sample**

  * Download the zip file associated with the sample 
  * Unzip the sample to your machine 
  * Double click on the .sln file to launch the solution 



**Run the sample**

  1. To run the sample, hit F5 or choose the **Debug &gt; Start Debugging** menu command. A new instance of Visual Studio will launch under the experimental hive. 
  2. Once loaded, open the **Tools** drop menu.
  3. Three new buttons are displayed at the top of the **Tools** menu: _Get C# Global Service_, _Get C# Local Service_, and _Get C# Local using Global Service_



**Related topics**

* [ Menu Documentation ](https://msdn.microsoft.com/en-us/library/bb165937(v=vs.140).aspx)

* [ Visual Studio SDK Documentation ](https://msdn.microsoft.com/en-us/library/bb166441(v=vs.140).aspx)



