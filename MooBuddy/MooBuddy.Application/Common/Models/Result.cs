using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MooBuddy.Application.Common.Models
{
    public class Result<T>
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public T? Data { get; set; }
        public List<string> Errors { get; set; } = new List<string>();

        public static Result<T> Success(T data, string message = "")
        {
            return new Result<T> { IsSuccess = true, Data = data, Message = message };
        }

        public static Result<T> Failure(string message, List<string>? errors = null)
        {
            return new Result<T> { IsSuccess = false, Message = message, Errors = errors ?? new() };
        }
    }
}
