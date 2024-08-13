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

namespace CoinbaseSdk.Intx.Orders
{
  using System.Text.Json.Serialization;
  public class CreateOrderRequest
  {
    [JsonPropertyName("client_order_id")]
    public string? ClientOrderId { get; set; }

    [JsonPropertyName("side")]
    public string? Side { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("tif")]
    public string? Tif { get; set; }

    [JsonPropertyName("instrument")]
    public string? Instrument { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("stop_price")]
    public string? StopPrice { get; set; }

    [JsonPropertyName("stop_limit_price")]
    public string? StopLimitPrice { get; set; }

    [JsonPropertyName("expire_time")]
    public DateTimeOffset? ExpireTime { get; set; }

    [JsonPropertyName("portfolio")]
    public string? Portfolio { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }

    [JsonPropertyName("stp_mode")]
    public string? StpMode { get; set; }

    [JsonPropertyName("post_only")]
    public bool? PostOnly { get; set; }

    public CreateOrderRequest() { }

    public class Builder
    {
      public string? _clientOrderId;
      public string? _side;
      public string? _size;
      public string? _tif;
      public string? _instrument;
      public string? _type;
      public string? _price;
      public string? _stopPrice;
      public string? _stopLimitPrice;
      public DateTimeOffset? _expireTime;
      public string? _portfolio;
      public string? _user;
      public string? _stpMode;
      public bool? _postOnly;

      public Builder() { }

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

      public Builder WithInstrument(string? instrument)
      {
        this._instrument = instrument;
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

      public Builder WithExpireTime(DateTimeOffset? expireTime)
      {
        this._expireTime = expireTime;
        return this;
      }

      public Builder WithPortfolio(string? portfolio)
      {
        this._portfolio = portfolio;
        return this;
      }

      public Builder WithUser(string? user)
      {
        this._user = user;
        return this;
      }

      public Builder WithStpMode(string? stpMode)
      {
        this._stpMode = stpMode;
        return this;
      }

      public Builder WithPostOnly(bool? postOnly)
      {
        this._postOnly = postOnly;
        return this;
      }

      public CreateOrderRequest Build()
      {
        return new CreateOrderRequest
        {
          ClientOrderId = this._clientOrderId,
          Side = this._side,
          Size = this._size,
          Tif = this._tif,
          Instrument = this._instrument,
          Type = this._type,
          Price = this._price,
          StopPrice = this._stopPrice,
          StopLimitPrice = this._stopLimitPrice,
          ExpireTime = this._expireTime,
          Portfolio = this._portfolio,
          User = this._user,
          StpMode = this._stpMode,
          PostOnly = this._postOnly
        };
      }
    }
  }
}
