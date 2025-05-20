
# Cloud Decision Tree API (.NET 8)

This open-source tool provides dynamic cloud service recommendations using decision tree logic for modern enterprise integration scenarios.

## 🚀 Use Case
Designed for architects and engineers modernizing legacy systems (e.g., Mulesoft to Azure/AWS) with real-time, event-driven, or high-throughput integration needs.

## 🧠 Features
- .NET 8 Web API
- Supports Azure and AWS
- Decision rules extensible by config or DB
- REST endpoint for evaluating scenarios

## 🔧 Example Request
```http
POST /api/decision/evaluate
Content-Type: application/json

{
  "IsEventDriven": true,
  "RequiresRealTime": true
}
```

## ✅ Example Response
```json
{
  "recommendedService": "Azure Event Grid or AWS EventBridge",
  "justification": "Supports real-time event-based integration"
}
```

## 📐 Architecture Diagram
![Architecture](docs/architecture.png)

## 📄 License
MIT License

## ✍️ Original Contribution
This tool reflects original innovation in automated service selection logic for enterprise cloud adoption. Featured in [AWS Community Builder article](https://community.aws/content/2waFxLGjSLPsPCli6pKsaYN30X0/dynamic-aws-service-selection) and maintained as an open-source API.

## 🤝 Contributing
See [CONTRIBUTING.md](CONTRIBUTING.md).
