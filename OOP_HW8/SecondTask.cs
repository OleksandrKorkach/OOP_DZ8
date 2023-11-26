namespace OOP_HW8;

public class SecondTask
{
    
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }

    
    class EmailLogger
    {
        public void Log(Email email)
        {
            Console.WriteLine("Email from '" + email.From + "' to '" + email.To + "' was sent");
        }
    }

    class EmailSender
    {
        private readonly EmailLogger logger;

        public EmailSender(EmailLogger logger)
        {
            this.logger = logger;
        }

        public void Send(Email email)
        {
            logger.Log(email);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };

            EmailLogger logger = new EmailLogger();
            EmailSender es = new EmailSender(logger);

            es.Send(e1);

            Console.ReadKey();
        }
    }
}

