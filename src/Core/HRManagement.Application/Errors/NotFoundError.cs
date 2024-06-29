using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRManagement.Application.Errors
{
    public class NotFoundError : Exception
    {

        public string _message;

        public NotFoundError(string message) : base(message) {

            this._message = message;
            
        }
        
    }
}