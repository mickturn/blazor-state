﻿#if DEBUG
namespace BlazorState.Client.Features.Application
{
  using System.Collections.Generic;
  using Microsoft.JSInterop;

  public partial class ApplicationState : State<ApplicationState>
  {
    public override ApplicationState Hydrate(IDictionary<string, object> aKeyValuePairs)
    {
      return new ApplicationState
      {
        Guid = new System.Guid((string)aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(Guid))]),
        Name = (string)aKeyValuePairs[CamelCase.MemberNameToCamelCase(nameof(Name))],
      };
    }
  }
}
#endif