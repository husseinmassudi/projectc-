using System;
using Telegram.Bot;


namespace ConsoleApp13
{
    internal class Program
    {
        static string token = "enter your token";
        static TelegramBotClient bot = new TelegramBotClient(token);
        static void Main(string[] args)
        {
            int x = 0;
            while (true)
            {
                 Telegram.Bot.Types.Update[] updates = bot.GetUpdatesAsync(x).Result;
                
                
                    foreach (var update in updates)
                    {
                        x = update.Id + 1;
                         
                    
                        if (update.Message != null)
                        {
                            long id = update.Message.From.Id;
                            string txt = update.Message.Text;
                            string un = update.Message.From.Username;
                            string f = update.Message.From.FirstName;
                            string l = update.Message.From.LastName;
                           

                            if (txt.Contains("start")|| txt.Contains("Start")|| txt.Contains("START"))
                            {
                                bot.SendTextMessageAsync(id,"Hi, welcome  "+un+" \n If need help please\n write or click " + " /help");
                                Console.WriteLine(id);
                                Console.WriteLine(txt);
                                Console.WriteLine(un);
                                Console.WriteLine(f);
                                Console.WriteLine(l);
                                

                                


                            }
                            else if (txt.Contains("help")|| txt.Contains("Help")|| txt.Contains("HELP"))
                            {
                                bot.SendTextMessageAsync(id,un+ " you can take help from\nProgramer " + " /hussein\n " + 
                                    " OR Engineer" + " /mohamed ");
                                Console.WriteLine(txt);

                        }

                            else if (txt.Contains("hussein") || txt.Contains("Hussein")|| txt.Contains("HUSSEIN"))
                            {
                                bot.SendTextMessageAsync(id, un+ " welcome to Programer hussein  \n you can to contact me in this aways " +
                                    "\nwww.facebook.com\nwww.twitter.com\nwww.gmail.com\n " + " Or take help from Engineer" + " /mohamed");
                                Console.WriteLine(txt);

                        }
                            else if (txt.Contains("mohamed")|| txt.Contains("Mohamed")|| txt.Contains("MOHAMED"))
                            {
                                bot.SendTextMessageAsync(id,un+ "  welcome to Engineer mohamed  \n you can to contact me in this aways" +
                                    "\nwww.facebook.com\nwww.twitter.com\nwww.gmail.com\n " + " Or take help from Programer " + " /hussein");
                               Console.WriteLine(txt);

                        }
                            else
                            {
                                bot.SendTextMessageAsync(id,un+ " I can not understand you \nthank you for visiting");
                                 Console.WriteLine(txt);

                            }

                        } 
                    } 
                     

                
            }
             


        }

    }
}
