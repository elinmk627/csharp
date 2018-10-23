using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp4 {
    class Program {
        static void Main(string[] args) {
            try {
                // Credentials
                var credentials = new NetworkCredential("elinmk627@gmail.com", "roddl22@");

                // Mail message
                var mail = new MailMessage() {
                    From = new MailAddress("elinmk627@gmail.com"),  // 보내는사람 메일주소
                    Subject = "Test email.",        // 제목
                    Body = "Test email body"    // 내용
                };

                mail.To.Add(new MailAddress("mikyung22e@naver.com"));           // 받는메일주소
                
                // Smtp client
                var client = new SmtpClient() {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",    // 구글메일 서버주소(고정)
                    EnableSsl = true,
                    Credentials = credentials
                };
                               
                // Send it...         
                client.Send(mail);
            } 
            catch(Exception ex) {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();
        }
    }
}
