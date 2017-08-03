﻿namespace Protacon.NetCore.WebApi.Util.ModelValidation
{
    public class ApiError
    {
        public string Code { get; }
        public string Message { get; }

        public ApiError(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
