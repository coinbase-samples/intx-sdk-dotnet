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


namespace CoinbaseSdk.Intx.Instruments
{
  using System.Text.Json.Serialization;
  using CoinbaseSdk.Intx.Common;

  public class GetHistoricalFundingRatesRequest
  {
    [JsonIgnore]
    public string? Instrument { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    public class GetHistoricalFundingRatesRequestBuilder
    {
      private string? _instrument;
      private int? _resultLimit;
      private int? _resultOffset;

      public GetHistoricalFundingRatesRequestBuilder WithInstrument(string instrument)
      {
        this._instrument = instrument;
        return this;
      }

      public GetHistoricalFundingRatesRequestBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public GetHistoricalFundingRatesRequestBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public GetHistoricalFundingRatesRequestBuilder WithPagination(Pagination pagination)
      {
        this._resultLimit = pagination.ResultLimit;
        this._resultOffset = pagination.ResultOffset;
        return this;
      }

      public GetHistoricalFundingRatesRequest Build()
      {
        return new GetHistoricalFundingRatesRequest
        {
          Instrument = _instrument,
          ResultLimit = _resultLimit,
          ResultOffset = _resultOffset
        };
      }
    }
  }
}