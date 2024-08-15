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
  public class Summary
  {
    public string? Collateral { get; set; }

    [JsonPropertyName("unrealized_pnl")]
    public string? UnrealizedPnl { get; set; }

    [JsonPropertyName("unrealized_pnl_percent")]
    public string? UnrealizedPnlPercent { get; set; }

    [JsonPropertyName("position_notional")]
    public string? PositionNotional { get; set; }

    [JsonPropertyName("open_position_notional")]
    public string? OpenPositionNotional { get; set; }

    [JsonPropertyName("pending_fees")]
    public string? PendingFees { get; set; }

    public string? Borrow { get; set; }

    [JsonPropertyName("accrued_interest")]
    public string? AccruedInterest { get; set; }

    [JsonPropertyName("rolling_debt")]
    public string? RollingDebt { get; set; }

    public string? Balance { get; set; }

    [JsonPropertyName("buying_power")]
    public string? BuyingPower { get; set; }

    [JsonPropertyName("portfolio_initial_margin")]
    public double? PortfolioInitialMargin { get; set; }

    [JsonPropertyName("portfolio_current_margin")]
    public double? PortfolioCurrentMargin { get; set; }

    [JsonPropertyName("portfolio_maintenance_margin")]
    public double? PortfolioMaintenanceMargin { get; set; }

    [JsonPropertyName("portfolio_close_out_margin")]
    public double? PortfolioCloseOutMargin { get; set; }

    [JsonPropertyName("in_liquidation")]
    public bool? InLiquidation { get; set; }

    [JsonPropertyName("portfolio_initial_margin_notional")]
    public double? PortfolioInitialMarginNotional { get; set; }

    [JsonPropertyName("portfolio_current_margin_notional")]
    public double? PortfolioCurrentMarginNotional { get; set; }

    [JsonPropertyName("portfolio_maintenance_margin_notional")]
    public double? PortfolioMaintenanceMarginNotional { get; set; }

    [JsonPropertyName("portfolio_close_out_margin_notional")]
    public double? PortfolioCloseOutMarginNotional { get; set; }

    [JsonPropertyName("margin_override")]
    public double? MarginOverride { get; set; }

    [JsonPropertyName("lock_up_initial_margin")]
    public double? LockUpInitialMargin { get; set; }

    [JsonPropertyName("loan_collateral_requirement")]
    public string? LoanCollateralRequirement { get; set; }

    [JsonPropertyName("position_offset_notional")]
    public string? PositionOffsetNotional { get; set; }

    public Summary() { }

    public class SummaryBuilder
    {
      private string? _collateral;
      private string? _unrealizedPnl;
      private string? _unrealizedPnlPercent;
      private string? _positionNotional;
      private string? _openPositionNotional;
      private string? _pendingFees;
      private string? _borrow;
      private string? _accruedInterest;
      private string? _rollingDebt;
      private string? _balance;
      private string? _buyingPower;
      private double? _portfolioInitialMargin;
      private double? _portfolioCurrentMargin;
      private double? _portfolioMaintenanceMargin;
      private double? _portfolioCloseOutMargin;
      private bool? _inLiquidation;
      private double? _portfolioInitialMarginNotional;
      private double? _portfolioCurrentMarginNotional;
      private double? _portfolioMaintenanceMarginNotional;
      private double? _portfolioCloseOutMarginNotional;
      private double? _marginOverride;
      private double? _lockUpInitialMargin;
      private string? _loanCollateralRequirement;
      private string? _positionOffsetNotional;

      public SummaryBuilder() { }

      public SummaryBuilder WithCollateral(string? collateral)
      {
        this._collateral = collateral;
        return this;
      }

      public SummaryBuilder WithUnrealizedPnl(string? unrealizedPnl)
      {
        this._unrealizedPnl = unrealizedPnl;
        return this;
      }

      public SummaryBuilder WithUnrealizedPnlPercent(string? unrealizedPnlPercent)
      {
        this._unrealizedPnlPercent = unrealizedPnlPercent;
        return this;
      }

      public SummaryBuilder WithPositionNotional(string? positionNotional)
      {
        this._positionNotional = positionNotional;
        return this;
      }

      public SummaryBuilder WithOpenPositionNotional(string? openPositionNotional)
      {
        this._openPositionNotional = openPositionNotional;
        return this;
      }

      public SummaryBuilder WithPendingFees(string? pendingFees)
      {
        this._pendingFees = pendingFees;
        return this;
      }

      public SummaryBuilder WithBorrow(string? borrow)
      {
        this._borrow = borrow;
        return this;
      }

      public SummaryBuilder WithAccruedInterest(string? accruedInterest)
      {
        this._accruedInterest = accruedInterest;
        return this;
      }

      public SummaryBuilder WithRollingDebt(string? rollingDebt)
      {
        this._rollingDebt = rollingDebt;
        return this;
      }

      public SummaryBuilder WithBalance(string? balance)
      {
        this._balance = balance;
        return this;
      }

      public SummaryBuilder WithBuyingPower(string? buyingPower)
      {
        this._buyingPower = buyingPower;
        return this;
      }

      public SummaryBuilder WithPortfolioInitialMargin(double? portfolioInitialMargin)
      {
        this._portfolioInitialMargin = portfolioInitialMargin;
        return this;
      }

      public SummaryBuilder WithPortfolioCurrentMargin(double? portfolioCurrentMargin)
      {
        this._portfolioCurrentMargin = portfolioCurrentMargin;
        return this;
      }

      public SummaryBuilder WithPortfolioMaintenanceMargin(double? portfolioMaintenanceMargin)
      {
        this._portfolioMaintenanceMargin = portfolioMaintenanceMargin;
        return this;
      }

      public SummaryBuilder WithPortfolioCloseOutMargin(double? portfolioCloseOutMargin)
      {
        this._portfolioCloseOutMargin = portfolioCloseOutMargin;
        return this;
      }

      public SummaryBuilder WithInLiquidation(bool? inLiquidation)
      {
        this._inLiquidation = inLiquidation;
        return this;
      }

      public SummaryBuilder WithPortfolioInitialMarginNotional(double? portfolioInitialMarginNotional)
      {
        this._portfolioInitialMarginNotional = portfolioInitialMarginNotional;
        return this;
      }

      public SummaryBuilder WithPortfolioCurrentMarginNotional(double? portfolioCurrentMarginNotional)
      {
        this._portfolioCurrentMarginNotional = portfolioCurrentMarginNotional;
        return this;
      }

      public SummaryBuilder WithPortfolioMaintenanceMarginNotional(double? portfolioMaintenanceMarginNotional)
      {
        this._portfolioMaintenanceMarginNotional = portfolioMaintenanceMarginNotional;
        return this;
      }

      public SummaryBuilder WithPortfolioCloseOutMarginNotional(double? portfolioCloseOutMarginNotional)
      {
        this._portfolioCloseOutMarginNotional = portfolioCloseOutMarginNotional;
        return this;
      }

      public SummaryBuilder WithMarginOverride(double? marginOverride)
      {
        this._marginOverride = marginOverride;
        return this;
      }

      public SummaryBuilder WithLockUpInitialMargin(double? lockUpInitialMargin)
      {
        this._lockUpInitialMargin = lockUpInitialMargin;
        return this;
      }

      public SummaryBuilder WithLoanCollateralRequirement(string? loanCollateralRequirement)
      {
        this._loanCollateralRequirement = loanCollateralRequirement;
        return this;
      }

      public SummaryBuilder WithPositionOffsetNotional(string? positionOffsetNotional)
      {
        this._positionOffsetNotional = positionOffsetNotional;
        return this;
      }

      public Summary Build()
      {
        return new Summary
        {
          Collateral = this._collateral,
          UnrealizedPnl = this._unrealizedPnl,
          UnrealizedPnlPercent = this._unrealizedPnlPercent,
          PositionNotional = this._positionNotional,
          OpenPositionNotional = this._openPositionNotional,
          PendingFees = this._pendingFees,
          Borrow = this._borrow,
          AccruedInterest = this._accruedInterest,
          RollingDebt = this._rollingDebt,
          Balance = this._balance,
          BuyingPower = this._buyingPower,
          PortfolioInitialMargin = this._portfolioInitialMargin,
          PortfolioCurrentMargin = this._portfolioCurrentMargin,
          PortfolioMaintenanceMargin = this._portfolioMaintenanceMargin,
          PortfolioCloseOutMargin = this._portfolioCloseOutMargin,
          InLiquidation = this._inLiquidation,
          PortfolioInitialMarginNotional = this._portfolioInitialMarginNotional,
          PortfolioCurrentMarginNotional = this._portfolioCurrentMarginNotional,
          PortfolioMaintenanceMarginNotional = this._portfolioMaintenanceMarginNotional,
          PortfolioCloseOutMarginNotional = this._portfolioCloseOutMarginNotional,
          MarginOverride = this._marginOverride,
          LockUpInitialMargin = this._lockUpInitialMargin,
          LoanCollateralRequirement = this._loanCollateralRequirement,
          PositionOffsetNotional = this._positionOffsetNotional
        };
      }
    }
  }
}
