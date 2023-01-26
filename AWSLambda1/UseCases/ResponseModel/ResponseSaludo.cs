using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda1.UseCases.ResponseModel
{
    public class ResponseSaludo
    {
        public ResponseSaludo()
        {
        }

        public ResponseSaludo(string errorMessage, int errorCode)
        {
            ErrorMessage = errorMessage;
            ErrorCode = errorCode;
        }

        public string ErrorMessage { get; set; }
        public int ErrorCode { get; set; }
    }
}
