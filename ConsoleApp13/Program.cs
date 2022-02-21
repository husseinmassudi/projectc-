using System;
using Telegram.Bot;


namespace ConsoleApp13
{
    internal class Program
    {
        static string token = "5063037329:AAEiWgvlSqMeUbf_mrA_fmT5OZeMn_8Cziw";
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
                            string txt = update.Message.Text.ToLowerInvariant();
                           
                            string un = update.Message.From.Username;
                            string f = update.Message.From.FirstName;
                            string l = update.Message.From.LastName;
                            DateTime time= DateTime.UtcNow;
                            DateTime b = DateTime.Now;
                            



                            if (txt.Contains("start"))
                            {
                                bot.SendTextMessageAsync(id,"Hi, welcome  "+un+" \n If need help please\n write or click " + " /help");
                                 
                                Console.WriteLine(id);
                                Console.WriteLine(txt);
                                Console.WriteLine(un);
                                Console.WriteLine(f);
                                Console.WriteLine(l);
                                

                                


                            }
                            else if (txt.Contains("help"))
                            {
                                bot.SendTextMessageAsync(id,un+ " you can take help from\nProgramer " + " /hussein\n " + 
                                    " OR Engineer" + " /mohamed \n"+ "to konw time now  /time ");
                                 
                            Console.WriteLine(txt);

                        }

                            else if (txt.Contains("hussein"))
                            {
                            if (time.Hour > 7 && time.Hour < 19  )
                            {


                                bot.SendTextMessageAsync(id, un+" now clossed ("+b+" )");
                                 bot.SendTextMessageAsync(id, "you can to contact me in 7 AM TO 7 PM");
                                  bot.SendTextMessageAsync(id," you can take help in this time from Engineer /mohamed");
                            }
                            else
                            {
                                string facebook = "www.facebook.com";
                                string twitter = "www.twitter.com";
                                string gmail = "www.gmail.com";
                                bot.SendTextMessageAsync(id, un + " welcome to Programer hussein  \n you can to contact me in this aways " +
                                        "\n" + facebook + "\n" + twitter + "\n" + gmail);
                                
                                Console.WriteLine(txt);
                            }

                        }
                            else if (txt.Contains("mohamed"))
                            {
                            if (time.Hour > 19 && time.Hour < 7)
                            {
                                bot.SendTextMessageAsync(id, un + " now clossed 9" +b+" )");
                                bot.SendTextMessageAsync(id, "you can to contact me in 7 PM TO 7 AM");
                                bot.SendTextMessageAsync(id,"you can take help in this time from Programer /hussein");

                            }
                            else
                            {
                                string facebook = "www.facebook.com";
                                string twitter = "www.twitter.com";
                                string gmail = "www.gmail.com";
                                bot.SendTextMessageAsync(id, un + " welcome to Programer hussein  \n you can to contact me in this aways " +
                                        "\n" + facebook + "\n" + twitter + "\n" + gmail);
                                
                                Console.WriteLine(txt);
                            }

                             }
                             else if (txt.Contains("time"))
                             {
                            float a;
                            if (b.Hour > time.Hour)
                            {
                                bot.SendTextMessageAsync(id, b + " local time " +"+"+ (b.Hour - time.Hour) + " UTC");

                            }
                            else
                            {
                                bot.SendTextMessageAsync(id, b + " local time " + (b.Hour - time.Hour) + " UTC");
                            }
                            


                             }
                            
                            else
                            {
                                bot.SendTextMessageAsync(id,un+ " I can not understand you \nthank you for visiting");
                                 
                           


                            }

                        } 
                    } 
                     

                
            }
             


        }

    }
}
