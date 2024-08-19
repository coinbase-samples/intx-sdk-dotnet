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
  public class GetAggregatedCandlesRequest
  {
    public string? Instrument { get; set; }
    public string? Granularity { get; set; }
    public string? Start { get; set; }
    public string? End { get; set; }

    public GetAggregatedCandlesRequest() { }

    public class GetAggregatedCandlesRequestBuilder
    {
      private string? _instrument;
      private string? _granularity;
      private string? _start;
      private string? _end;

      public GetAggregatedCandlesRequestBuilder WithInstrument(string instrument)
      {
        this._instrument = instrument;
        return this;
      }

      public GetAggregatedCandlesRequestBuilder WithGranularity(string granularity)
      {
        this._granularity = granularity;
        return this;
      }

      public GetAggregatedCandlesRequestBuilder WithStart(string start)
      {
        this._start = start;
        return this;
      }

      public GetAggregatedCandlesRequestBuilder WithEnd(string end)
      {
        this._end = end;
        return this;
      }

      public GetAggregatedCandlesRequest Build()
      {
        return new GetAggregatedCandlesRequest
        {
          Instrument = this._instrument,
          Granularity = this._granularity,
          Start = this._start,
          End = this._end
        };
      }
    }
  }
}