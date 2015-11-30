using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AlarmPermitForm.Entities
{
    public class ApplicationPermit
    {
        private string permitType;
        private string companyName;
        private string firstName;
        private string middleName;
        private string lastName;
        private string streetAddress;
        private string city;
        private string state;
        private string zipCode;
        private string emailAddress;
        private string businessPhone;
        private string homePhone;
        private string mobilePhone;
        private string contactPreference;
        private string mailingAddress;
        private string mailingCity;
        private string mailingState;
        private string mailingZipCode;
        private string mailingCounty;
        private string monitoringCompanyName;
        private string monitoringCompanyAddress;
        private string monitoringCompanyCity;
        private string monitoringCompanyState;
        private string monitoringCompanyZip;
        private string monitoringCompanyCounty;
        private string monitoringCompanyEmail;
        private string monitoringCompanyBusinessPhone;
        private string monitoringCompanyMobilePhone;


        public string PermitType
        {
            get
            {
                return permitType;
            }
            set
            {
                permitType = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }

        [Required(ErrorMessage = "Please enter a valid First Name")]
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        [Required(ErrorMessage = "Please enter a valid Last Name")]
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        [Required(ErrorMessage = "Please enter a valid Street Address")]
        public string StreetAddress
        {
            get
            {
                return streetAddress;
            }
            set
            {
                streetAddress = value;
            }
        }

        [Required(ErrorMessage = "Please enter a valid City")]
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        [Required(ErrorMessage = "Please enter a valid State")]
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        [Required(ErrorMessage = "Please enter a Zip Code")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please Enter a valid Zip Code")]
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        [Required(ErrorMessage = "Please enter an Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a valid Email Address")]
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }
            set
            {
                emailAddress = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid Business phone number")]
        public string BusinessPhone
        {
            get
            {
                return businessPhone;
            }
            set
            {
                businessPhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid Home phone number")]
        public string HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid Mobile phone number")]
        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }
            set
            {
                mobilePhone = value;
            }
        }

        [Required(ErrorMessage = "A valid selection for Contact Preference is required")]
        public string ContactPreference
        {
            get
            {
                return contactPreference;
            }
            set
            {
                contactPreference = value;
            }
        }

        public string MailingAddress
        {
            get
            {
                return mailingAddress;
            }
            set
            {
                mailingAddress = value;
            }
        }

        public string MailingCity
        {
            get
            {
                return mailingCity;
            }
            set
            {
                mailingCity = value;
            }
        }

        public string MailingState
        {
            get
            {
                return mailingState;
            }
            set
            {
                mailingState = value;
            }
        }

        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please Enter a valid Mailing Address Zip Code")]
        public string MailingZipCode
        {
            get
            {
                return mailingZipCode;
            }
            set
            {
                mailingZipCode = value;
            }
        }

        public string MailingCounty
        {
            get
            {
                return mailingCounty;
            }
            set
            {
                mailingCounty = value;
            }
        }

        [Required(ErrorMessage = "Please enter a Monitoring Company Name")]
        public string MonitoringCompanyName
        {
            get
            {
                return monitoringCompanyName;
            }
            set
            {
                monitoringCompanyName = value;
            }
        }

        [Required(ErrorMessage = "Please enter a Monitoring Company Address")]
        public string MonitoringCompanyAddress
        {
            get
            {
                return monitoringCompanyAddress;
            }
            set
            {
                monitoringCompanyAddress = value;
            }
        }


        [Required(ErrorMessage = "Please enter a Monitoring Company City")]
        public string MonitoringCompanyCity
        {
            get
            {
                return monitoringCompanyCity;
            }
            set
            {
                monitoringCompanyCity = value;
            }
        }

        [Required(ErrorMessage = "Please enter a Monitoring Company State")]
        public string MonitoringCompanyState
        {
            get
            {
                return monitoringCompanyState;
            }
            set
            {
                monitoringCompanyState = value;
            }
        }

        [Required(ErrorMessage = "Please enter a Monitoring Company Zip Code")]
        [RegularExpression(@"^(?!00000)[0-9]{5,5}$", ErrorMessage = "Please Enter a valid Monitoring Company Zip Code")]
        public string MonitoringCompanyZip
        {
            get
            {
                return monitoringCompanyZip;
            }
            set
            {
                monitoringCompanyZip = value;
            }
        }

        public string MonitoringCompanyCounty
        {
            get
            {
                return monitoringCompanyCounty;
            }
            set
            {
                monitoringCompanyCounty = value;
            }
        }

        [EmailAddress(ErrorMessage = "Please enter a valid Monitoring Company Email Address")]
        public string MonitoringCompanyEmail
        {
            get
            {
                return monitoringCompanyEmail;
            }
            set
            {
                monitoringCompanyEmail = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid Monitoring Company Business phone number")]
        public string MonitoringCompanyBusinessPhone
        {
            get
            {
                return monitoringCompanyBusinessPhone;
            }
            set
            {
                monitoringCompanyBusinessPhone = value;
            }
        }

        [Phone(ErrorMessage = "Please enter a valid Monitoring Company Mobile phone number")]
        public string MonitoringCompanyMobilePhone
        {
            get
            {
                return monitoringCompanyMobilePhone;
            }
            set
            {
                monitoringCompanyMobilePhone = value;
            }
        }
    }
}
