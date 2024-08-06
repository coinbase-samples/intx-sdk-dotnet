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


namespace Coinbase.Intx.Instruments
{
  using System.Net;
  using Coinbase.Core.Client;
  using Coinbase.Core.Http;
  using Coinbase.Core.Service;

  public class InstrumentsService(ICoinbaseClient client) : CoinbaseService(client)
  {
    public GetAggregatedCandlesResponse GetAggregatedCandles(
      GetAggregatedCandlesRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetAggregatedCandlesResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/candles",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<GetAggregatedCandlesResponse> GetAggregatedCandlesAsync(
      GetAggregatedCandlesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetAggregatedCandlesResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/candles",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public GetDailyTradingVolumesResponse GetDailyTradingVolumes(
      GetDailyTradingVolumesRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetDailyTradingVolumesResponse>(
        HttpMethod.Get,
        "/instruments/volumes/daily",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<GetDailyTradingVolumesResponse> GetDailyTradingVolumesAsync(
      GetDailyTradingVolumesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetDailyTradingVolumesResponse>(
        HttpMethod.Get,
        "/instruments/volumes/daily",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public GetHistoricalFundingRatesResponse GetHistoricalFundingRates(
      GetHistoricalFundingRatesRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetHistoricalFundingRatesResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/funding",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<GetHistoricalFundingRatesResponse> GetHistoricalFundingRatesAsync(
      GetHistoricalFundingRatesRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetHistoricalFundingRatesResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/funding",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public GetInstrumentQuoteResponse GetInstrumentQuote(
      GetInstrumentQuoteRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetInstrumentQuoteResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/quote",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetInstrumentQuoteResponse> GetInstrumentQuoteAsync(
      GetInstrumentQuoteRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetInstrumentQuoteResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}/quote",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public GetInstrumentResponse GetInstrument(
      GetInstrumentRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetInstrumentResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<GetInstrumentResponse> GetInstrumentAsync(
      GetInstrumentRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetInstrumentResponse>(
        HttpMethod.Get,
        $"/instruments/{request.Instrument}",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }

    public ListInstrumentsResponse ListInstruments(CallOptions? options = null)
    {
      return this.Request<ListInstrumentsResponse>(
        HttpMethod.Get,
        "/instruments",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<ListInstrumentsResponse> ListInstrumentsAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListInstrumentsResponse>(
        HttpMethod.Get,
        "/instruments",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }
  }
}