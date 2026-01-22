using System;
using System.IO;
using CSCore.Codecs.AIFF;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSCore.Test.Streams
{
    [TestClass]
    public class AiffDecoderTests : GenericSourceTests
    {
        protected override IWaveSource GetSource()
        {
            return new AiffReader(new MemoryStream("aiff_50s_sine"));
        }
    }
}
