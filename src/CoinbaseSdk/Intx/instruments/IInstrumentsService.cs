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


namespace CoinbaseSdk.Intx.Instruments
{
  using CoinbaseSdk.Core.Http;

  public interface IInstrumentsService
  {
    public GetAggregatedCandlesResponse GetAggregatedCandlesDataPerInstrument(
      GetAggregatedCandlesRequest request,
      CallOptions? options = null);

    public Task<GetAggregatedCandlesResponse> GetAggregatedCandlesDataPerInstrumentAsync(
      GetAggregatedCandlesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetDailyTradingVolumesResponse GetDailyTradingVolumes(
      GetDailyTradingVolumesRequest request,
      CallOptions? options = null);

    public Task<GetDailyTradingVolumesResponse> GetDailyTradingVolumesAsync(
      GetDailyTradingVolumesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetHistoricalFundingRatesResponse GetHistoricalFundingRates(
      GetHistoricalFundingRatesRequest request,
      CallOptions? options = null);

    public Task<GetHistoricalFundingRatesResponse> GetHistoricalFundingRatesAsync(
      GetHistoricalFundingRatesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetInstrumentQuoteResponse GetQuotePerInstrument(
      GetInstrumentQuoteRequest request,
      CallOptions? options = null);

    public Task<GetInstrumentQuoteResponse> GetQuotePerInstrumentAsync(
      GetInstrumentQuoteRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetInstrumentResponse GetInstrument(
      GetInstrumentRequest request,
      CallOptions? options = null);

    public Task<GetInstrumentResponse> GetInstrumentAsync(
      GetInstrumentRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListInstrumentsResponse ListInstruments(CallOptions? options = null);

    public Task<ListInstrumentsResponse> ListInstrumentsAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default);
  }
}
