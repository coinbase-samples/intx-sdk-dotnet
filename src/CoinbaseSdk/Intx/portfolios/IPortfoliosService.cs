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
  using CoinbaseSdk.Core.Http;

  public interface IPortfoliosService
  {
    public CreatePortfolioResponse CreatePortfolio(
      CreatePortfolioRequest request,
      CallOptions? options = null);

    public Task<CreatePortfolioResponse> CreatePortfolioAsync(
      CreatePortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public EnableDisableAutoMarginResponse EnableDisableAutoMarginMode(
      EnableDisableAutoMarginRequest request,
      CallOptions? options = null);

    public Task<EnableDisableAutoMarginResponse> EnableDisableAutoMarginModeAsync(
      EnableDisableAutoMarginRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public EnableDisableCrossCollateralResponse EnableDisablePortfolioCrossCollateral(
      EnableDisableCrossCollateralRequest request,
      CallOptions? options = null);

    public Task<EnableDisableCrossCollateralResponse> EnableDisablePortfolioCrossCollateralAsync(
      EnableDisableCrossCollateralRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetBalanceForPortfolioAssetResponse GetBalanceForPortfolioAsset(
      GetBalanceForPortfolioAssetRequest request,
      CallOptions? options = null);

    public Task<GetBalanceForPortfolioAssetResponse> GetBalanceForPortfolioAssetAsync(
      GetBalanceForPortfolioAssetRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetPortfolioDetailsResponse GetPortfolioDetails(
      GetPortfolioDetailsRequest request,
      CallOptions? options = null);

    public Task<GetPortfolioDetailsResponse> GetPortfolioDetailsAsync(
      GetPortfolioDetailsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetPortfolioResponse GetPortfolio(
      GetPortfolioRequest request,
      CallOptions? options = null);

    public Task<GetPortfolioResponse> GetPortfolioAsync(
      GetPortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetPortfolioSummaryResponse GetPortfolioSummary(
      GetPortfolioSummaryRequest request,
      CallOptions? options = null);

    public Task<GetPortfolioSummaryResponse> GetPortfolioSummaryAsync(
      GetPortfolioSummaryRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetPositionForPortfolioInstrumentResponse GetPositionForPortfolioInstrument(
      GetPositionForPortfolioInstrumentRequest request,
      CallOptions? options = null);

    public Task<GetPositionForPortfolioInstrumentResponse> GetPositionForPortfolioInstrumentAsync(
      GetPositionForPortfolioInstrumentRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListFillsByPortfoliosResponse ListFillsByPortfolios(
      ListFillsByPortfoliosRequest request,
      CallOptions? options = null);

    public Task<ListFillsByPortfoliosResponse> ListFillsByPortfoliosAsync(
      ListFillsByPortfoliosRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListPortfolioBalancesResponse ListPortfolioBalances(
      ListPortfolioBalancesRequest request,
      CallOptions? options = null);

    public Task<ListPortfolioBalancesResponse> ListPortfolioBalancesAsync(
      ListPortfolioBalancesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListPortfolioFillsResponse ListPortfolios(
      ListPortfolioFillsRequest request,
      CallOptions? options = null);

    public Task<ListPortfolioFillsResponse> ListPortfoliosAsync(
      ListPortfolioFillsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListPortfolioPositionsResponse ListPortfolioPositions(
      ListPortfolioPositionsRequest request,
      CallOptions? options = null);

    public Task<ListPortfolioPositionsResponse> ListPortfolioPositionsAsync(
      ListPortfolioPositionsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListPortfoliosResponse ListPortfolios(CallOptions? options = null);

    public Task<ListPortfoliosResponse> ListPortfoliosAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public PatchPortfolioResponse PatchPortfolio(
      PatchPortfolioRequest request,
      CallOptions? options = null);

    public Task<PatchPortfolioResponse> PatchPortfolioAsync(
      PatchPortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public SetPortfolioMarginOverrideResponse SetPortfolioMarginOverride(
      SetPortfolioMarginOverrideRequest request,
      CallOptions? options = null);

    public Task<SetPortfolioMarginOverrideResponse> SetPortfolioMarginOverrideAsync(
      SetPortfolioMarginOverrideRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public TransferFundsResponse TransferFundsBetweenPortfolios(
      TransferFundsRequest request,
      CallOptions? options = null);

    public Task<TransferFundsResponse> TransferFundsBetweenPortfoliosAsync(
      TransferFundsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public TransferPositionsResponse TransferPositionsBetweenPortfolios(
      TransferPositionsRequest request,
      CallOptions? options = null);

    public Task<TransferPositionsResponse> TransferPositionsBetweenPortfoliosAsync(
      TransferPositionsRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public UpdatePortfolioResponse UpdatePortfolio(
      UpdatePortfolioRequest request,
      CallOptions? options = null);

    public Task<UpdatePortfolioResponse> UpdatePortfolioAsync(
      UpdatePortfolioRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);
  }
}
