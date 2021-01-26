using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SampleFunctionApp.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var mockLogger = new Mock<ILogger>();
            await Function1.Run(new DefaultHttpRequest(new DefaultHttpContext()), mockLogger.Object);
        }
    }
}
