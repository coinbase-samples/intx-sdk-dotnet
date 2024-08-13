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

using System.Text.Json.Serialization;
using CoinbaseSdk.Intx.Common;

namespace CoinbaseSdk.Intx.Portfolios
{
  public class ListFillsByPortfoliosRequest
  {
    public string[] Portfolios { get; set; } = [];

    [JsonPropertyName("order_id")]
    public string? OrderId { get; set; }

    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("ref_datetime")]
    public DateTimeOffset? RefDatetime { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    [JsonPropertyName("time_from")]
    public DateTimeOffset? TimeFrom { get; set; }

    public ListFillsByPortfoliosRequest() { }

    public class ListFillsByPortfoliosRequestBuilder
    {
      private string[] _portfolios = [];
      private string? _orderId;
      private string? _clientOrderId;
      private DateTimeOffset? _refDatetime;
      private int? _resultLimit;
      private int? _resultOffset;
      private DateTimeOffset? _timeFrom;

      public ListFillsByPortfoliosRequestBuilder WithPortfolios(string[] portfolios)
      {
        _portfolios = portfolios;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithOrderId(string orderId)
      {
        _orderId = orderId;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithClientOrderId(string clientOrderId)
      {
        _clientOrderId = clientOrderId;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithRefDatetime(DateTimeOffset refDatetime)
      {
        _refDatetime = refDatetime;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithResultLimit(int resultLimit)
      {
        _resultLimit = resultLimit;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithResultOffset(int resultOffset)
      {
        _resultOffset = resultOffset;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithTimeFrom(DateTimeOffset timeFrom)
      {
        _timeFrom = timeFrom;
        return this;
      }

      public ListFillsByPortfoliosRequestBuilder WithPagination(Pagination pagination)
      {
        _resultLimit = pagination.ResultLimit;
        _resultOffset = pagination.ResultOffset;
        return this;
      }

      public ListFillsByPortfoliosRequest Build()
      {
        return new ListFillsByPortfoliosRequest
        {
          Portfolios = _portfolios,
          OrderId = _orderId,
          ClientOrderId = _clientOrderId,
          RefDatetime = _refDatetime,
          ResultLimit = _resultLimit,
          ResultOffset = _resultOffset,
          TimeFrom = _timeFrom
        };
      }
    }
  }
}
