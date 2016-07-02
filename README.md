<h2>Custom message box control for Windows Embedded Compact</h2>
<hr/>
Developed with Dot Net Compact Framework 3.5 for Windows CE 5,6,7, windows mobile, windows compact app and or other CE version.

<b>Features</b>
<ul>
    <li>Multithreading working</li>
    <li>Time based closing</li>
    <li>Customizable buttons and events</li>
    <li>Customizable control design color, font etc.</li>
    <li>Customizable size (centered, full screen, status bar)</li>
</ul>

<b>Run the Test Project</b>
<ol>
    <li>Start Microsoft Visual Studio 2008 and select File > Open > Project/Solution.</li>
    <li>Starting in the folder where you clone the repository, go to TestProject </li>
    <li>Double-click the Visual Studio 2008 Solution (csproj) file <b>TestProject.csproj</b></li>
   
</ol>

<b>Build the library</b>
<ol>
    <li>Start Microsoft Visual Studio 2008 and select File > Open > Project/Solution.</li>
    <li>Starting in the folder where you clone the repository, go to WinCEUtility </li>
    <li>Double-click the Visual Studio 2008 Solution (csproj) file <b>CompactMessageBoxControl.csproj</b></li>
     <li>Press Ctrl+Shift+B, or select Build > Build Solution.</li>
</ol>

<b>Direct use</b>
<ol>
    <li>Start Microsoft Visual Studio 2008 and create new ce device project</li>
    <li>Open solition explorer windows</li>
    <li>Right click References and Add Reference..</li>
    <li>Download dll. Click here to download https://github.com/mesutpiskin/MessageBoxControl4CE/tree/master/Binaries </li>
    <li>Select CompactMessageBoxControl.dll file and add to project</li>
    <li>That is all</li>
</ol>
<b>Sample</b>
  ```csharp
      UCMessageBox ucMessageBox1;
      ucMessageBox1 = new UCMessageBox(panel1);
      //Just message
      ucMessageBox1.Show("Hello", "This is test message!", MsgButtons.YesNo, DisplayState.FullScreen, 0);
      //use time
      ucMessageBox1.DefaultWidth = 400;
      ucMessageBox1.DefaultHeight = 300;
      ucMessageBox1.Show("Hello", "This is test message!", MsgButtons.OK, DisplayState.Normal, 10);
      ///Look the testproject
      
