using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiExceptions
    {
        public ApiExceptions(int statusCodee, string message = "nic tu nie ma", string details = "to jest posciel z mojej dupy")
        {
            StatusCodee = statusCodee;
            Message = message;
            Details = details;
        }

        public int StatusCodee {get; set;}
        public string Message {get; set;}
        public string Details {get; set;}
    }
}