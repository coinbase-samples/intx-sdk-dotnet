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
  public class Order
  {
    [JsonPropertyName("order_id")]
    public string? OrderId { get; set; }

    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("side")]
    public string? Side { get; set; }

    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("instrument_uuid")]
    public string? InstrumentUuid { get; set; }

    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    [JsonPropertyName("portfolio_id")]
    public string? PortfolioId { get; set; }

    [JsonPropertyName("portfolio_uuid")]
    public string? PortfolioUuid { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("stop_price")]
    public string? StopPrice { get; set; }

    [JsonPropertyName("stop_limit_price")]
    public string? StopLimitPrice { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tif")]
    public string? Tif { get; set; }

    [JsonPropertyName("expire_time")]
    public DateTimeOffset? ExpireTime { get; set; }

    [JsonPropertyName("stp_mode")]
    public string? StpMode { get; set; }

    [JsonPropertyName("event_type")]
    public string? EventType { get; set; }

    [JsonPropertyName("event_time")]
    public DateTimeOffset? EventTime { get; set; }

    [JsonPropertyName("submit_time")]
    public DateTimeOffset? SubmitTime { get; set; }

    [JsonPropertyName("order_status")]
    public string? OrderStatus { get; set; }

    [JsonPropertyName("leaves_qty")]
    public string? LeavesQty { get; set; }

    [JsonPropertyName("exec_qty")]
    public string? ExecQty { get; set; }

    [JsonPropertyName("avg_price")]
    public string? AvgPrice { get; set; }

    [JsonPropertyName("fee")]
    public string? Fee { get; set; }

    [JsonPropertyName("post_only")]
    public bool? PostOnly { get; set; }

    [JsonPropertyName("close_only")]
    public bool? CloseOnly { get; set; }

    public Order() { }

    public class Builder
    {
      public string? _orderId;
      public string? _clientOrderId;
      public string? _side;
      public string? _instrumentId;
      public string? _instrumentUuid;
      public string? _symbol;
      public string? _portfolioId;
      public string? _portfolioUuid;
      public string? _type;
      public string? _price;
      public string? _stopPrice;
      public string? _stopLimitPrice;
      public string? _size;
      public string? _tif;
      public DateTimeOffset? _expireTime;
      public string? _stpMode;
      public string? _eventType;
      public DateTimeOffset? _eventTime;
      public DateTimeOffset? _submitTime;
      public string? _orderStatus;
      public string? _leavesQty;
      public string? _execQty;
      public string? _avgPrice;
      public string? _fee;
      public bool? _postOnly;
      public bool? _closeOnly;

      public Builder() { }

      public Builder WithOrderId(string? orderId)
      {
        this._orderId = orderId;
        return this;
      }

      public Builder WithClientOrderId(string? clientOrderId)
      {
        this._clientOrderId = clientOrderId;
        return this;
      }

      public Builder WithSide(string? side)
      {
        this._side = side;
        return this;
      }

      public Builder WithInstrumentId(string? instrumentId)
      {
        this._instrumentId = instrumentId;
        return this;
      }

      public Builder WithInstrumentUuid(string? instrumentUuid)
      {
        this._instrumentUuid = instrumentUuid;
        return this;
      }

      public Builder WithSymbol(string? symbol)
      {
        this._symbol = symbol;
        return this;
      }

      public Builder WithPortfolioId(string? portfolioId)
      {
        this._portfolioId = portfolioId;
        return this;
      }

      public Builder WithPortfolioUuid(string? portfolioUuid)
      {
        this._portfolioUuid = portfolioUuid;
        return this;
      }

      public Builder WithType(string? type)
      {
        this._type = type;
        return this;
      }

      public Builder WithPrice(string? price)
      {
        this._price = price;
        return this;
      }

      public Builder WithStopPrice(string? stopPrice)
      {
        this._stopPrice = stopPrice;
        return this;
      }

      public Builder WithStopLimitPrice(string? stopLimitPrice)
      {
        this._stopLimitPrice = stopLimitPrice;
        return this;
      }

      public Builder WithSize(string? size)
      {
        this._size = size;
        return this;
      }

      public Builder WithTif(string? tif)
      {
        this._tif = tif;
        return this;
      }

      public Builder WithExpireTime(DateTimeOffset? expireTime)
      {
        this._expireTime = expireTime;
        return this;
      }

      public Builder WithStpMode(string? stpMode)
      {
        this._stpMode = stpMode;
        return this;
      }

      public Builder WithEventType(string? eventType)
      {
        this._eventType = eventType;
        return this;
      }

      public Builder WithEventTime(DateTimeOffset? eventTime)
      {
        this._eventTime = eventTime;
        return this;
      }

      public Builder WithSubmitTime(DateTimeOffset? submitTime)
      {
        this._submitTime = submitTime;
        return this;
      }

      public Builder WithOrderStatus(string? orderStatus)
      {
        this._orderStatus = orderStatus;
        return this;
      }

      public Builder WithLeavesQty(string? leavesQty)
      {
        this._leavesQty = leavesQty;
        return this;
      }

      public Builder WithExecQty(string? execQty)
      {
        this._execQty = execQty;
        return this;
      }

      public Builder WithAvgPrice(string? avgPrice)
      {
        this._avgPrice = avgPrice;
        return this;
      }

      public Builder WithFee(string? fee)
      {
        this._fee = fee;
        return this;
      }

      public Builder WithPostOnly(bool? postOnly)
      {
        this._postOnly = postOnly;
        return this;
      }

      public Builder WithCloseOnly(bool? closeOnly)
      {
        this._closeOnly = closeOnly;
        return this;
      }

      public Order Build()
      {
        return new Order()
        {
          OrderId = this._orderId,
          ClientOrderId = this._clientOrderId,
          Side = this._side,
          InstrumentId = this._instrumentId,
          InstrumentUuid = this._instrumentUuid,
          Symbol = this._symbol,
          PortfolioId = this._portfolioId,
          PortfolioUuid = this._portfolioUuid,
          Type = this._type,
          Price = this._price,
          StopPrice = this._stopPrice,
          StopLimitPrice = this._stopLimitPrice,
          Size = this._size,
          Tif = this._tif,
          ExpireTime = this._expireTime,
          StpMode = this._stpMode,
          EventType = this._eventType,
          EventTime = this._eventTime,
          SubmitTime = this._submitTime,
          OrderStatus = this._orderStatus,
          LeavesQty = this._leavesQty,
          ExecQty = this._execQty,
          AvgPrice = this._avgPrice,
          Fee = this._fee,
          PostOnly = this._postOnly,
          CloseOnly = this._closeOnly
        };
      }
    }
  }
}
