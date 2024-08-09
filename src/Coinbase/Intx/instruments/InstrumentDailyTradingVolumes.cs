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
  public class InstrumentDailyTradingVolumes
  {
    public class Result
    {
      [JsonPropertyName("timestamp")]
      public DateTimeOffset? Timestamp { get; set; }

      [JsonPropertyName("instruments")]
      public InstrumentSubset[]? Instruments { get; set; } = [];

      [JsonPropertyName("totals")]
      public Totals? Totals { get; set; }
    }

    public class InstrumentSubset
    {
      [JsonPropertyName("symbol")]
      public string? Symbol { get; set; }

      [JsonPropertyName("volume")]
      public string? Volume { get; set; }

      [JsonPropertyName("notional")]
      public string? Notional { get; set; }
    }

    public class Totals
    {
      [JsonPropertyName("total_instruments_volume")]
      public string? TotalInstrumentsVolume { get; set; }

      [JsonPropertyName("total_instruments_notional")]
      public string? TotalInstrumentsNotional { get; set; }

      [JsonPropertyName("total_exchange_volume")]
      public string? TotalExchangeVolume { get; set; }

      [JsonPropertyName("total_exchange_notional")]
      public string? TotalExchangeNotional { get; set; }
    }
  }
}
