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
  using System.Net;
  using CoinbaseSdk.Core.Client;
  using CoinbaseSdk.Core.Http;
  using CoinbaseSdk.Core.Service;

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
        options);
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
        options);
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
        options);
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

    public GetPortfolioDetailsResponse GetPortfolioDetails(
      GetPortfolioDetailsRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetPortfolioDetailsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/detail",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetPortfolioDetailsResponse> GetPortfolioDetailsAsync(
      GetPortfolioDetailsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetPortfolioDetailsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/detail",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public GetPortfolioResponse GetPortfolio(
      GetPortfolioRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetPortfolioResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.PortfolioId}",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetPortfolioResponse> GetPortfolioAsync(
      GetPortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetPortfolioResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.PortfolioId}",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public GetPortfolioSummaryResponse GetPortfolioSummary(
      GetPortfolioSummaryRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetPortfolioSummaryResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/summary",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetPortfolioSummaryResponse> GetPortfolioSummaryAsync(
      GetPortfolioSummaryRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetPortfolioSummaryResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/summary",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public GetPositionForPortfolioInstrumentResponse GetPositionForPortfolioInstrument(
      GetPositionForPortfolioInstrumentRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetPositionForPortfolioInstrumentResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/positions/{request.Instrument}",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetPositionForPortfolioInstrumentResponse> GetPositionForPortfolioInstrumentAsync(
      GetPositionForPortfolioInstrumentRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetPositionForPortfolioInstrumentResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/positions/{request.Instrument}",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public ListFillsByPortfoliosResponse ListFillsByPortfolios(
      ListFillsByPortfoliosRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListFillsByPortfoliosResponse>(
        HttpMethod.Get,
        $"/portfolios/fills",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ListFillsByPortfoliosResponse> ListFillsByPortfoliosAsync(
      ListFillsByPortfoliosRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListFillsByPortfoliosResponse>(
        HttpMethod.Get,
        $"/portfolios/fills",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public ListPortfolioBalancesResponse ListPortfolioBalances(
      ListPortfolioBalancesRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListPortfolioBalancesResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/balances",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<ListPortfolioBalancesResponse> ListPortfolioBalancesAsync(
      ListPortfolioBalancesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListPortfolioBalancesResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/balances",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public ListPortfolioFillsResponse ListPortfolios(
      ListPortfolioFillsRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListPortfolioFillsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/fills",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ListPortfolioFillsResponse> ListPortfoliosAsync(
      ListPortfolioFillsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListPortfolioFillsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/fills",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public ListPortfolioPositionsResponse ListPortfolioPositions(
      ListPortfolioPositionsRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListPortfolioPositionsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/positions",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<ListPortfolioPositionsResponse> ListPortfolioPositionsAsync(
      ListPortfolioPositionsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListPortfolioPositionsResponse>(
        HttpMethod.Get,
        $"/portfolios/{request.Portfolio}/positions",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public ListPortfoliosResponse ListPortfolios(CallOptions? options = null)
    {
      return new ListPortfoliosResponse()
      {
        Portfolios = this.Request<Portfolio[]>(
        HttpMethod.Get,
        "/portfolios",
        [HttpStatusCode.OK],
        null,
        options)
      };
    }

    public async Task<ListPortfoliosResponse> ListPortfoliosAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new ListPortfoliosResponse()
      {
        Portfolios = await this.RequestAsync<Portfolio[]>(
        HttpMethod.Get,
        "/portfolios",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken)
      };
    }

    public PatchPortfolioResponse PatchPortfolio(
      PatchPortfolioRequest request,
      CallOptions? options = null)
    {
      return this.Request<PatchPortfolioResponse>(
        HttpMethod.Patch,
        $"/portfolios/{request.Portfolio}",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<PatchPortfolioResponse> PatchPortfolioAsync(
      PatchPortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<PatchPortfolioResponse>(
        HttpMethod.Patch,
        $"/portfolios/{request.Portfolio}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public SetPortfolioMarginOverrideResponse SetPortfolioMarginOverride(
      SetPortfolioMarginOverrideRequest request,
      CallOptions? options = null)
    {
      return this.Request<SetPortfolioMarginOverrideResponse>(
        HttpMethod.Post,
        $"/portfolios/margin",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<SetPortfolioMarginOverrideResponse> SetPortfolioMarginOverrideAsync(
      SetPortfolioMarginOverrideRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<SetPortfolioMarginOverrideResponse>(
        HttpMethod.Post,
        $"/portfolios/margin",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public TransferFundsResponse TransferFundsBetweenPortfolios(
      TransferFundsRequest request,
      CallOptions? options = null)
    {
      return this.Request<TransferFundsResponse>(
        HttpMethod.Post,
        $"/portfolios/transfer",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<TransferFundsResponse> TransferFundsBetweenPortfoliosAsync(
      TransferFundsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<TransferFundsResponse>(
        HttpMethod.Post,
        $"/portfolios/transfer",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public TransferPositionsResponse TransferPositionsBetweenPortfolios(
      TransferPositionsRequest request,
      CallOptions? options = null)
    {
      return this.Request<TransferPositionsResponse>(
        HttpMethod.Post,
        $"/portfolios/transfer-position",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<TransferPositionsResponse> TransferPositionsBetweenPortfoliosAsync(
      TransferPositionsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<TransferPositionsResponse>(
        HttpMethod.Post,
        $"/portfolios/transfer-position",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public UpdatePortfolioResponse UpdatePortfolio(
      UpdatePortfolioRequest request,
      CallOptions? options = null)
    {
      return this.Request<UpdatePortfolioResponse>(
        HttpMethod.Put,
        $"/portfolios/{request.Portfolio}",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<UpdatePortfolioResponse> UpdatePortfolioAsync(
      UpdatePortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<UpdatePortfolioResponse>(
        HttpMethod.Put,
        $"/portfolios/{request.Portfolio}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }
  }
}
