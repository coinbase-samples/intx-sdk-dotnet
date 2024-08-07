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

namespace Coinbase.Intx.Portfolios
{
  using System.Net;
  using Coinbase.Core.Client;
  using Coinbase.Core.Http;
  using Coinbase.Core.Service;

  public class PortfoliosService(ICoinbaseClient client) : CoinbaseService(client)
  {
    public CreatePortfolioResponse CreatePortfolio(
      CreatePortfolioRequest request,
      CallOptions? options = null)
    {
      return this.Request<CreatePortfolioResponse>(
        HttpMethod.Post,
        "/portfolios",
        [HttpStatusCode.Created, HttpStatusCode.OK],
        request,
        options
      );
    }

    public Task<CreatePortfolioResponse> CreatePortfolioAsync(
      CreatePortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<CreatePortfolioResponse>(
        HttpMethod.Post,
        "/portfolios",
        [HttpStatusCode.Created, HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public EnableDisableAutoMarginResponse EnableDisableAutoMarginMode(
      EnableDisableAutoMarginRequest request,
      CallOptions? options = null)
    {
      return this.Request<EnableDisableAutoMarginResponse>(
        HttpMethod.Post,
        $"/portfolios/{request.Portfolio}/auto-margin-enabled",
        [HttpStatusCode.OK],
        request,
        options
      );
    }

    public Task<EnableDisableAutoMarginResponse> EnableDisableAutoMarginModeAsync(
      EnableDisableAutoMarginRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<EnableDisableAutoMarginResponse>(
        HttpMethod.Post,
        $"/portfolios/{request.Portfolio}/auto-margin-enabled",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public EnableDisableCrossCollateralResponse EnableDisablePortfolioCrossCollateral(
      EnableDisableCrossCollateralRequest request,
      CallOptions? options = null)
    {
      return this.Request<EnableDisableCrossCollateralResponse>(
        HttpMethod.Post,
        $"/portfolios/{request.Portfolio}/cross-collateral-enabled",
        [HttpStatusCode.OK],
        request,
        options
      );
    }

    public Task<EnableDisableCrossCollateralResponse> EnableDisablePortfolioCrossCollateralAsync(
      EnableDisableCrossCollateralRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<EnableDisableCrossCollateralResponse>(
        HttpMethod.Post,
        $"/portfolios/{request.Portfolio}/cross-collateral-enabled",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public GetBalanceForPortfolioAssetResponse GetBalanceForPortfolioAsset(
      GetBalanceForPortfolioAssetRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetBalanceForPortfolioAssetResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/balances/{request.Asset}",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetBalanceForPortfolioAssetResponse> GetBalanceForPortfolioAssetAsync(
      GetBalanceForPortfolioAssetRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetBalanceForPortfolioAssetResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/balances/{request.Asset}",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }
  }
}