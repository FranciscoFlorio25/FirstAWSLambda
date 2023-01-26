using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda1.UseCases.RequestModel
{
    public class RequestSaludo
    {
        public RequestSaludo()
        {
        }

        public RequestSaludo(string userName, string email, string phone)
        {
            UserName = userName;
            Email = email;
            Phone = phone;
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

    }
}
