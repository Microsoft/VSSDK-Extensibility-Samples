﻿

# Title: Running Document Table (RDT) Event Explorer Sample
**Abstract:** Create an explorer that logs Running Document Table (RDT)
events.[ View this sample online](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

* Technologies: Visual Studio 2015 SDK
* Topics: Visual Studio Shell, VSX
* Last Updated: 05/28/2015

**Description**

This sample demonstrates how to create an explorer that logs Running Document
Table (RDT) events. Selecting an event from the grid displays its properties
in the **Properties** window.

Goals:

  * Provide a tool to explore the RDT that follows recommended design patterns 
  * Log RDT events on a grid 
  * Select RDT event details from the grid to view them in the **Properties** window 
  * Filter logged events from the **Tools &gt; Options** page 
  * Implement a toolbar in the RDT window with control options 
  * Tool window and dialog page share a singleton instance of options via automation 



This sample has a package (_RdtEventExplorerPkg_) and a tool window
(_RDTEventWindowPane_). The tool window hosts a UserControl
(_RdtEventControl_). The options are set by a dialog page
(_RdtEventOptionsDialog_) and filter the RDT events (derived from
GenericEvent).

The explorer window hosts a toolbar and displays all unfiltered RDT events in
a grid. Selecting an event in the grid displays its properties in the
**Properties** window.



**Requirements**

[ Visual Studio 2015 ](http://www.microsoft.com/visualstudio/en-us/try/default.mspx#download)

[ Visual Studio 2015 SDK ](https://www.visualstudio.com/en-us/downloads/visual-studio-2015-downloads-vs.aspx)



**Build the sample**

  * Download the zip file associated with the sample 
  * Unzip the sample to your machine 
  * Double click on the .sln file to launch the solution 



**Run the sample**

  1. Press F5 to launch the visual studio experimental shell.
  2. Launch the **Rdt Event Explorer** tool window: **View &gt; Other Windows &gt; RdtEventExplorer**
  3. Modify properties of the **RDT Event Explorer** tool window: 
    * **Tools &gt; Options &gt; RDT Event Explorer**
    * Set **OptBeforeFirstDocumentLock** to False, and then click **OK**. 
    * Now **OptBeforeFirstDocumentLock** items will no longer appear in the RDT window
  4. Open a new or existing Visual Studio project. The RDT events show up in the RDT Event Explorer grid. 
  5. Press F4 to open the **Properties** window. 
  6. Select an event in the grid. The properties of that event appear in the **Properties** window. 
  7. On the toolbar in the RDT Event Explorer, click **Clear**. Events are cleared from the grid. 



**Related topics**

* [ Toolwindow Documentation ](https://msdn.microsoft.com/en-us/library/bb165390(v=vs.140).aspx)

* [ Editor Documentation ](https://msdn.microsoft.com/en-us/library/dd885242(v=vs.140).aspx)

* [ Visual Studio SDK Documentation ](https://msdn.microsoft.com/en-us/library/bb166441(v=vs.140).aspx)



