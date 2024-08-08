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

namespace Coinbase.Intx.Portfolios
{
  using System.Text.Json.Serialization;
  using Coinbase.Core.Error;
  using Coinbase.Intx.Common;

  public class ListPortfolioFillsRequest(string portfolio)
  {
    [JsonIgnore]
    public string Portfolio { get; set; } = portfolio;

    [JsonPropertyName("order_id")]
    public string? OrderId { get; set; }

    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("ref_datetime")]
    public string? RefDatetime { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    [JsonPropertyName("time_from")]
    public string? TimeFrom { get; set; }

    public class ListPortfolioFillsRequestBuilder
    {
      private string? _portfolio;
      private string? _orderId;
      private string? _clientOrderId;
      private string? _refDatetime;
      private int? _resultLimit;
      private int? _resultOffset;
      private string? _timeFrom;

      public ListPortfolioFillsRequestBuilder WithPortfolio(string portfolio)
      {
        this._portfolio = portfolio;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithOrderId(string orderId)
      {
        this._orderId = orderId;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithClientOrderId(string clientOrderId)
      {
        this._clientOrderId = clientOrderId;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithRefDatetime(string refDatetime)
      {
        this._refDatetime = refDatetime;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithTimeFrom(string timeFrom)
      {
        this._timeFrom = timeFrom;
        return this;
      }

      public ListPortfolioFillsRequestBuilder WithPagination(Pagination pagination)
      {
        this._resultLimit = pagination.ResultLimit;
        this._resultOffset = pagination.ResultOffset;
        return this;
      }

      private void Validate()
      {
        if (string.IsNullOrWhiteSpace(this._portfolio))
        {
          throw new CoinbaseClientException("Portfolio is required");
        }
      }

      public ListPortfolioFillsRequest Build()
      {
        return new ListPortfolioFillsRequest(this._portfolio!)
        {
          OrderId = this._orderId,
          ClientOrderId = this._clientOrderId,
          RefDatetime = this._refDatetime,
          ResultLimit = this._resultLimit,
          ResultOffset = this._resultOffset,
          TimeFrom = this._timeFrom
        };
      }
    }
  }
}