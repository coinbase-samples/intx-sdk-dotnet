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


namespace Coinbase.Intx.Orders
{
  using System.Text.Json.Serialization;
  using Coinbase.Intx.Common;

  public class ListOrdersRequest
  {
    public string? Portfolio { get; set; }

    public string? Instrument { get; set; }

    [JsonPropertyName("instrument_type")]
    public InstrumentType? InstrumentType { get; set; }

    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("event_type")]
    public EventType? EventType { get; set; }

    [JsonPropertyName("order_type")]
    public OrderType? OrderType { get; set; }

    public OrderSide? Side { get; set; }

    [JsonPropertyName("ref_datetime")]
    public string? RefDateTime { get; set; }

    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    public class ListOrdersRequestBuilder
    {
      private string? _portfolio;
      private string? _instrument;
      private InstrumentType? _instrumentType;
      private string? _clientOrderId;
      private EventType? _eventType;
      private OrderType? _orderType;
      private OrderSide? _side;
      private string? _refDateTime;
      private int? _resultLimit;
      private int? _resultOffset;

      public ListOrdersRequestBuilder WithPortfolio(string portfolio)
      {
        this._portfolio = portfolio;
        return this;
      }

      public ListOrdersRequestBuilder WithInstrument(string instrument)
      {
        this._instrument = instrument;
        return this;
      }

      public ListOrdersRequestBuilder WithInstrumentType(InstrumentType instrumentType)
      {
        this._instrumentType = instrumentType;
        return this;
      }

      public ListOrdersRequestBuilder WithClientOrderId(string clientOrderId)
      {
        this._clientOrderId = clientOrderId;
        return this;
      }

      public ListOrdersRequestBuilder WithEventType(EventType eventType)
      {
        this._eventType = eventType;
        return this;
      }

      public ListOrdersRequestBuilder WithOrderType(OrderType orderType)
      {
        this._orderType = orderType;
        return this;
      }

      public ListOrdersRequestBuilder WithSide(OrderSide side)
      {
        this._side = side;
        return this;
      }

      public ListOrdersRequestBuilder WithRefDateTime(string refDateTime)
      {
        this._refDateTime = refDateTime;
        return this;
      }

      public ListOrdersRequestBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public ListOrdersRequestBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public ListOrdersRequestBuilder WithPagination(Pagination pagination)
      {
        this._resultLimit = pagination.ResultLimit;
        this._resultOffset = pagination.ResultOffset;
        return this;
      }

      public ListOrdersRequest Build()
      {
        return new ListOrdersRequest
        {
          Portfolio = this._portfolio,
          Instrument = this._instrument,
          InstrumentType = this._instrumentType,
          ClientOrderId = this._clientOrderId,
          EventType = this._eventType,
          OrderType = this._orderType,
          Side = this._side,
          RefDateTime = this._refDateTime,
          ResultLimit = this._resultLimit,
          ResultOffset = this._resultOffset
        };
      }
    }
  }
}