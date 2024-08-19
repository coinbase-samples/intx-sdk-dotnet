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
  using CoinbaseSdk.Core.Error;

  public class GetSupportedNetworksRequest(string asset)
  {
    public string Asset { get; set; } = asset;

    public class GetSupportedNetworksRequestBuilder
    {
      private string? _asset;

      public GetSupportedNetworksRequestBuilder WithAsset(string asset)
      {
        this._asset = asset;
        return this;
      }

      /// <summary>
      /// Validates the request.
      /// </summary>
      /// <exception cref="CoinbaseClientException">If <see cref="_asset"/> is null, empty, or whitespace.</exception>
      private void Validate()
      {
        if (string.IsNullOrWhiteSpace(this._asset))
        {
          throw new CoinbaseClientException("Asset is required");
        }
      }

      /// <summary>
      /// Builds the <see cref="GetSupportedNetworksRequest"/>.
      /// </summary>
      /// <returns><see cref="GetSupportedNetworksRequest"/>.</returns>
      /// <exception cref="CoinbaseClientException">If <see cref="_asset"/> is null, empty, or whitespace.</exception>
      public GetSupportedNetworksRequest Build()
      {
        this.Validate();
        return new GetSupportedNetworksRequest(this._asset!);
      }
    }
  }
}
