﻿namespace OKX.Api.Models.MarketData;

[JsonConverter(typeof(ArrayConverter))]
public class OkxMarkCandlestick
{
    [JsonIgnore]
    public string Instrument { get; set; }

    [ArrayProperty(0), JsonConverter(typeof(DateTimeConverter))]
    public DateTime Time { get; set; }

    /// <summary>
    /// Open price
    /// </summary>
    [ArrayProperty(1)]
    public decimal Open { get; set; }

    /// <summary>
    /// Highest price
    /// </summary>
    [ArrayProperty(2)]
    public decimal High { get; set; }

    /// <summary>
    /// Lowest price
    /// </summary>
    [ArrayProperty(3)]
    public decimal Low { get; set; }

    /// <summary>
    /// Close price
    /// </summary>
    [ArrayProperty(4)]
    public decimal Close { get; set; }

    [ArrayProperty(5), JsonConverter(typeof(OkxBooleanConverter))]
    public bool Confirm { get; set; }

    public override bool Equals(object obj)
    {
        // Check for null and compare run-time types.
        if (obj == null || !GetType().Equals(obj.GetType()))
            return false;

        // Equal Check
        var stick = (OkxCandlestick)obj;
        return Time == stick.Time
            && Instrument == stick.Instrument
            && Open == stick.Open
            && High == stick.High
            && Low == stick.Low
            && Close == stick.Close
            && Confirm == stick.Confirm;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
