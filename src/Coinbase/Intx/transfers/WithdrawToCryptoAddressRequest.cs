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

namespace Coinbase.Intx.Transfers
{
  using System.Text.Json.Serialization;
  public class WithdrawToCryptoAddressRequest
  {
    public string? Portfolio { get; set; }

    public string? Asset { get; set; }

    public string? Amount { get; set; }

    [JsonPropertyName("add_network_fee_to_total")]
    public bool? AddNetworkFeeToTotal { get; set; }

    [JsonPropertyName("network_arn_id")]
    public string? NetworkArnId { get; set; }

    public string? Address { get; set; }

    public int? Nonce { get; set; }

    public class WithdrawToCryptoAddressRequestBuilder
    {
      private string? _portfolio;
      private string? _asset;
      private string? _amount;
      private bool? _addNetworkFeeToTotal;
      private string? _networkArnId;
      private string? _address;
      private int? _nonce;

      public WithdrawToCryptoAddressRequestBuilder WithPortfolio(string portfolio)
      {
        this._portfolio = portfolio;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithAsset(string asset)
      {
        this._asset = asset;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithAmount(string amount)
      {
        this._amount = amount;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithAddNetworkFeeToTotal(bool addNetworkFeeToTotal)
      {
        this._addNetworkFeeToTotal = addNetworkFeeToTotal;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithNetworkArnId(string networkArnId)
      {
        this._networkArnId = networkArnId;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithAddress(string address)
      {
        this._address = address;
        return this;
      }

      public WithdrawToCryptoAddressRequestBuilder WithNonce(int nonce)
      {
        this._nonce = nonce;
        return this;
      }

      public WithdrawToCryptoAddressRequest Build()
      {
        return new WithdrawToCryptoAddressRequest
        {
          Portfolio = this._portfolio,
          Asset = this._asset,
          Amount = this._amount,
          AddNetworkFeeToTotal = this._addNetworkFeeToTotal,
          NetworkArnId = this._networkArnId,
          Address = this._address,
          Nonce = this._nonce
        };
      }
    }
  }
}