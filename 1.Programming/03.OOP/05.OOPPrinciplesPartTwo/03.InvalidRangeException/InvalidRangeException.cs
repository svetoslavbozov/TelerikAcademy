using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InvalidRangeException
{
    [Serializable]
    public class InvalidRangeException<T> : Exception
    {
        public T MinValue { get; private set; }
        public T MaxValue { get; private set; }

        public InvalidRangeException() : base() { }
        public InvalidRangeException(string message) : base(message) { }
        public InvalidRangeException(string message, Exception inner) : base(message, inner) { }
 
        protected InvalidRangeException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}
