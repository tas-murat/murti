using System;

namespace WebUI.Models
{
   
    public class JsonReturnViewModel<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public string DataJSON { get; set; }
    }
   
}
