/*
 * Copyright 2024-present Coinbase Global, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace Coinbase.Intx.Instruments
{
  using System.Text.Json.Serialization;
  public class Aggregation
  {
    [JsonPropertyName("start")]
    public string? Start { get; set; }

    [JsonPropertyName("open")]
    public string? Open { get; set; }

    [JsonPropertyName("high")]
    public string? High { get; set; }

    [JsonPropertyName("low")]
    public string? Low { get; set; }

    [JsonPropertyName("close")]
    public string? Close { get; set; }

    [JsonPropertyName("volume")]
    public string? Volume { get; set; }

    public Aggregation() { }

    public class AggregationBuilder
    {
      private string? _start;
      private string? _open;
      private string? _high;
      private string? _low;
      private string? _close;
      private string? _volume;

      public AggregationBuilder WithStart(string start)
      {
        this._start = start;
        return this;
      }

      public AggregationBuilder WithOpen(string open)
      {
        this._open = open;
        return this;
      }

      public AggregationBuilder WithHigh(string high)
      {
        this._high = high;
        return this;
      }

      public AggregationBuilder WithLow(string low)
      {
        this._low = low;
        return this;
      }

      public AggregationBuilder WithClose(string close)
      {
        this._close = close;
        return this;
      }

      public AggregationBuilder WithVolume(string volume)
      {
        this._volume = volume;
        return this;
      }

      public Aggregation Build()
      {
        return new Aggregation
        {
          Start = this._start,
          Open = this._open,
          High = this._high,
          Low = this._low,
          Close = this._close,
          Volume = this._volume
        };
      }
    }
  }
}
