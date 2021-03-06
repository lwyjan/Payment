using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherDescDetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class VoucherDescDetailModel : AlipayObject
    {
        /// <summary>
        /// 优惠的说明信息
        /// </summary>
        [JsonProperty("details")]
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 优惠的标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
