/*
 * Contains class for interacting with ChatGPT API
 */

using System;
using System.Configuration;
using OpenAI_API;
using OpenAI_API.Chat;

namespace console_app;

public class ChatGPT
{
    private const string API_KEY_NAME = "apiKey";
    private string? api_key;
    private OpenAIAPI api;
    private Conversation chat;

    public ChatGPT()
    {
        // Reads api_key from App.config file
        api_key = ConfigurationManager.AppSettings.Get(API_KEY_NAME);
        api = new OpenAIAPI(new APIAuthentication(api_key));
        chat = api.Chat.CreateConversation();
    }

    internal async Task askQuestion(string prompt)
    {
        chat.AppendUserInput(prompt);
        string response = await chat.GetResponseFromChatbotAsync();
        Console.Write("Response: ");
        Console.WriteLine(response);
    }


    internal async Task doSampleChat() {
        /// give instruction as System
        chat.AppendSystemMessage("You are a teacher who helps children understand if things are animals or not.  If the user tells you an animal, you say \"yes\".  If the user tells you something that is not an animal, you say \"no\".  You only ever respond with \"yes\" or \"no\".  You do not say anything else.");

        // give a few examples as user and assistant
        chat.AppendUserInput("Is this an animal? Cat");
        chat.AppendExampleChatbotOutput("Yes");
        chat.AppendUserInput("Is this an animal? House");
        chat.AppendExampleChatbotOutput("No");

        // now let's ask it a question'
        chat.AppendUserInput("Is this an animal? Dog");
        // and get the response
        var response = await chat.GetResponseFromChatbotAsync();
        Console.WriteLine(response); // "Yes"

        // and continue the conversation by asking another
        chat.AppendUserInput("Is this an animal? Chair");
        // and get another response
        response = await chat.GetResponseFromChatbotAsync();
        Console.WriteLine(response); // "No"

        // the entire chat history is available in chat.Messages
        foreach (ChatMessage msg in chat.Messages)
        {
            Console.WriteLine($"{msg.Role}: {msg.Content}");
        }

        //return true;

    }
    
}

