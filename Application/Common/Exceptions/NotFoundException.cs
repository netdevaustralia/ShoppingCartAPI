using System.Runtime.Serialization;

namespace Application.Common.Exceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        public NotFoundException(string name, object key) : base($"Entity {name} {key} was not found.")
        { }
    }
}
