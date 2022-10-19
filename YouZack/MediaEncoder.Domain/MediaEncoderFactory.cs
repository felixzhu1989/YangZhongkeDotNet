using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaEncoder.Domain
{
    public class MediaEncoderFactory
    {
        private readonly IEnumerable<IMediaEncoder> _encoders;
        public MediaEncoderFactory(IEnumerable<IMediaEncoder> encoders)
        {
            _encoders = encoders;
        }

        public IMediaEncoder? Create(string outputFormat)
        {
            foreach (var encoder in _encoders)
            {
                if (encoder.Accept(outputFormat)) return encoder;
            }
            return null;
        }
    }
}
