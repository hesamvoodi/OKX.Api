﻿namespace OKX.Api.Models.PublicData;

public class OkxDeliveryExerciseHistory
{
    [JsonProperty("ts")]
    public long Timestamp { get; set; }

    [JsonIgnore]
    public DateTime Time { get { return Timestamp.ConvertFromMilliseconds(); } }

    [JsonProperty("details")]
    public IEnumerable<OkxPublicDeliveryExerciseHistoryDetail> Details { get; set; }
}

public class OkxPublicDeliveryExerciseHistoryDetail
{
    [JsonProperty("insId")]
    public string Instrument { get; set; }

    [JsonProperty("px")]
    public decimal Price { get; set; }

    [JsonProperty("type"), JsonConverter(typeof(DeliveryExerciseHistoryTypeConverter))]
    public OkxDeliveryExerciseHistoryType Type { get; set; }
}
