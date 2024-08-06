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
  using Coinbase.Intx.Common;
  public class HistoricalFundingRate
  {
    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("funding_rate")]
    public double? FundingRate { get; set; }

    [JsonPropertyName("mark_price")]
    public double? MarkPrice { get; set; }

    [JsonPropertyName("event_time")]
    public string? EventTime { get; set; }

    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }

    public HistoricalFundingRate() { }

    public class HistoricalFundingRateBuilder
    {
      private string? _instrumentId;
      private double? _fundingRate;
      private double? _markPrice;
      private string? _eventTime;
      private Pagination? _pagination;

      public HistoricalFundingRateBuilder WithInstrumentId(string instrumentId)
      {
        this._instrumentId = instrumentId;
        return this;
      }

      public HistoricalFundingRateBuilder WithFundingRate(double fundingRate)
      {
        this._fundingRate = fundingRate;
        return this;
      }

      public HistoricalFundingRateBuilder WithMarkPrice(double markPrice)
      {
        this._markPrice = markPrice;
        return this;
      }

      public HistoricalFundingRateBuilder WithEventTime(string eventTime)
      {
        this._eventTime = eventTime;
        return this;
      }

      public HistoricalFundingRateBuilder WithPagination(Pagination pagination)
      {
        this._pagination = pagination;
        return this;
      }

      public HistoricalFundingRate Build()
      {
        return new HistoricalFundingRate
        {
          InstrumentId = this._instrumentId,
          FundingRate = this._fundingRate,
          MarkPrice = this._markPrice,
          EventTime = this._eventTime,
          Pagination = this._pagination
        };
      }
    }
  }
}
