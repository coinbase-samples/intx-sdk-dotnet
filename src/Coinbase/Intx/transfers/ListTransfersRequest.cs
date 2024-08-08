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
using Coinbase.Intx.Common;

namespace Coinbase.Intx.Transfers
{
  public class ListTransfersRequest
  {
    public string? Portfolios { get; set; }

    [JsonPropertyName("time_from")]
    public string? TimeFrom { get; set; }

    [JsonPropertyName("time_to")]
    public string? TimeTo { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    public TransferStatus? Status { get; set; }

    public TransferType? Type { get; set; }

    public class ListTransfersRequestBuilder
    {
      private string? _portfolios;
      private string? _timeFrom;
      private string? _timeTo;
      private int? _resultLimit;
      private int? _resultOffset;
      private TransferStatus? _status;
      private TransferType? _type;

      public ListTransfersRequestBuilder WithPortfolios(string portfolios)
      {
        this._portfolios = portfolios;
        return this;
      }

      public ListTransfersRequestBuilder WithTimeFrom(string timeFrom)
      {
        this._timeFrom = timeFrom;
        return this;
      }

      public ListTransfersRequestBuilder WithTimeTo(string timeTo)
      {
        this._timeTo = timeTo;
        return this;
      }

      public ListTransfersRequestBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public ListTransfersRequestBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public ListTransfersRequestBuilder WithStatus(TransferStatus status)
      {
        this._status = status;
        return this;
      }

      public ListTransfersRequestBuilder WithType(TransferType type)
      {
        this._type = type;
        return this;
      }

      public ListTransfersRequestBuilder WithPagination(Pagination pagination)
      {
        this._resultLimit = pagination.ResultLimit;
        this._resultOffset = pagination.ResultOffset;
        return this;
      }

      public ListTransfersRequest Build()
      {
        return new ListTransfersRequest
        {
          Portfolios = this._portfolios,
          TimeFrom = this._timeFrom,
          TimeTo = this._timeTo,
          ResultLimit = this._resultLimit,
          ResultOffset = this._resultOffset,
          Status = this._status,
          Type = this._type
        };
      }
    }
  }
}