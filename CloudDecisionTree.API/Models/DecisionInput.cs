
namespace CloudDecisionTree.API.Models
{
    public class DecisionInput
    {
        public string IntegrationType { get; set; }
        public bool RequiresRealTime { get; set; }
        public bool NeedsStateManagement { get; set; }
        public bool IsHighThroughput { get; set; }
        public bool RequiresExternalConnectivity { get; set; }
        public bool IsEventDriven { get; set; }
    }
}
