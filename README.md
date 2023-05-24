# ChatGPT Console Application
.NET core C# application that allows the user to interact with ChatGPT. Utilizes OpenAI API.

Simply type any prompt/question you desire and ChatGPT will answer you, directly in the console!
Then, when you are done, simply enter "quit". 

Note, in one session your chat history is remembered, so you can give ChatGPT follow up prompts!

# API Key Setup Needed
1. Get an OpenAI API key
2. Add API key to your environmental variables with the name "OPENAI_API_KEY". See this article for instructions on how: https://help.openai.com/en/articles/5112595-best-practices-for-api-key-safety#h_a1ab3ba7b2
3. Now you should be able to run the program as described below

# To Run
-  MacOS: Navigate into "toRun/" and run "console_app" executable
- Other OSs: other steps may be needed. See this article in the "Running the applications on Windows" section: https://stackify.com/cross-platform-net-core-apps/


# Debug mode in Visual Studio
If you want to run the program in Debug mode in Visual Studio and you have MacOS (possibly other OSs as well) note the following:

In order for Visual Studio to recognize your environment variable, VS must be run from the terminal (rather than the UI). See this article for detailed instructions: https://placona.co.uk/osx-pro-tip-for-environment-variables/
