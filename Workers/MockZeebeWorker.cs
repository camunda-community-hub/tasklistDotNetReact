﻿using System.Text.Json.Nodes;
using Zeebe.Client.Accelerator.Abstractions;
using Zeebe.Client.Accelerator.Attributes;

namespace tasklistDotNetReact.Services
{
  [JobType("mock")]
  public class MockZeebeWorker : IAsyncZeebeWorkerWithResult<JsonNode>
  {
    public MockZeebeWorker()
    {
    }
    public async Task<JsonNode> HandleJob(ZeebeJob job, CancellationToken cancellationToken)
    {
      // get variables as declared (SimpleJobPayload)
      JsonNode variables = job.getVariables<JsonNode>();
      variables["mock"] = "executed";
      return variables;
    }
  }
}

