using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoundTheCode.BlazorDotNet6.Wasm.Models
{
    public class Note
    {
        public string Message { get; }

        public DateTimeOffset Created { get; }

        public Note(string message, DateTimeOffset created)
        {
            Message = message;
            Created = created;
        }
    }
}
