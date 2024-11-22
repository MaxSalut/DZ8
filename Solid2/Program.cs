using System;
//У цьому коді порушено принцип єдиного обов’язку. Клас EmailSender виконує дві задачі: Відправляє email таЛогує інформацію про відправлення через консоль.
//Щоб виправити це, необхідно винести логування в окремий клас. Таким чином, клас EmailSender відповідатиме лише за відправлення email.
class Email
{
    public string Theme { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}


class Logger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

class EmailSender
{
    private readonly Logger _logger;

    public EmailSender(Logger logger)
    {
        _logger = logger;
    }

    public void Send(Email email)
    {
        // ... sending ...
        _logger.Log($"Email from '{email.From}' to '{email.To}' was sent");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        Logger logger = new Logger();
        EmailSender es = new EmailSender(logger);

        es.Send(e1);
        es.Send(e2);
        es.Send(e3);
        es.Send(e4);
        es.Send(e5);
        es.Send(e6);

        Console.ReadKey();
    }
}
