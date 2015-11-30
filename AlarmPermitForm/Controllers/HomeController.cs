using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlarmPermitForm.Entities;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace AlarmPermitForm.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ApplicationPermit m_Permit = new ApplicationPermit();

            return View("Index", m_Permit);
        }

        [HttpPost]
        public ActionResult Index(ApplicationPermit m_Permit)
        {
            if(m_Permit.ContactPreference == "Email" && (m_Permit.EmailAddress == null || m_Permit.EmailAddress.Length <= 0))
            {
                ModelState.AddModelError("EmailAddress", "An email address is required if you select Email as your contact preference.");
            }
            else
            {
                ModelState["EmailAddress"].Errors.Clear();
            }
            if(m_Permit.PermitType == "Business" && (m_Permit.CompanyName == null || m_Permit.CompanyName.Length <= 0))
            {
                ModelState.AddModelError("CompanyName", "If Business Permit Type is selected a company name is required");
            }

            if(!ModelState.IsValid)
            {
                return View("Index", m_Permit);
            }
            else
            {
                string emailBody = "";
                emailBody += "<table><tr><td>Field:</td><td>Value:</td></tr>";

                foreach (string key in Request.Form.Keys)
                {
                    string m_key = Regex.Replace(key, "([a-z])([A-Z])", "$1 $2");
                    emailBody += "<tr><td><b>" + m_key + "</b></td><td>" + Request.Form[key] + "</td></tr>";
                }

                emailBody += "<tr><td>Submission Date</td><td>" + DateTime.Now + "</td></tr>";
                emailBody += "</table>";

                MailMessage mail = new MailMessage("noreply@encinitasca.gov", "jwigginton@encinitasca.gov", "Alarm Permit Submission", emailBody);
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("192.168.1.80");
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = false;
                client.Send(mail);

                return View("Success");
            }
        }
    }
}