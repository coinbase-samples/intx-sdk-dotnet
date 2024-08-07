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
  public class Position
  {
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    public string? Symbol { get; set; }

    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("instrument_uuid")]
    public string? InstrumentUUID { get; set; }

    public string? Vwap { get; set; }

    [JsonPropertyName("net_size")]
    public string? NetSize { get; set; }

    [JsonPropertyName("buy_order_size")]
    public string? BuyOrderSize { get; set; }

    [JsonPropertyName("sell_order_size")]
    public string? SellOrderSize { get; set; }

    [JsonPropertyName("im_contribution")]
    public double? ImContribution { get; set; }

    [JsonPropertyName("unrealized_pnl")]
    public string? UnrealizedPnl { get; set; }

    [JsonPropertyName("mark_price")]
    public string? MarkPrice { get; set; }

    [JsonPropertyName("entry_vwap")]
    public string? EntryVwap { get; set; }

    public Position() { }

    public class PositionBuilder
    {
      private string? _id;
      private string? _symbol;
      private string? _instrumentId;
      private string? _instrumentUUID;
      private string? _vwap;
      private string? _netSize;
      private string? _buyOrderSize;
      private string? _sellOrderSize;
      private double? _imContribution;
      private string? _unrealizedPnl;
      private string? _markPrice;
      private string? _entryVwap;

      public PositionBuilder WithId(string id)
      {
        this._id = id;
        return this;
      }

      public PositionBuilder WithSymbol(string symbol)
      {
        this._symbol = symbol;
        return this;
      }

      public PositionBuilder WithInstrumentId(string instrumentId)
      {
        this._instrumentId = instrumentId;
        return this;
      }

      public PositionBuilder WithInstrumentUUID(string instrumentUUID)
      {
        this._instrumentUUID = instrumentUUID;
        return this;
      }

      public PositionBuilder WithVwap(string vwap)
      {
        this._vwap = vwap;
        return this;
      }

      public PositionBuilder WithNetSize(string netSize)
      {
        this._netSize = netSize;
        return this;
      }

      public PositionBuilder WithBuyOrderSize(string buyOrderSize)
      {
        this._buyOrderSize = buyOrderSize;
        return this;
      }

      public PositionBuilder WithSellOrderSize(string sellOrderSize)
      {
        this._sellOrderSize = sellOrderSize;
        return this;
      }

      public PositionBuilder WithImContribution(double imContribution)
      {
        this._imContribution = imContribution;
        return this;
      }

      public PositionBuilder WithUnrealizedPnl(string unrealizedPnl)
      {
        this._unrealizedPnl = unrealizedPnl;
        return this;
      }

      public PositionBuilder WithMarkPrice(string markPrice)
      {
        this._markPrice = markPrice;
        return this;
      }

      public PositionBuilder WithEntryVwap(string entryVwap)
      {
        this._entryVwap = entryVwap;
        return this;
      }

      public Position Build()
      {
        return new Position
        {
          Id = this._id,
          Symbol = this._symbol,
          InstrumentId = this._instrumentId,
          InstrumentUUID = this._instrumentUUID,
          Vwap = this._vwap,
          NetSize = this._netSize,
          BuyOrderSize = this._buyOrderSize,
          SellOrderSize = this._sellOrderSize,
          ImContribution = this._imContribution,
          UnrealizedPnl = this._unrealizedPnl,
          MarkPrice = this._markPrice,
          EntryVwap = this._entryVwap
        };
      }
    }
  }
}