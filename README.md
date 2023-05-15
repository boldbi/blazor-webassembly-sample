# BoldBI Embedded Sample in Blazor WebAssembly Sample

This project was generated using Blazor Server CLI version 6.0 or a later version that is installed on your system before it was compiled. This Bold BI Blazor WebAssembly sample contains the Dashboard embedding sample. This sample demonstrates the dashboard rendering with the available dashboard in your Bold BI server.

## Dashboard View

![Dashboard View](https://github.com/boldbi/aspnet-core-sample/assets/91586758/73318269-f8e9-4b49-b597-d82850c60952)

 ## Requirements/Prerequisites

 * [.NET Core 6.0 or later](https://dotnet.microsoft.com/en-us/download/dotnet-core)
 * [Visual Studio Code](https://code.visualstudio.com/download).

 ### Help link

 * https://help.boldbi.com/embedded-bi/faq/where-can-i-find-the-product-version/

 ### Supported browsers
  
  * Google Chrome, Microsoft Edge, Mozilla Firefox.

 ## Configuration

  * Ensure that you have enabled embed authentication on the embed settings [page](https://github.com/boldbi/aspnet-core-sample/assets/91586758/68695d1a-ebd0-4577-a6bb-d37e89e98379). If it is not enabled, enable it. Please refer to the below image.
  ![Embed Settings](https://github.com/boldbi/aspnet-core-sample/assets/91586758/0ac2e737-bd7a-419b-824c-48f1589e78d8)

  * Download the embedConfig.json file by referring to this [link](https://help.boldbi.com/embedded-bi/site-administration/embed-settings/#get-embed-configuration-file). Please refer to the below image.
   ![EmbedConfig Properties](https://github.com/boldbi/aspnet-core-sample/assets/91586758/f2915a54-010b-45c6-b608-3817cb713dc9)

  * Copy the downloaded embedConfig.json file and place it into the following [location](https://github.com/boldbi/blazor-webassembly-sample/tree/master/BlazorWebAssembly) of the application. Please refer to the below image.
  ![EmbedConfig image](https://github.com/boldbi/aspnet-core-sample/assets/91586758/a1316cfb-d18e-4f4b-9dbc-57adf44fbcfb)

  * The following properties are used in `embedConfig.json` file:

    <meta charset="utf-8"/>
    <table>
    <tbody>
        <tr>
            <td align="left">ServerUrl</td>
            <td align="left">Dashboard Server URL (Eg: http://localhost:5000/bi, http://demo.boldbi.com/bi).</td>
        </tr>
        <tr>
            <td align="left">EmbedSecret</td>
            <td align="left">Get your EmbedSecret key from the Embed tab by enabling the `Enable embed authentication` on the Administration page https://help.boldbi.com/embedded-bi/site-administration/embed-settings/.</td>
        </tr>
        <tr>
            <td align="left">SiteIdentifier</td>
            <td align="left">For the Bold BI Enterprise edition, it should be like `site/site1`. For Bold BI Cloud, it should be an empty string.</td>
        </tr>
        <tr>
            <td align="left">Environment</td>
            <td align="left">Your Bold BI application environment. (If it is cloud analytics server, use `BoldBI.Environment.Cloud`; if it is your own server, use `BoldBI.Environment.Enterprise`).</td>
        </tr>
        <tr>
            <td align="left">UserEmail</td>
            <td align="left">UserEmail of the Admin in your Bold BI, which would be used to get the dashboard list.</td>
        </tr>
        <tr>
            <td align="left">DashboardId</td>
            <td align="left">Item id of the dashboard to be embedded in your application.</td>
        </tr>
        <tr>
            <td align="left">ExpirationTime</td>
            <td align="left">Token expiration time. (In the EmbedConfig.json file, the default token expiration time is 10000 seconds).</td>
        </tr>
    </tbody>
    </table>

## How to run sample using command prompt 
    
  1. Open command prompt in this file [location](https://github.com/boldbi/blazor-webassembly-sample/tree/master/BlazorWebAssembly).
  
  2. Run the application using the command `dotnet watch run`.

 ## Developer IDE

  * Visual studio code(https://code.visualstudio.com/download)

 ## How to run sample using visual studio code
 
  1. Open the Blazor Server sample in Visual Studio Code. 
   
  2. Open the terminal in Visual Studio Code, run the application using the command `dotnet watch run`.


Please refer to the [help documentation](https://help.boldbi.com/embedded-bi/javascript-based/samples/v3.3.40-or-later/blazor-with-javascript/#how-to-run-the-blazor-webassembly-sample) to learn how to run the sample.

## Important notes:

It is recommended to not store passwords and sensitive information in configuration files for security reasons, in a real-world application. Instead, you should consider using a secure application, such as Key Vault, to safeguard your credentials.

## Online Demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).


## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedded-bi/javascript-based/).
