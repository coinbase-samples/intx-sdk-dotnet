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
  public class Balance
  {
    [JsonPropertyName("asset_id")]
    public string? AssetId { get; set; }

    [JsonPropertyName("asset_name")]
    public string? AssetName { get; set; }

    [JsonPropertyName("asset_uuid")]
    public string? AssetUuid { get; set; }

    public string? Quantity { get; set; }

    [JsonPropertyName("hold")]
    public string? Hold { get; set; }

    [JsonPropertyName("hold_available_for_collateral")]
    public string? HoldAvailableForCollateral { get; set; }

    [JsonPropertyName("transfer_hold")]
    public string? TransferHold { get; set; }

    [JsonPropertyName("collateral_value")]
    public string? CollateralValue { get; set; }

    [JsonPropertyName("max_withdraw_amount")]
    public string? MaxWithdrawAmount { get; set; }

    public string? Loan { get; set; }

    [JsonPropertyName("loan_collateral_requirement")]
    public string? LoanCollateralRequirement { get; set; }

    [JsonPropertyName("pledged_collateral_quantity")]
    public string? PledgedCollateralQuantity { get; set; }

    public Balance() { }

    public class BalanceBuilder
    {
      public string? _assetId;
      public string? _assetName;
      public string? _assetUuid;
      public string? _quantity;
      public string? _hold;
      public string? _holdAvailableForCollateral;
      public string? _transferHold;
      public string? _collateralValue;
      public string? _maxWithdrawAmount;
      public string? _loan;
      public string? _loanCollateralRequirement;
      public string? _pledgedCollateralQuantity;

      public BalanceBuilder() { }

      public BalanceBuilder WithAssetId(
          string? assetId)
      {
        this._assetId = assetId;
        return this;
      }

      public BalanceBuilder WithAssetName(
          string? assetName)
      {
        this._assetName = assetName;
        return this;
      }

      public BalanceBuilder WithAssetUuid(
          string? assetUuid)
      {
        this._assetUuid = assetUuid;
        return this;
      }

      public BalanceBuilder WithQuantity(
          string? quantity)
      {
        this._quantity = quantity;
        return this;
      }

      public BalanceBuilder WithHold(
          string? hold)
      {
        this._hold = hold;
        return this;
      }

      public BalanceBuilder WithHoldAvailableForCollateral(
          string? holdAvailableForCollateral)
      {
        this._holdAvailableForCollateral = holdAvailableForCollateral;
        return this;
      }

      public BalanceBuilder WithTransferHold(
          string? transferHold)
      {
        this._transferHold = transferHold;
        return this;
      }

      public BalanceBuilder WithCollateralValue(
          string? collateralValue)
      {
        this._collateralValue = collateralValue;
        return this;
      }

      public BalanceBuilder WithMaxWithdrawAmount(
          string? maxWithdrawAmount)
      {
        this._maxWithdrawAmount = maxWithdrawAmount;
        return this;
      }

      public BalanceBuilder WithLoan(
          string? loan)
      {
        this._loan = loan;
        return this;
      }

      public BalanceBuilder WithLoanCollateralRequirement(
          string? loanCollateralRequirement)
      {
        this._loanCollateralRequirement = loanCollateralRequirement;
        return this;
      }

      public BalanceBuilder WithPledgedCollateralQuantity(
          string? pledgedCollateralQuantity)
      {
        this._pledgedCollateralQuantity = pledgedCollateralQuantity;
        return this;
      }

      public Balance Build()
      {
        return new Balance()
        {
          AssetId = this._assetId,
          AssetName = this._assetName,
          AssetUuid = this._assetUuid,
          Quantity = this._quantity,
          Hold = this._hold,
          HoldAvailableForCollateral = this._holdAvailableForCollateral,
          TransferHold = this._transferHold,
          CollateralValue = this._collateralValue,
          MaxWithdrawAmount = this._maxWithdrawAmount,
          Loan = this._loan,
          LoanCollateralRequirement = this._loanCollateralRequirement,
          PledgedCollateralQuantity = this._pledgedCollateralQuantity
        };
      }
    }
  }
}
