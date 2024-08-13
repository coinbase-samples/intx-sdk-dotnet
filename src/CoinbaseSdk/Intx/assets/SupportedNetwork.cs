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

namespace CoinbaseSdk.Intx.Assets
{
  public class SupportedNetwork
  {
    [JsonPropertyName("asset_id")]
    public string? AssetId { get; set; }

    [JsonPropertyName("asset_uuid")]
    public string? AssetUuid { get; set; }

    [JsonPropertyName("asset_name")]
    public string? AssetName { get; set; }

    [JsonPropertyName("network_arn_id")]
    public string? NetworkArnId { get; set; }

    [JsonPropertyName("min_withdrawal_amt")]
    public double? MinWithdrawalAmt { get; set; }

    [JsonPropertyName("max_withdrawal_amt")]
    public double? MaxWithdrawalAmt { get; set; }

    [JsonPropertyName("network_confirms")]
    public int? NetworkConfirms { get; set; }

    [JsonPropertyName("processing_time")]
    public int? ProcessingTime { get; set; }

    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("network_name")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }

    public SupportedNetwork() { }

    public class SupportedNetworksBuilder
    {
      private string? _assetId;
      private string? _assetUuid;
      private string? _assetName;
      private string? _networkArnId;
      private double? _minWithdrawalAmt;
      private double? _maxWithdrawalAmt;
      private int? _networkConfirms;
      private int? _processingTime;
      private bool? _isDefault;
      private string? _networkName;
      private string? _displayName;

      public SupportedNetworksBuilder WithAssetId(string assetId)
      {
        this._assetId = assetId;
        return this;
      }

      public SupportedNetworksBuilder WithAssetUuid(string assetUuid)
      {
        this._assetUuid = assetUuid;
        return this;
      }

      public SupportedNetworksBuilder WithAssetName(string assetName)
      {
        this._assetName = assetName;
        return this;
      }

      public SupportedNetworksBuilder WithNetworkArnId(string networkArnId)
      {
        this._networkArnId = networkArnId;
        return this;
      }

      public SupportedNetworksBuilder WithMinWithdrawalAmt(double minWithdrawalAmt)
      {
        this._minWithdrawalAmt = minWithdrawalAmt;
        return this;
      }

      public SupportedNetworksBuilder WithMaxWithdrawalAmt(double maxWithdrawalAmt)
      {
        this._maxWithdrawalAmt = maxWithdrawalAmt;
        return this;
      }

      public SupportedNetworksBuilder WithNetworkConfirms(int networkConfirms)
      {
        this._networkConfirms = networkConfirms;
        return this;
      }

      public SupportedNetworksBuilder WithProcessingTime(int processingTime)
      {
        this._processingTime = processingTime;
        return this;
      }

      public SupportedNetworksBuilder WithIsDefault(bool isDefault)
      {
        this._isDefault = isDefault;
        return this;
      }

      public SupportedNetworksBuilder WithNetworkName(string networkName)
      {
        this._networkName = networkName;
        return this;
      }

      public SupportedNetworksBuilder WithDisplayName(string displayName)
      {
        this._displayName = displayName;
        return this;
      }

      public SupportedNetwork Build()
      {
        return new SupportedNetwork
        {
          AssetId = this._assetId,
          AssetUuid = this._assetUuid,
          AssetName = this._assetName,
          NetworkArnId = this._networkArnId,
          MinWithdrawalAmt = this._minWithdrawalAmt,
          MaxWithdrawalAmt = this._maxWithdrawalAmt,
          NetworkConfirms = this._networkConfirms,
          ProcessingTime = this._processingTime,
          IsDefault = this._isDefault,
          NetworkName = this._networkName,
          DisplayName = this._displayName
        };
      }
    }
  }
}
