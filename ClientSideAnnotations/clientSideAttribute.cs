using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebMap
{

	[System.AttributeUsage(System.AttributeTargets.Class |
											 System.AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property)
  ]
    public class ClientSideAttribute : System.Attribute
    {
    }
}
