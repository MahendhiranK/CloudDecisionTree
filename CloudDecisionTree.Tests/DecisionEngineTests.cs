
using Xunit;
using CloudDecisionTree.API.Models;
using CloudDecisionTree.API.Services;

public class DecisionEngineTests
{
    [Fact]
    public void Test_EventDrivenRealTimeScenario()
    {
        var engine = new DecisionEngine();
        var input = new DecisionInput
        {
            IsEventDriven = true,
            RequiresRealTime = true
        };
        var result = engine.Evaluate(input);

        Assert.Equal("Azure Event Grid or AWS EventBridge", result.RecommendedService);
    }
}
