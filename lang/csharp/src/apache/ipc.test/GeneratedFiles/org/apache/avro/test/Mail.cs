// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace org.apache.avro.test
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public abstract class Mail : Avro.Specific.ISpecificProtocol
	{
		private static readonly Avro.Protocol protocol = Avro.Protocol.Parse(@"{
  ""protocol"": ""Mail"",
  ""namespace"": ""org.apache.avro.test"",
  ""types"": [
    {
      ""type"": ""record"",
      ""name"": ""Message"",
      ""namespace"": ""org.apache.avro.test"",
      ""fields"": [
        {
          ""name"": ""to"",
          ""type"": ""string""
        },
        {
          ""name"": ""from"",
          ""type"": ""string""
        },
        {
          ""name"": ""body"",
          ""type"": ""string""
        }
      ]
    }
  ],
  ""messages"": {
    ""send"": {
      ""request"": [
        {
          ""name"": ""message"",
          ""type"": ""Message""
        }
      ],
      ""response"": ""string""
    },
    ""fireandforget"": {
      ""request"": [
        {
          ""name"": ""message"",
          ""type"": ""Message""
        }
      ],
      ""response"": ""null"",
      ""one-way"": true
    }
  }
}");
		public Avro.Protocol Protocol
		{
			get
			{
				return protocol;
			}
		}
		public void Request(Avro.Specific.ICallbackRequestor requestor, string messageName, object[] args, object callback)
		{
			switch(messageName)
			{
				case "send":
				requestor.Request<System.String>(messageName, args, callback);
				break;

				case "fireandforget":
				requestor.Request<System.Object>(messageName, args, callback);
				break;
			};
		}
		public abstract string send(org.apache.avro.test.Message message);
		public abstract void fireandforget(org.apache.avro.test.Message message);
	}
}
