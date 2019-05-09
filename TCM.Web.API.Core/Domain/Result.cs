using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace TCM.Web.API.Core.Domain
{
    public interface IResult<T>
    {
        bool Success { get; set; }

        IList<Error> ErrorList { get; set; }

        T Data { get; set; }

        string GetErrorMessages();

        IResult<TN> CopyCallDetails<TN>();

        List<Error> GetTcmErrorDTOs(); // TODO: Remove this code when the new managers are implemented everywhere!
    }
    public class Result<T> : IResult<T>
    {
        public bool Success { get; set; }


        public T Data { get; set; }

        public IList<Error> ErrorList { get; set; }

        public Result()
        {
            ErrorList = new List<Error>();
        }

        public IResult<TN> CopyCallDetails<TN>()
        {
            IResult<TN> result = new Result<TN>
            {
                ErrorList = ErrorList,
                Success = Success
            };
            return result;
        }

        public string GetErrorMessages()
        {
            const string separator = "σ"; // Alt+963
            return string.Join(separator, (from e in ErrorList select e.ErrorMessage).ToArray());
        }

        public List<Error> GetTcmErrorDTOs()
        {
            return ErrorList.Select(error => new Error
            {
                ErrorCode = error.ErrorCode,
                ErrorMessage = error.ErrorMessage,
                ExtErrorPosReference = error.ExtErrorPosReference
            }).ToList();
        }
    }

    public class Error
    {
        [DataMember()]
        public string ErrorMessage { get; set; }
        [DataMember()]
        public string ErrorCode { get; set; }
        [DataMember()]
        public string ExtErrorPosReference { get; set; }
        [DataMember()]
        public string SystemErrorMessage { get; set; }
    }
}
