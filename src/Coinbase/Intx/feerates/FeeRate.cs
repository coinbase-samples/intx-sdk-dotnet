/*
 * Copyright 2024-present Coinbase Global, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Text.Json.Serialization;

namespace Coinbase.Intx.FeeRates
{
  public class FeeRate
  {
    [JsonPropertyName("fee_tier_type")]
    public string? FeeTierType { get; set; }

    [JsonPropertyName("instrument_type")]
    public string? InstrumentType { get; set; }

    [JsonPropertyName("fee_tier_id")]
    public int? FeeTierId { get; set; }

    [JsonPropertyName("fee_tier_name")]
    public string? FeeTierName { get; set; }

    [JsonPropertyName("maker_fee_rate")]
    public double? MakerFeeRate { get; set; }

    [JsonPropertyName("taker_fee_rate")]
    public double? TakerFeeRate { get; set; }

    [JsonPropertyName("rebate_rate")]
    public double? RebateRate { get; set; }

    [JsonPropertyName("min_balance")]
    public double? MinBalance { get; set; }

    [JsonPropertyName("min_volume")]
    public double? MinVolume { get; set; }

    [JsonPropertyName("require_balance_and_volume")]
    public bool? RequireBalanceAndVolume { get; set; }

    public class FeeRateBuilder
    {
      private string? _feeTierType;
      private string? _instrumentType;
      private int? _feeTierId;
      private string? _feeTierName;
      private double? _makerFeeRate;
      private double? _takerFeeRate;
      private double? _rebateRate;
      private double? _minBalance;
      private double? _minVolume;
      private bool? _requireBalanceAndVolume;

      public FeeRateBuilder WithFeeTierType(string feeTierType)
      {
        this._feeTierType = feeTierType;
        return this;
      }

      public FeeRateBuilder WithInstrumentType(string instrumentType)
      {
        this._instrumentType = instrumentType;
        return this;
      }

      public FeeRateBuilder WithFeeTierId(int feeTierId)
      {
        this._feeTierId = feeTierId;
        return this;
      }

      public FeeRateBuilder WithFeeTierName(string feeTierName)
      {
        this._feeTierName = feeTierName;
        return this;
      }

      public FeeRateBuilder WithMakerFeeRate(double makerFeeRate)
      {
        this._makerFeeRate = makerFeeRate;
        return this;
      }

      public FeeRateBuilder WithTakerFeeRate(double takerFeeRate)
      {
        this._takerFeeRate = takerFeeRate;
        return this;
      }

      public FeeRateBuilder WithRebateRate(double rebateRate)
      {
        this._rebateRate = rebateRate;
        return this;
      }

      public FeeRateBuilder WithMinBalance(double minBalance)
      {
        this._minBalance = minBalance;
        return this;
      }

      public FeeRateBuilder WithMinVolume(double minVolume)
      {
        this._minVolume = minVolume;
        return this;
      }

      public FeeRateBuilder WithRequireBalanceAndVolume(bool requireBalanceAndVolume)
      {
        this._requireBalanceAndVolume = requireBalanceAndVolume;
        return this;
      }

      public FeeRate Build()
      {
        return new FeeRate
        {
          FeeTierType = this._feeTierType,
          InstrumentType = this._instrumentType,
          FeeTierId = this._feeTierId,
          FeeTierName = this._feeTierName,
          MakerFeeRate = this._makerFeeRate,
          TakerFeeRate = this._takerFeeRate,
          RebateRate = this._rebateRate,
          MinBalance = this._minBalance,
          MinVolume = this._minVolume,
          RequireBalanceAndVolume = this._requireBalanceAndVolume
        };
      }
    }
  }
}