# ChatGPT Console Application
.NET core C# application that allows the user to interact with ChatGPT. Utilizes OpenAI API.

Simply type any prompt/question you desire and ChatGPT will answer you, directly in the console!
Then, when you are done, simply enter "quit". 

Note, in one session your chat history is remembered, so you can give ChatGPT follow up prompts!

# To Run
Navigate into "toRun/" and run the executable that works on your machine

# To Run in Debug mode in VS Code - API Key Setup Needed
1. Get an OpenAI API key
2. Add API key to your environmental variables with the name "OPENAI_API_KEY". See this article for instructions on how: https://help.openai.com/en/articles/5112595-best-practices-for-api-key-safety#h_a1ab3ba7b2
3. If you have Windows it now should work
4. If have MacOS (or possibly other). In order for Visual Studio to recognize your environment variable, VS must be run from the terminal (rather than the UI). See this article for detailed instructions: https://placona.co.uk/osx-pro-tip-for-environment-variables/

