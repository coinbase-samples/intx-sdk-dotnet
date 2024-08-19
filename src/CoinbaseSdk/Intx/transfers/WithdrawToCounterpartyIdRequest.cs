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

namespace CoinbaseSdk.Intx.Transfers
{
  using System.Text.Json.Serialization;
  public class WithdrawToCounterpartyIdRequest
  {
    public string? Portfolio { get; set; }

    [JsonPropertyName("counterparty_id")]
    public string? CounterpartyId { get; set; }

    public string? Asset { get; set; }

    public string? Amount { get; set; }

    public string? Nonce { get; set; }

    public class WithdrawToCounterpartyIdRequestBuilder
    {
      private string? _portfolio;
      private string? _counterpartyId;
      private string? _asset;
      private string? _amount;
      private string? _nonce;

      public WithdrawToCounterpartyIdRequestBuilder WithPortfolio(string portfolio)
      {
        this._portfolio = portfolio;
        return this;
      }

      public WithdrawToCounterpartyIdRequestBuilder WithCounterpartyId(string counterpartyId)
      {
        this._counterpartyId = counterpartyId;
        return this;
      }

      public WithdrawToCounterpartyIdRequestBuilder WithAsset(string asset)
      {
        this._asset = asset;
        return this;
      }

      public WithdrawToCounterpartyIdRequestBuilder WithAmount(string amount)
      {
        this._amount = amount;
        return this;
      }

      public WithdrawToCounterpartyIdRequestBuilder WithNonce(string nonce)
      {
        this._nonce = nonce;
        return this;
      }

      public WithdrawToCounterpartyIdRequest Build()
      {
        return new WithdrawToCounterpartyIdRequest
        {
          Portfolio = this._portfolio,
          CounterpartyId = this._counterpartyId,
          Asset = this._asset,
          Amount = this._amount,
          Nonce = this._nonce
        };
      }
    }
  }
}