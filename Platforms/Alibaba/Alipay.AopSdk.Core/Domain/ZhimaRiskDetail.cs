using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaRiskDetail Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaRiskDetail : AopObject
	{
		/// <summary>
		///     数据类型：Negative(负面信息)、Risk(风险信息) 。系统会将在APP上对C端披露的信息标记为负面信息，其余的信息标记为风险信息。
		/// </summary>
		[JsonProperty("data_type")]
		public string DataType { get; set; }

		/// <summary>
		///     对于该条风险信息的补充信息。是名称和值得键值对。依据不同的风险类型，存在不同内容。返回信息为JSON字符串。
		/// </summary>
		[JsonProperty("extendinfo")]
		public string Extendinfo { get; set; }

		/// <summary>
		///     风险代码
		/// </summary>
		[JsonProperty("risk_code")]
		public string RiskCode { get; set; }

		/// <summary>
		///     风险类型
		/// </summary>
		[JsonProperty("risk_type")]
		public string RiskType { get; set; }

		/// <summary>
		///     对于逾期类风险信息，此字段表示是否结清。T（结清）/F（未结清）
		/// </summary>
		[JsonProperty("settlement")]
		public string Settlement { get; set; }

		/// <summary>
		///     当用户进行异议处理，并核查完毕之后，仍有异议时，给出声明。
		/// </summary>
		[JsonProperty("statement")]
		public string Statement { get; set; }

		/// <summary>
		///     当用户本人对该条负面记录有异议时，表示该异议处理流程的状态
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		///     行业类型
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		///     数据更新时间
		/// </summary>
		[JsonProperty("update")]
		public string Update { get; set; }
	}
}