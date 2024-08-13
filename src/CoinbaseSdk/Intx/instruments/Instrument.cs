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

namespace CoinbaseSdk.Intx.Instruments
{
  public class Instrument
  {
    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("instrument_uuid")]
    public string? InstrumentUuid { get; set; }

    [JsonPropertyName("symbol")]
    public string? Symbol { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("base_asset_id")]
    public string? BaseAssetId { get; set; }

    [JsonPropertyName("base_asset_uuid")]
    public string? BaseAssetUuid { get; set; }

    [JsonPropertyName("base_asset_name")]
    public string? BaseAssetName { get; set; }

    [JsonPropertyName("quote_asset_id")]
    public string? QuoteAssetId { get; set; }

    [JsonPropertyName("quote_asset_uuid")]
    public string? QuoteAssetUuid { get; set; }

    [JsonPropertyName("quote_asset_name")]
    public string? QuoteAssetName { get; set; }

    [JsonPropertyName("base_increment")]
    public string? BaseIncrement { get; set; }

    [JsonPropertyName("quote_increment")]
    public string? QuoteIncrement { get; set; }

    [JsonPropertyName("price_band_percent")]
    public double? PriceBandPercent { get; set; }

    [JsonPropertyName("market_order_percent")]
    public double? MarketOrderPercent { get; set; }

    [JsonPropertyName("qty_24hr")]
    public string? Qty24hr { get; set; }

    [JsonPropertyName("notional_24hr")]
    public string? Notional24hr { get; set; }

    [JsonPropertyName("avg_daily_qty")]
    public string? AvgDailyQty { get; set; }

    [JsonPropertyName("avg_daily_notional")]
    public string? AvgDailyNotional { get; set; }

    [JsonPropertyName("previous_day_qty")]
    public string? PreviousDayQty { get; set; }

    [JsonPropertyName("open_interest")]
    public string? OpenInterest { get; set; }

    [JsonPropertyName("position_limit_qty")]
    public string? PositionLimitQty { get; set; }

    [JsonPropertyName("position_limit_adq_pct")]
    public double? PositionLimitAdqPct { get; set; }

    [JsonPropertyName("replacement_cost")]
    public string? ReplacementCost { get; set; }

    [JsonPropertyName("base_imf")]
    public double? BaseImf { get; set; }

    [JsonPropertyName("default_imf")]
    public string? DefaultImf { get; set; }

    [JsonPropertyName("min_notional_value")]
    public string? MinNotionalValue { get; set; }

    [JsonPropertyName("funding_interval")]
    public string? FundingInterval { get; set; }

    [JsonPropertyName("trading_state")]
    public string? TradingState { get; set; }

    [JsonPropertyName("quote")]
    public Quote? Quote { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("base_asset_multiplier")]
    public string? BaseAssetMultiplier { get; set; }

    public Instrument() { }
  }
}
