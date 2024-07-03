using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace commen
{
    public class Result<T> 
    {
        public int code {  get; set; }
        public string? message {  get; set; }
        public T? data {  get; set; }
        public static Result<T> Success()
        {
            var result  = new Result<T>();
            result.code = 1;
            return result;
        }
        public static Result<T> Success(T value)
        {
            var result = new Result<T>();
            result.code = 1;
            result.data = value;
            return result;
        }
        public static Result<T> Error(string message)
        {
            var result = new Result<T>();   
            result.message = message;
            result.code = 0;
            return result;
        }
    }
}
