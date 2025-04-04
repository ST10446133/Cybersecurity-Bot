# Cybersecurity Awareness Bot (C.A.B)

The Cybersecurity Awareness Bot (C.A.B) is a chatbot application built in C# that educates users on cybersecurity best practices. The bot provides helpful responses to user queries about topics like password safety, phishing, and safe browsing. It also features an interactive ASCII art logo, a personalized welcome message, and plays a greeting audio upon startup.

## Features

- **Interactive Chatbot**: Answering questions about cybersecurity best practices.
- **ASCII Art**: Displaying a custom ASCII art logo for a unique experience.
- **Audio Greeting**: Plays a welcome audio when the program starts (requires an audio file).
- **Personalized Interaction**: Greets users and asks for their name before starting the conversation.
- **Safe Browsing Tips**: Provides advice about safe browsing, password management, and phishing protection.
- **Extensible**: Easy to add new cybersecurity topics or modify existing responses.

## Requirements

- **.NET Framework**: This project is built with C# and targets .NET Core / .NET 5+.
- **NAudio Library**: Used for audio playback (`NAudio` NuGet package).
- **Audio File**: A `welcome.wav` audio file should be present in the `C:\Users\your-username\source\repos\assignment1\assignment1\` directory, or update the file path accordingly.

## Setup Instructions

### Prerequisites

- Install [Visual Studio](https://visualstudio.microsoft.com/) or another IDE that supports C# development.
- Install the `NAudio` NuGet package for audio functionality:

    ```bash
    Install-Package NAudio
    ```

### Steps to Run the Application

1. **Clone this repository** to your local machine:
   
    ```bash
    git clone https://github.com/your-username/CybersecurityChatbot.git
    ```

2. **Open the project** in Visual Studio or your preferred C# IDE.

3. **Install the necessary NuGet packages**:
    - `NAudio` for audio functionality.

4. **Add the audio file**:
    - Ensure that the `welcome.wav` file is placed at the correct location or update the `filePath` in `PlayAudio()` method.

5. **Build and run the project**:
    - Press `Ctrl + F5` or use your IDE's build and run command.

6. **Interact with the chatbot**:
    - The bot will greet you and prompt you for your name.
    - Ask about topics related to cybersecurity and get advice on how to stay safe online.

## How It Works

- **User Interaction**: The user is prompted for their name at the start, and the chatbot responds with various cybersecurity topics and safety advice.
- **Audio Playback**: A welcome greeting is played when the program starts (ensure the correct path to the audio file).
- **ASCII Art Logo**: A custom ASCII logo is shown to enhance the user experience.
- **Topics Covered**:
  - **Password Safety**
  - **Phishing Prevention**
  - **Safe Browsing Tips**
  - **General Cybersecurity Knowledge**

## Example Conversation

```plaintext
Cybersecurity Awareness Bot

██████╗  █████╗ ██████╗  
██╔══██╗██╔══██╗██╔══██╗ 
██║    ║███████║██║████║ 
██║  ██║██╔══██║██║══██║ 
██████╔╝██║  ██║██████╔╝ 
╚═════╝ ╚═╝  ╚═╝╚═════╝  
C.A.B - Cybersecurity Awareness Bot

What is your name? 
[User enters "Alice"]

Welcome, Alice!

Alice, how can I help you today?

[User asks] "What can I ask you about?"
You can ask me about:
- Password Safety
- Phishing
- Safe Browsing
- General Cybersecurity Tips
