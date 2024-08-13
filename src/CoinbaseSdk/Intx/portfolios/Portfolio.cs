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
  public class Portfolio
  {
    [JsonPropertyName("portfolio_id")]
    public string? PortfolioId { get; set; }

    [JsonPropertyName("portfolio_uuid")]
    public string? PortfolioUuid { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("user_uuid")]
    public string? UserUuid { get; set; }

    [JsonPropertyName("maker_fee_rate")]
    public string? MakerFeeRate { get; set; }

    [JsonPropertyName("taker_fee_rate")]
    public string? TakerFeeRate { get; set; }

    [JsonPropertyName("trading_lock")]
    public bool? TradingLock { get; set; }

    [JsonPropertyName("withdrawal_lock")]
    public bool? WithdrawalLock { get; set; }

    [JsonPropertyName("borrow_disabled")]
    public bool? BorrowDisabled { get; set; }

    [JsonPropertyName("is_lsp")]
    public bool? IsLsp { get; set; }

    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("cross_collateral_enabled")]
    public bool? CrossCollateralEnabled { get; set; }

    [JsonPropertyName("auto_margin_enabled")]
    public bool? AutoMarginEnabled { get; set; }

    [JsonPropertyName("pre_launch_trading_enabled")]
    public bool? PreLaunchTradingEnabled { get; set; }

    [JsonPropertyName("position_offsets_enabled")]
    public bool? PositionOffsetsEnabled { get; set; }

    public Portfolio() { }

    public class PortfolioBuilder
    {
      public string? _portfolioId;
      public string? _portfolioUuid;
      public string? _name;
      public string? _userUuid;
      public string? _makerFeeRate;
      public string? _takerFeeRate;
      public bool? _tradingLock;
      public bool? _withdrawalLock;
      public bool? _borrowDisabled;
      public bool? _isLsp;
      public bool? _isDefault;
      public bool? _crossCollateralEnabled;
      public bool? _autoMarginEnabled;
      public bool? _preLaunchTradingEnabled;
      public bool? _positionOffsetsEnabled;

      public PortfolioBuilder() { }

      public PortfolioBuilder WithPortfolioId(
          string? portfolioId)
      {
        this._portfolioId = portfolioId;
        return this;
      }

      public PortfolioBuilder WithPortfolioUuid(
          string? portfolioUuid)
      {
        this._portfolioUuid = portfolioUuid;
        return this;
      }

      public PortfolioBuilder WithName(
          string? name)
      {
        this._name = name;
        return this;
      }

      public PortfolioBuilder WithUserUuid(
          string? userUuid)
      {
        this._userUuid = userUuid;
        return this;
      }

      public PortfolioBuilder WithMakerFeeRate(
          string? makerFeeRate)
      {
        this._makerFeeRate = makerFeeRate;
        return this;
      }

      public PortfolioBuilder WithTakerFeeRate(
          string? takerFeeRate)
      {
        this._takerFeeRate = takerFeeRate;
        return this;
      }

      public PortfolioBuilder WithTradingLock(
          bool? tradingLock)
      {
        this._tradingLock = tradingLock;
        return this;
      }

      public PortfolioBuilder WithWithdrawalLock(
          bool? withdrawalLock)
      {
        this._withdrawalLock = withdrawalLock;
        return this;
      }

      public PortfolioBuilder WithBorrowDisabled(
          bool? borrowDisabled)
      {
        this._borrowDisabled = borrowDisabled;
        return this;
      }

      public PortfolioBuilder WithIsLsp(
          bool? isLsp)
      {
        this._isLsp = isLsp;
        return this;
      }

      public PortfolioBuilder WithIsDefault(
          bool? isDefault)
      {
        this._isDefault = isDefault;
        return this;
      }

      public PortfolioBuilder WithCrossCollateralEnabled(
          bool? crossCollateralEnabled)
      {
        this._crossCollateralEnabled = crossCollateralEnabled;
        return this;
      }

      public PortfolioBuilder WithAutoMarginEnabled(
          bool? autoMarginEnabled)
      {
        this._autoMarginEnabled = autoMarginEnabled;
        return this;
      }

      public PortfolioBuilder WithPreLaunchTradingEnabled(
          bool? preLaunchTradingEnabled)
      {
        this._preLaunchTradingEnabled = preLaunchTradingEnabled;
        return this;
      }

      public PortfolioBuilder WithPositionOffsetsEnabled(
          bool? positionOffsetsEnabled)
      {
        this._positionOffsetsEnabled = positionOffsetsEnabled;
        return this;
      }

      public Portfolio Build()
      {
        return new Portfolio()
        {
          PortfolioId = this._portfolioId,
          PortfolioUuid = this._portfolioUuid,
          Name = this._name,
          UserUuid = this._userUuid,
          MakerFeeRate = this._makerFeeRate,
          TakerFeeRate = this._takerFeeRate,
          TradingLock = this._tradingLock,
          WithdrawalLock = this._withdrawalLock,
          BorrowDisabled = this._borrowDisabled,
          IsLsp = this._isLsp,
          IsDefault = this._isDefault,
          CrossCollateralEnabled = this._crossCollateralEnabled,
          AutoMarginEnabled = this._autoMarginEnabled,
          PreLaunchTradingEnabled = this._preLaunchTradingEnabled,
          PositionOffsetsEnabled = this._positionOffsetsEnabled
        };
      }
    }
  }
}
