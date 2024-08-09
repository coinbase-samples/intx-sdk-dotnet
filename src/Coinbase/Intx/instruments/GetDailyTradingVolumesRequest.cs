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

  public class GetDailyTradingVolumesRequest
  {
    public string? Instruments { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    [JsonPropertyName("time_from")]
    public DateTimeOffset? TimeFrom { get; set; }

    [JsonPropertyName("show_other")]
    public bool? ShowOther { get; set; }

    public class GetDailyTradingVolumesRequestBuilder
    {
      private string? _instruments;
      private int? _resultLimit;
      private int? _resultOffset;
      private DateTimeOffset? _timeFrom;
      private bool? _showOther;

      public GetDailyTradingVolumesRequestBuilder WithInstruments(string instruments)
      {
        this._instruments = instruments;
        return this;
      }

      public GetDailyTradingVolumesRequestBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public GetDailyTradingVolumesRequestBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public GetDailyTradingVolumesRequestBuilder WithTimeFrom(DateTimeOffset timeFrom)
      {
        this._timeFrom = timeFrom;
        return this;
      }

      public GetDailyTradingVolumesRequestBuilder WithShowOther(bool showOther)
      {
        this._showOther = showOther;
        return this;
      }

      public GetDailyTradingVolumesRequestBuilder WithPagination(Pagination pagination)
      {
        this._resultLimit = pagination.ResultLimit;
        this._resultOffset = pagination.ResultOffset;
        return this;
      }

      public GetDailyTradingVolumesRequest Build()
      {
        return new GetDailyTradingVolumesRequest
        {
          Instruments = this._instruments,
          ResultLimit = this._resultLimit,
          ResultOffset = this._resultOffset,
          TimeFrom = this._timeFrom,
          ShowOther = this._showOther
        };
      }
    }
  }
}
