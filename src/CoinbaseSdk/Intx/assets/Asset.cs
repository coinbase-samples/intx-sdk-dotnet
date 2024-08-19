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

namespace CoinbaseSdk.Intx.Assets
{
  using System.Text.Json.Serialization;

  public class Asset
  {
    [JsonPropertyName("asset_id")]
    public string? AssetId { get; set; }

    [JsonPropertyName("asset_uuid")]
    public string? AssetUuid { get; set; }

    [JsonPropertyName("asset_name")]
    public string? AssetName { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }

    [JsonPropertyName("collateral_weight")]
    public double? CollateralWeight { get; set; }

    [JsonPropertyName("supported_networks_enabled")]
    public bool? SupportedNetworksEnabled { get; set; }

    [JsonPropertyName("min_borrow_qty")]
    public int? MinBorrowQty { get; set; }

    [JsonPropertyName("max_borrow_qty")]
    public int? MaxBorrowQty { get; set; }

    [JsonPropertyName("loan_collateral_requirement_multiplier")]
    public double? LoanCollateralRequirementMultiplier { get; set; }

    [JsonPropertyName("ecosystem_collateral_limit_breached")]
    public bool? EcosystemCollateralLimitBreached { get; set; }

    [JsonPropertyName("account_collateral_limit")]
    public string? AccountCollateralLimit { get; set; }

    public class AssetBuilder
    {
      private string? _assetId;
      private string? _assetUuid;
      private string? _assetName;
      private string? _status;
      private double? _collateralWeight;
      private bool? _supportedNetworksEnabled;
      private int? _minBorrowQty;
      private int? _maxBorrowQty;
      private double? _loanCollateralRequirementMultiplier;
      private bool? _ecosystemCollateralLimitBreached;
      private string? _accountCollateralLimit;

      public AssetBuilder WithAssetId(string assetId)
      {
        this._assetId = assetId;
        return this;
      }

      public AssetBuilder WithAssetUuid(string assetUuid)
      {
        this._assetUuid = assetUuid;
        return this;
      }

      public AssetBuilder WithAssetName(string assetName)
      {
        this._assetName = assetName;
        return this;
      }

      public AssetBuilder WithStatus(string status)
      {
        this._status = status;
        return this;
      }

      public AssetBuilder WithCollateralWeight(double collateralWeight)
      {
        this._collateralWeight = collateralWeight;
        return this;
      }

      public AssetBuilder WithSupportedNetworksEnabled(bool supportedNetworksEnabled)
      {
        this._supportedNetworksEnabled = supportedNetworksEnabled;
        return this;
      }

      public AssetBuilder WithMinBorrowQty(int minBorrowQty)
      {
        this._minBorrowQty = minBorrowQty;
        return this;
      }

      public AssetBuilder WithMaxBorrowQty(int maxBorrowQty)
      {
        this._maxBorrowQty = maxBorrowQty;
        return this;
      }

      public AssetBuilder WithLoanCollateralRequirementMultiplier(double loanCollateralRequirementMultiplier)
      {
        this._loanCollateralRequirementMultiplier = loanCollateralRequirementMultiplier;
        return this;
      }

      public AssetBuilder WithEcosystemCollateralLimitBreached(bool ecosystemCollateralLimitBreached)
      {
        this._ecosystemCollateralLimitBreached = ecosystemCollateralLimitBreached;
        return this;
      }

      public AssetBuilder WithAccountCollateralLimit(string accountCollateralLimit)
      {
        this._accountCollateralLimit = accountCollateralLimit;
        return this;
      }

      public Asset Build()
      {
        return new Asset
        {
          AssetId = this._assetId,
          AssetUuid = this._assetUuid,
          AssetName = this._assetName,
          Status = this._status,
          CollateralWeight = this._collateralWeight,
          SupportedNetworksEnabled = this._supportedNetworksEnabled,
          MinBorrowQty = this._minBorrowQty,
          MaxBorrowQty = this._maxBorrowQty,
          LoanCollateralRequirementMultiplier = this._loanCollateralRequirementMultiplier,
          EcosystemCollateralLimitBreached = this._ecosystemCollateralLimitBreached,
          AccountCollateralLimit = this._accountCollateralLimit
        };
      }
    }
  }
}
