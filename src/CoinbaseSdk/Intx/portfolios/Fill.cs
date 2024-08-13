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

namespace CoinbaseSdk.Intx.Portfolios
{
  using System.Text.Json.Serialization;
  using CoinbaseSdk.Intx.Orders;
  public class Fill
  {
    [JsonPropertyName("portfolio_id")]
    public string? PortfolioId { get; set; }

    [JsonPropertyName("portfolio_uuid")]
    public string? PortfolioUuid { get; set; }

    [JsonPropertyName("portfolio_name")]
    public string? PortfolioName { get; set; }

    [JsonPropertyName("fill_id")]
    public string? FillId { get; set; }

    [JsonPropertyName("exec_id")]
    public string? ExecId { get; set; }

    [JsonPropertyName("order_id")]
    public string? OrderId { get; set; }

    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("instrument_uuid")]
    public string? InstrumentUuid { get; set; }

    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    [JsonPropertyName("match_id")]
    public string? MatchId { get; set; }

    [JsonPropertyName("fill_price")]
    public string? FillPrice { get; set; }

    [JsonPropertyName("fill_qty")]
    public string? FillQty { get; set; }

    [JsonPropertyName("client_id")]
    public string? ClientId { get; set; }

    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("order_qty")]
    public string? OrderQty { get; set; }

    [JsonPropertyName("limit_price")]
    public string? LimitPrice { get; set; }

    [JsonPropertyName("total_filled")]
    public string? TotalFilled { get; set; }

    [JsonPropertyName("filled_vwap")]
    public string? FilledVwap { get; set; }

    [JsonPropertyName("expire_time")]
    public DateTimeOffset? ExpireTime { get; set; }

    [JsonPropertyName("stop_price")]
    public string? StopPrice { get; set; }

    [JsonPropertyName("side")]
    public OrderSide? Side { get; set; }

    [JsonPropertyName("tif")]
    public string? Tif { get; set; }

    [JsonPropertyName("stp_mode")]
    public string? StpMode { get; set; }

    [JsonPropertyName("flags")]
    public string? Flags { get; set; }

    [JsonPropertyName("fee")]
    public string? Fee { get; set; }

    [JsonPropertyName("fee_asset")]
    public string? FeeAsset { get; set; }

    [JsonPropertyName("order_status")]
    public string? OrderStatus { get; set; }

    [JsonPropertyName("event_time")]
    public DateTimeOffset? EventTime { get; set; }

    public Fill() { }

    public class Builder
    {
      public string? _portfolioId;
      public string? _portfolioUuid;
      public string? _portfolioName;
      public string? _fillId;
      public string? _execId;
      public string? _orderId;
      public string? _instrumentId;
      public string? _instrumentUuid;
      public string? _symbol;
      public string? _matchId;
      public string? _fillPrice;
      public string? _fillQty;
      public string? _clientId;
      public string? _clientOrderId;
      public string? _orderQty;
      public string? _limitPrice;
      public string? _totalFilled;
      public string? _filledVwap;
      public DateTimeOffset? _expireTime;
      public string? _stopPrice;
      public OrderSide? _side;
      public string? _tif;
      public string? _stpMode;
      public string? _flags;
      public string? _fee;
      public string? _feeAsset;
      public string? _orderStatus;
      public DateTimeOffset? _eventTime;

      public Builder() { }

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

      public Builder WithPortfolioName(string? portfolioName)
      {
        this._portfolioName = portfolioName;
        return this;
      }

      public Builder WithFillId(string? fillId)
      {
        this._fillId = fillId;
        return this;
      }

      public Builder WithExecId(string? execId)
      {
        this._execId = execId;
        return this;
      }

      public Builder WithOrderId(string? orderId)
      {
        this._orderId = orderId;
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

      public Builder WithMatchId(string? matchId)
      {
        this._matchId = matchId;
        return this;
      }

      public Builder WithFillPrice(string? fillPrice)
      {
        this._fillPrice = fillPrice;
        return this;
      }

      public Builder WithFillQty(string? fillQty)
      {
        this._fillQty = fillQty;
        return this;
      }

      public Builder WithClientId(string? clientId)
      {
        this._clientId = clientId;
        return this;
      }

      public Builder WithClientOrderId(string? clientOrderId)
      {
        this._clientOrderId = clientOrderId;
        return this;
      }

      public Builder WithOrderQty(string? orderQty)
      {
        this._orderQty = orderQty;
        return this;
      }

      public Builder WithLimitPrice(string? limitPrice)
      {
        this._limitPrice = limitPrice;
        return this;
      }

      public Builder WithTotalFilled(string? totalFilled)
      {
        this._totalFilled = totalFilled;
        return this;
      }

      public Builder WithFilledVwap(string? filledVwap)
      {
        this._filledVwap = filledVwap;
        return this;
      }

      public Builder WithExpireTime(DateTimeOffset? expireTime)
      {
        this._expireTime = expireTime;
        return this;
      }

      public Builder WithStopPrice(string? stopPrice)
      {
        this._stopPrice = stopPrice;
        return this;
      }

      public Builder WithSide(OrderSide? side)
      {
        this._side = side;
        return this;
      }

      public Builder WithTif(string? tif)
      {
        this._tif = tif;
        return this;
      }

      public Builder WithStpMode(string? stpMode)
      {
        this._stpMode = stpMode;
        return this;
      }

      public Builder WithFlags(string? flags)
      {
        this._flags = flags;
        return this;
      }

      public Builder WithFee(string? fee)
      {
        this._fee = fee;
        return this;
      }

      public Builder WithFeeAsset(string? feeAsset)
      {
        this._feeAsset = feeAsset;
        return this;
      }

      public Builder WithOrderStatus(string? orderStatus)
      {
        this._orderStatus = orderStatus;
        return this;
      }

      public Builder WithEventTime(DateTimeOffset? eventTime)
      {
        this._eventTime = eventTime;
        return this;
      }

      public Fill Build()
      {
        return new Fill()
        {
          PortfolioId = this._portfolioId,
          PortfolioUuid = this._portfolioUuid,
          PortfolioName = this._portfolioName,
          FillId = this._fillId,
          ExecId = this._execId,
          OrderId = this._orderId,
          InstrumentId = this._instrumentId,
          InstrumentUuid = this._instrumentUuid,
          Symbol = this._symbol,
          MatchId = this._matchId,
          FillPrice = this._fillPrice,
          FillQty = this._fillQty,
          ClientId = this._clientId,
          ClientOrderId = this._clientOrderId,
          OrderQty = this._orderQty,
          LimitPrice = this._limitPrice,
          TotalFilled = this._totalFilled,
          FilledVwap = this._filledVwap,
          ExpireTime = this._expireTime,
          StopPrice = this._stopPrice,
          Side = this._side,
          Tif = this._tif,
          StpMode = this._stpMode,
          Flags = this._flags,
          Fee = this._fee,
          FeeAsset = this._feeAsset,
          OrderStatus = this._orderStatus,
          EventTime = this._eventTime
        };
      }
    }
  }
}
