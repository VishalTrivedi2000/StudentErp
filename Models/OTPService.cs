using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;

namespace AMNEVH.Models
{
    public class OTP
    {
        public string onetimepass { get; internal set; }
    }
    public class OtpService
    {
        private static Random random = new Random();
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OtpService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GenerateOtp(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public void StoreOtp(string otp)
        {
            var context = _httpContextAccessor.HttpContext;
            context.Session.SetString("Otp", "123456");
        }
        public void SendOtp(string email, string otp)
        {
            var fromAddress = new MailAddress("tvishal4122000@gmail.com.com", "Resident Welfare Association");
            var toAddress = new MailAddress(email);
            const string fromPassword = "Vishal@7380668808";
            const string subject = "Your OTP Code";
            string body = $"Your OTP code is {otp}";

            var smtp = new SmtpClient
            {
                Host = "smtp.example.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public bool VerifyOtp(string otp)
        {
            var context = _httpContextAccessor.HttpContext;
            var storedOtp = context.Session.GetString("Otp");
            var expiryTime = context.Session.GetString("OtpExpiry");
            if (expiryTime != null)
            {
                DateTime otpExpiry = DateTime.Parse(expiryTime, null, System.Globalization.DateTimeStyles.RoundtripKind);
                if (storedOtp != null && DateTime.Now <= otpExpiry)
                {
                    return storedOtp == otp;
                }
            }
            else
            {
                // Handle the case where the session value is not found
            }
            return false;
        }

    }

}