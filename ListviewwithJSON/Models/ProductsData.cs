﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ListviewwithJSON.Models;
//
//    var productsData = ProductsData.FromJson(jsonString);

namespace ListviewwithJSON.Models {
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ProductsData {
        [JsonProperty("productId")]
        public long ProductId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("productCode")]
        public string ProductCode { get; set; }

        [JsonProperty("releaseDate")]
        public string ReleaseDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("starRating")]
        public double StarRating { get; set; }

        [JsonProperty("imageUrl")]
        public Uri ImageUrl { get; set; }
    }

    public partial class ProductsData {
        public static List<ProductsData> FromJson(string json) => JsonConvert.DeserializeObject<List<ProductsData>>(json, ListviewwithJSON.Models.Converter.Settings);
    }

    public static class Serialize {
        public static string ToJson(this List<ProductsData> self) => JsonConvert.SerializeObject(self, ListviewwithJSON.Models.Converter.Settings);
    }

    internal static class Converter {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
