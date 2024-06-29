using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Application.Errors
{
    public class BadRequestError : Exception
    {


        public BadRequestError(string message) : base(message) {



        }
        
    }
}