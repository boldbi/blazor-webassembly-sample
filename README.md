# Bold BI Embedded Sample in Blazor WebAssembly

This project was created using ASP.NET Core 7.0. This application aims to demonstrate how to render the dashboard available on your Bold BI server.

## Dashboard view

![Dashboard View](https://github.com/boldbi/aspnet-core-sample/assets/91586758/4af68f49-ffc0-400a-a323-55a3f3600a1d)

 ## Requirements/Prerequisites

 * [.NET Core 7.0](https://dotnet.microsoft.com/download/dotnet-core)

 #### Help link

 * https://help.boldbi.com/embedded-bi/faq/where-can-i-find-the-product-version/

 #### Supported browsers
  
  * Google Chrome, Microsoft Edge, Mozilla Firefox, and Safari.

 ## Configuration

  * Please ensure you have enabled embed authentication on the `embed settings` page. If it is not currently enabled, please refer to the following image or detailed [instructions](https://help.boldbi.com/site-administration/embed-settings/#get-embed-secret-code) to enable it.

    ![Embed Settings](https://github.com/boldbi/aspnet-core-sample/assets/91586758/b3a81978-9eb4-42b2-92bb-d1e2735ab007)

  * To download the `embedConfig.json` file, please follow this [link](https://help.boldbi.com/site-administration/embed-settings/#get-embed-configuration-file) for reference. Additionally, you can refer to the following image for visual guidance.
  
    ![Embed Settings Download](https://github.com/boldbi/aspnet-core-sample/assets/91586758/d27d4cfc-6a3e-4c34-975e-f5f22dea6172)
    ![EmbedConfig Properties](https://github.com/boldbi/aspnet-core-sample/assets/91586758/d6ce925a-0d4c-45d2-817e-24d6d59e0d63)

  * Copy the downloaded `embedConfig.json` file and paste it into the designated [location](https://github.com/boldbi/blazor-webassembly-sample/tree/master/BlazorWebAssembly/Server) within the application. Please ensure you have placed it in the application, as shown in the following image.

    ![EmbedConfig image](https://github.com/boldbi/aspnet-core-sample/assets/91586758/f6fb1b22-5478-41aa-9d25-7afac86ace08)

## How to run sample using command prompt

  1. Open the command line interface and navigate to the specified file [location](https://github.com/boldbi/blazor-webassembly-sample/tree/master/BlazorWebAssembly/Server) where the project is located.
  
  2. Finally, run the application using the command `dotnet watch run`. After executing the command, the application will automatically launch in the default browser. You can access it at the specified port number (e.g., http://localhost:5154/).

 ## Developer IDE

  * Visual studio code(https://code.visualstudio.com/download)

  ### How to run sample using visual studio code
 
  1. Open the [Blazor WebAssembly sample](https://github.com/boldbi/blazor-webassembly-sample/tree/master/BlazorWebAssembly/Server) in Visual Studio Code. 
   
  2. To run the application, use the command `dotnet watch run` in the terminal. After executing the command, the application will automatically launch in the default browser. You can access it at the specified port number (e.g., http://localhost:5001/).

     ![dashboard image](https://github.com/boldbi/aspnet-core-sample/assets/91586758/4af68f49-ffc0-400a-a323-55a3f3600a1d)

Please refer to the [help documentation](https://help.boldbi.com/embedding-options/embedding-sdk/samples/blazor-web-assembly/#how-to-run-blazor-server-sample) to learn how to run the sample.

## Important notes

It is recommended not to store passwords and sensitive information in configuration files for security reasons in a real-world application. Instead, you should consider using a secure application, such as Key Vault, to safeguard your credentials.

## Online demos

Look at the Bold BI Embedding sample to live demo [here](https://samples.boldbi.com/embed).


## Documentation

A complete Bold BI Embedding documentation can be found on [Bold BI Embedding Help](https://help.boldbi.com/embedded-bi/javascript-based/).
