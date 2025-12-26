using System;
using System.Net;
using System.Net.Mail;

namespace EmailVerification
{
    class Program
    {
        static void Main(string[] args)
        {
            string userEmail = "saifulislamoni06@gmail.com";

            // Send verification email
            string sentCode = EmailVerification.SendVerificationEmail(userEmail);

            if (sentCode != null)
            {
                Console.WriteLine("Verification code sent to your email.");

                // Simulate user entering the code
                Console.Write("Enter the verification code: ");
                string userEnteredCode = Console.ReadLine();

                // Verify the code
                if (EmailVerification.VerifyCode(userEnteredCode, sentCode))
                {
                    Console.WriteLine("Email verified successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid verification code.");
                }
            }
            else
            {
                Console.WriteLine("Failed to send verification email.");
            }

            Console.ReadKey();
        }
    }

    public class EmailVerification
    {
        private static string GenerateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        public static string SendVerificationEmail(string toEmail)
        {
            string verificationCode = GenerateVerificationCode();

            try
            {
                // Configure SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("mail.earthcove@gmail.com", "satd bmwm pwzt mwra"), // Use App Password here
                    EnableSsl = true,
                };

                // Create email message
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("mail.earthcove@gmail.com"),
                    Subject = "Email Verification Code",
                    Body = $"Your verification code is: {verificationCode}",
                    IsBodyHtml = false,
                };
                mail.To.Add(toEmail);

                // Send email
                smtpClient.Send(mail);

                Console.WriteLine("Verification email sent successfully.");
                return verificationCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return null;
            }
        }

        public static bool VerifyCode(string userEnteredCode, string sentCode)
        {
            return userEnteredCode == sentCode;
        }
    }
}