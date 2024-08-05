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

namespace Coinbase.Intx.Assets
{
  using Coinbase.Core.Error;
  public class GetAssetRequest(string assetId)
  {
    public string AssetId { get; set; } = assetId;

    public class GetAssetRequestBuilder
    {
      private string? _assetId;

      public GetAssetRequestBuilder WithAssetId(string assetId)
      {
        this._assetId = assetId;
        return this;
      }

      private void Validate()
      {
        if (string.IsNullOrWhiteSpace(this._assetId))
        {
          throw new CoinbaseClientException("Asset ID is required");
        }
      }

      public GetAssetRequest Build()
      {
        this.Validate();
        return new GetAssetRequest(this._assetId!);
      }
    }
  }
}
