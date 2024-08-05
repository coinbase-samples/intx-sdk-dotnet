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
  using System.Net;
  using Coinbase.Core.Client;
  using Coinbase.Core.Http;
  using Coinbase.Core.Service;
  public class AssetsService(ICoinbaseClient client) : CoinbaseService(client)
  {
    public GetAssetResponse GetAsset(
      GetAssetRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetAssetResponse>(
        HttpMethod.Get,
        $"/assets/{request.AssetId}",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetAssetResponse> GetAssetAsync(
      GetAssetRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetAssetResponse>(
        HttpMethod.Get,
        $"/assets/{request.AssetId}",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public ListAssetsResponse ListAssets(
      CallOptions? options = null)
    {
      return this.Request<ListAssetsResponse>(
        HttpMethod.Get,
        $"/assets",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<ListAssetsResponse> ListAssetsAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListAssetsResponse>(
        HttpMethod.Get,
        $"/assets",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public GetSupportedNetworksResponse GetSupportedNetworks(
      GetSupportedNetworksRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetSupportedNetworksResponse>(
        HttpMethod.Get,
        $"/assets/{request.Asset}/networks",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetSupportedNetworksResponse> GetSupportedNetworksAsync(
      GetSupportedNetworksRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetSupportedNetworksResponse>(
        HttpMethod.Get,
        $"/assets/{request.Asset}/networks",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }
  }
}