using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Core.Entities
{
	[DataContract]
	public class DataPoint
	{
		public DataPoint(string name, string label, double y)
		{
			this.Name = name;
			this.Label = label;
			this.Y = y;
		}

		[DataMember(Name = "name")]
		public string Name = "";

		[DataMember(Name = "label")]
		public string Label = "";

		[DataMember(Name = "y")]
		public Nullable<double> Y = null;
	}
}
