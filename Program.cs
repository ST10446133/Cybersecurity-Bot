using System;
using System.IO;
using NAudio.Wave;  // Import NAudio for audio playback
using System.Threading;

class CybersecurityChatbot
{
    static void Main()//main method
    {
        Console.Title = "Cybersecurity Awareness Bot";
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Support special characters

        PlayAudio("welcome.wav"); // Play the welcome audio using NAudio

        DisplayAsciiArt(); // Show ASCII art logo

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\nWhat is your name? ");
        string userName = Console.ReadLine();
        Console.ResetColor();

        Console.Clear();
        Console.WriteLine("\n===============================================");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" Welcome, {userName}! I'm here to help you stay safe online.");
        Console.ResetColor();
        Console.WriteLine("===============================================\n");

        RunChatbot(userName);
    }

    // Plays the Audio Greeting using NAudio
    static void PlayAudio(string fileName)
    {
        try
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName); // Get the correct path for the audio file
            if (File.Exists(filePath))
            {
                // Use NAudio to play the audio file
                using (var audioFileReader = new AudioFileReader(filePath))
                using (var waveOut = new WaveOutEvent())
                {
                    waveOut.Init(audioFileReader);  // Initialize playback with audio file
                    waveOut.Play();  // Start playing the audio

                    // Wait until playback finishes
                    while (waveOut.PlaybackState == PlaybackState.Playing)
                    {
                        // Sleep briefly while audio is playing
                        Thread.Sleep(100);
                    }
                }
            }
            else
            {
                Console.WriteLine("Audio file not found. Skipping sound...");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }

    // Displaying ASCII Art Logo
    static void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
  ██████╗  █████╗ ██████╗  
  ██╔══██╗██╔══██╗██╔══██╗ 
  ██║    ║███████║██║████║ 
  ██║  ██║██╔══██║██║══██║ 
  ██████╔╝██║  ██║██████╔╝ 
  ╚═════╝ ╚═╝  ╚═╝╚═════╝  
  C.A.B - Cybersecurity Awareness Bot
");
        Console.ResetColor();
    }

    // Add chatbot logic here (if needed)
    static void RunChatbot(string userName)
    {
        // Chatbot conversation logic can go here
        Console.WriteLine("Let's talk about cybersecurity!");
    }
}
