using System;
using System.Net;
using System.Net.Mail;
class Program{
  public static void Main(string[] args){
    string sender = "ashwinkumar0850@gmail.com";
    string senderPass = "tmlr cofs gohl lapn";
    string recieve = "aswinkumar0850@gmail.com";

    MailMessage mail = new MailMessage(sender,recieve);
    mail.Subject = "Subject";
    mail.Body = "Hi this is ashwin";

    SmtpClient smtpClient= new SmtpClient("smtp.gmail.com");
    smtpClient.Port = 587;
    smtpClient.Credentials = new NetworkCredential(sender,senderPass);
    smtpClient.EnableSsl = true;

    try{
      smtpClient.Send(mail);
      Console.WriteLine("Sent Successfully");
    }
    catch (Exception e){
      Console.WriteLine($"Error: {e.Message}");
    }
  }
}