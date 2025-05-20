
using CloudDecisionTree.API.Models;

namespace CloudDecisionTree.API.Services
{
    public class DecisionEngine
    {
        public DecisionOutput Evaluate(DecisionInput input)
        {
            if (input.IsEventDriven && input.RequiresRealTime)
            {
                return new DecisionOutput
                {
                    RecommendedService = "Azure Event Grid or AWS EventBridge",
                    Justification = "Supports real-time event-based integration"
                };
            }
            else if (input.NeedsStateManagement)
            {
                return new DecisionOutput
                {
                    RecommendedService = "Azure Logic Apps with Durable Functions",
                    Justification = "Stateful workflow management needed"
                };
            }
            else if (input.IsHighThroughput)
            {
                return new DecisionOutput
                {
                    RecommendedService = "Azure Service Bus or AWS SQS",
                    Justification = "Supports high-throughput messaging"
                };
            }
            else if (input.RequiresExternalConnectivity)
            {
                return new DecisionOutput
                {
                    RecommendedService = "Azure API Management or AWS API Gateway",
                    Justification = "Exposes integration externally"
                };
            }

            return new DecisionOutput
            {
                RecommendedService = "Azure Logic Apps or AWS Step Functions",
                Justification = "General purpose integration orchestration"
            };
        }
    }
}
