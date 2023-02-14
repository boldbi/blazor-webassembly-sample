# BoldBI Embedding Blazor WebAssembly Sample

 This Bold BI Blazor WebAssembly sample contains the Dashboard embedding sample. This sample demonstrates the dashboard rendering with the available dashboard in your Bold BI server.

This section guides you in using the Bold BI dashboard in your Blazor WebAssembly sample application.

 * [Requirements to run the demo](#requirements-to-run-the-demo)
 * [Using the Blazor WebAssembly sample](#using-the-blazor-webassembly-sample)
 * [Online Demos](#online-demos)
 * [Documentation](#documentation)

 ## Requirements to run the demo

The samples need the following requirements to run.

 * [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/)
 * [.NET Core 6.0 or later](https://dotnet.microsoft.com/en-us/download/dotnet-core)

 ## Using the Blazor WebAssembly sample
 
 * Open the solution file `BlazorWebAssembly.sln` in Visual studio. 

 * Open the EmbedProperties.cs file under the BlazorWebAssembly.Shared project.

 * Please change the following properties in the `EmbedProperties.cs` file per your Bold BI Server.

<meta charset="utf-8"/>
<table>
  <tbody>
    <tr>
        <td align="left">UserEmail</td>
        <td align="left">UserEmail of the Admin in your Bold BI, which will be used to get the dashboard list.</td>
    </tr>
    <tr>
        <td align="left">EmbedSecret</td>
        <td align="left">Get your EmbedSecret key from the Embed tab by enabling the `Enable embed authentication` on the Administration page https://help.boldbi.com/embedded-bi/site-administration/embed-settings/.</td>
    </tr>
  </tbody>
</table>

* Change the following properties in the script tag of the `index.html` file under the BlazorWebAssembly.client project in the following location, wwwroot/index.html per your Bold BI Server.

<meta charset="utf-8"/>
<table>
  <tbody>
    <tr>
        <td align="left">RootUrl</td>
        <td align="left">Dashboard Server URL (Eg: http://localhost:5000/bi, http://demo.boldbi.com/bi).</td>
    </tr>
    <tr>
        <td align="left">SiteIdentifier</td>
        <td align="left">For the Bold BI Enterprise edition, it should be like `site/site1.` For Bold BI Cloud, it should be an empty string.</td>
    </tr>
    <tr>
        <td align="left">Environment</td>
        <td align="left">Your Bold BI application environment. (If Cloud, you should use `cloud,` if Enterprise, you should use `enterprise`).</td>
    </tr>
    <tr>
        <td align="left">dashboardId</td>
        <td align="left">Provide the dashboard id of the dashboard you want to embed in view or edit mode. Ignore this property to create a new dashboard.</td>
    </tr>
  </tbody>
</table>

Please refer to the [help documentation](https://help.boldbi.com/embedded-bi/javascript-based/samples/v3.3.40-or-later/blazor-with-javascript/#how-to-run-the-blazor-webassembly-sample) to learn how to run the sample.

## Online Demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).


## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedded-bi/javascript-based/).
