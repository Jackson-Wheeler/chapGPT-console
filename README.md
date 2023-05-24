# ChatGPT Console Application
.NET core C# application that allows the user to interact with ChatGPT. Utilizes OpenAI API.

Simply type any prompt/question you desire and ChatGPT will answer you, directly in the console!
Then, when you are done, simply enter "quit". 

Note, in one session your chat history is remembered, so you can give ChatGPT follow up prompts!

# NOTE
A file named "App.config" must be added in the console_app directory with the following content & your api_key:
```
<?xml version="1.0" encoding="utf-8" ?>  
<configuration>  
    <startup>   
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.5" />  
    </startup>  
  <appSettings>
    <add key="apiKey" value="YOUR API KEY HERE" />
  </appSettings>  
</configuration>
```

As you can see from the above, you will need to get an API key from OpenAI

# To Run
You can run the above code in Visual Studio as long as the proper packages are installed
