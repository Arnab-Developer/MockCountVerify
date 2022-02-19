using MockCountVerify.ConsoleApp;
using Moq;
using Xunit;

namespace MockCountVerify.ConsoleAppTest;

public class WorkerTest
{
    [Fact]
    public void VerifyDoWorkWorksProperly()
    {
        Mock<ILogger> loggerMock = new();
        Worker worker = new(loggerMock.Object);

        loggerMock
            .Setup(logger => logger.Log(It.IsAny<string>()));

        worker.DoWork();

        //loggerMock.Verify(v => v.Log(It.IsAny<string>()), Times.Exactly(5)); // Fail

        loggerMock.Verify(v => v.Log(It.IsAny<string>()), Times.Exactly(10)); // Pass
    }
}
