﻿using System;
using RabbitMQ.Client;
using System.Text;

class Send
{
    
    public static bool k = true;
        
    public static void Main()
    {
        
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using(var connection = factory.CreateConnection())
        using(var channel = connection.CreateModel())
        {
            channel.QueueDeclare(queue: "hello",
                                 durable: false,
                                 exclusive: false,
                                 autoDelete: false,
                                 arguments: null);
            int messageIndex = 1;
            var index = 100;
            var lenght = 100;
            while(index != 0)
            {
                StringBuilder str_build = new StringBuilder();  
                Random random = new Random();  

                char letter;  

                for (int i = 0; i < lenght; i++)
                {
                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    str_build.Append(letter);  
                }
                var message = str_build.ToString();
                var body = Encoding.UTF8.GetBytes(message + " " + messageIndex); 
            
                channel.BasicPublish(exchange: "",
                                     routingKey: "hello",
                                     basicProperties: null,
                                     body: body);
            
                Console.WriteLine(" [x] Sent {0}", message + " " + messageIndex);
                --index;
                ++messageIndex;
            }
        }

        Console.WriteLine(" Press [enter] to exit.");
        Console.ReadLine();
    }
 
}

