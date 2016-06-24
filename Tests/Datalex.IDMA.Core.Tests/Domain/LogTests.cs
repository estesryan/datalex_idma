using Datalex.IDMA.Core.Domain.Logging;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Datalex.IDMA.Core.Tests
{
    [TestClass]
    public class LogTests
    {
        [TestMethod]
        public void Can_create()
        {
            var log = new Log()
            {
                CreatedOnUtc = new DateTime(2016, 01, 01),
                FullMessage = "FullMessage 1",
                Id = 1,
                IpAddress = "IpAddress 1",
                LogLevelId = (int)LogLevel.Debug,
                PageUrl = "PageUrl 1",
                ReferrerUrl = "ReferrerUrl 1",
                ShortMessage = "ShortMessage 1"
            };

            Assert.AreEqual(new DateTime(2016, 01, 01), log.CreatedOnUtc);
            Assert.AreEqual("FullMessage 1", log.FullMessage);
            Assert.AreEqual(1, log.Id);
            Assert.AreEqual("IpAddress 1", log.IpAddress);
            Assert.AreEqual(LogLevel.Debug, log.LogLevel);
            Assert.AreEqual((int)LogLevel.Debug, log.LogLevelId);
            Assert.AreEqual("PageUrl 1", log.PageUrl);
            Assert.AreEqual("ReferrerUrl 1", log.ReferrerUrl);
            Assert.AreEqual("ShortMessage 1", log.ShortMessage);
        }
    }
}
