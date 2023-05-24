# ChatGPT Console Application
.NET core C# application that allows the user to interact with chatGPT. Utilizes OpenAI API.

# Note to run!
You must add a file name "App.config" in the console_app directory with the following:
```
<?xml version="1.0" encoding="utf-8" ?>  
<configuration>  
    <startup>   
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />  
    </startup>  
  <appSettings>
    <add key="apiKey" value="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" />
  </appSettings>  
</configuration>
```
