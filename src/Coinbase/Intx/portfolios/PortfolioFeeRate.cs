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
  public class PortfolioFeeRate
  {
    [JsonPropertyName("instrument_type")]
    public string? InstrumentType { get; set; }

    [JsonPropertyName("fee_tier_id")]
    public string? FeeTierId { get; set; }

    [JsonPropertyName("is_vip_tier")]
    public bool? IsVipTier { get; set; }

    [JsonPropertyName("fee_tier_name")]
    public string? FeeTierName { get; set; }

    [JsonPropertyName("maker_fee_rate")]
    public string? MakerFeeRate { get; set; }

    [JsonPropertyName("taker_fee_rate")]
    public string? TakerFeeRate { get; set; }

    [JsonPropertyName("rebate_rate")]
    public string? RebateRate { get; set; }

    [JsonPropertyName("is_override")]
    public bool? IsOverride { get; set; }

    [JsonPropertyName("trailing_30day_volume")]
    public string? Trailing30DayVolume { get; set; }

    [JsonPropertyName("trailing_24hr_usdc_balance")]
    public string? Trailing24HrUsdcBalance { get; set; }

    public PortfolioFeeRate() { }

    public class PortfolioFeeRateBuilder
    {
      private string? _instrumentType;
      private string? _feeTierId;
      private bool? _isVipTier;
      private string? _feeTierName;
      private string? _makerFeeRate;
      private string? _takerFeeRate;
      private string? _rebateRate;
      private bool? _isOverride;
      private string? _trailing30DayVolume;
      private string? _trailing24HrUsdcBalance;

      public PortfolioFeeRateBuilder WithInstrumentType(string instrumentType)
      {
        this._instrumentType = instrumentType;
        return this;
      }

      public PortfolioFeeRateBuilder WithFeeTierId(string feeTierId)
      {
        this._feeTierId = feeTierId;
        return this;
      }

      public PortfolioFeeRateBuilder WithIsVipTier(bool isVipTier)
      {
        this._isVipTier = isVipTier;
        return this;
      }

      public PortfolioFeeRateBuilder WithFeeTierName(string feeTierName)
      {
        this._feeTierName = feeTierName;
        return this;
      }

      public PortfolioFeeRateBuilder WithMakerFeeRate(string makerFeeRate)
      {
        this._makerFeeRate = makerFeeRate;
        return this;
      }

      public PortfolioFeeRateBuilder WithTakerFeeRate(string takerFeeRate)
      {
        this._takerFeeRate = takerFeeRate;
        return this;
      }

      public PortfolioFeeRateBuilder WithRebateRate(string rebateRate)
      {
        this._rebateRate = rebateRate;
        return this;
      }

      public PortfolioFeeRateBuilder WithIsOverride(bool isOverride)
      {
        this._isOverride = isOverride;
        return this;
      }

      public PortfolioFeeRateBuilder WithTrailing30DayVolume(string trailing30DayVolume)
      {
        this._trailing30DayVolume = trailing30DayVolume;
        return this;
      }

      public PortfolioFeeRateBuilder WithTrailing24HrUsdcBalance(string trailing24HrUsdcBalance)
      {
        this._trailing24HrUsdcBalance = trailing24HrUsdcBalance;
        return this;
      }

      public PortfolioFeeRate Build()
      {
        return new PortfolioFeeRate
        {
          InstrumentType = this._instrumentType,
          FeeTierId = this._feeTierId,
          IsOverride = this._isOverride,
          IsVipTier = this._isVipTier,
          MakerFeeRate = this._makerFeeRate,
          TakerFeeRate = this._takerFeeRate,
          RebateRate = this._rebateRate,
          FeeTierName = this._feeTierName,
          Trailing30DayVolume = this._trailing30DayVolume,
          Trailing24HrUsdcBalance = this._trailing24HrUsdcBalance
        };
      }
    }
  }
}