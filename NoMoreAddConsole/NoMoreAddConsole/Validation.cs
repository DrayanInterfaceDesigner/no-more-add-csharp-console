using System;
using System.Collections.Generic;
using System.Text;

namespace NoMoreAddConsole
{
    class Validation
    {
        public Response ValidateDDD(string DDD)
        {
            Response response = new Response(true);
            if (DDD.Length > 3)
            {
                response.SetError("Your DDD needs to be smaller than 3 numbers.");
                response.SetPermission(false);
            }
            if(DDD.Length <= 1)
            {
                response.SetError("Your DDD needs at least 2 numbers.");
                response.SetPermission(false);
            }

            return response;
        }

        public Response ValidateDDI(string DDI)
        {
            Response response = new Response(true);
            if(!DDI.Contains("55"))
            {
                response.SetError("This app only accepts the +55 DDI");
                response.SetPermission(false);
            }
            return response;
        }

        public Response ValidateNumber(string NUM)
        {
            Response response = new Response(true);

            if (NUM.Length > 9)
            {
                response.SetError("Your number is too large, it won't fit!");
                response.SetPermission(false);
            }
            if(NUM.Length < 8)
            {
                response.SetError("Why your number is so small? Please, type a larger one.");
                response.SetPermission(false);
            }
            return response;
        }
    }

    class Response
    {
        private string _error;
        private bool _canPass;

        public Response(bool perm, string err = null)
        {
            this._canPass = perm;
            this._error = err;
        }

        public string GetError()
        {
            return _error;
        }
        public void SetError(string err)
        {
            _error = err;
        }

        public bool GetPermission()
        {
            return _canPass;
        }

        public void SetPermission(bool perm)
        {
            _canPass = perm;
        }

    }
}
