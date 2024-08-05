/*
 * Copyright 2024-present Coinbase Global, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Coinbase.Intx.FeeRates
{
  using System.Net;
  using Coinbase.Core.Client;
  using Coinbase.Core.Http;
  using Coinbase.Core.Service;
  public class FeeRatesService(ICoinbaseClient client) : CoinbaseService(client)
  {
    public ListFeeRateTiersResponse ListFeeRates(CallOptions? options = null)
    {
      return this.Request<ListFeeRateTiersResponse>(
        HttpMethod.Get,
        $"/fee-rate-tiers",
        [HttpStatusCode.OK],
        null,
        options);
    }

    public Task<ListFeeRateTiersResponse> ListFeeRatesAsync(
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListFeeRateTiersResponse>(
        HttpMethod.Get,
        $"/fee-rate-tiers",
        [HttpStatusCode.OK],
        null,
        options,
        cancellationToken);
    }
  }
}