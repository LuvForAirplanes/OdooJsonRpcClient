﻿using System;
using Newtonsoft.Json;
using PortaCapena.OdooJsonRpcClient.Converters;
using PortaCapena.OdooJsonRpcClient.Models;
using PortaCapena.OdooJsonRpcClient.Utils;

namespace PortaCapena.OdooJsonRpcClient.Tests.Models.Create
{
    [OdooTableName("coupon.program")]
    [JsonConverter(typeof(OdooModelConverter))]
    public class OdooVoucherCreateOrUpdate : IOdooCreateModel
    {
        //[JsonProperty("id")]
        //public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("promo_code")]
        public string PromoCode { get; set; }
        [JsonProperty("rule_date_to")]
        public DateTime? RuleDateTo { get; set; }
        [JsonProperty("program_type")]
        public string ProgramType { get; set; }
        [JsonProperty("discount_fixed_amount")]
        public double DiscountFixedAmount { get; set; }
        [JsonProperty("discount_type")]
        public string DiscountType { get; set; }
    }
}