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

namespace CoinbaseSdk.IntxExample.Example
{
  using System.Text.Json;
  using CoinbaseSdk.Core.Credentials;
  using CoinbaseSdk.Core.Error;
  using CoinbaseSdk.Intx.Client;
  using CoinbaseSdk.Intx.Instruments;
  using CoinbaseSdk.Intx.Portfolios;

  class Example
  {
    static void Main()
    {
      string? credentialsBlob = Environment.GetEnvironmentVariable("COINBASE_INTX_CREDENTIALS");
      if (credentialsBlob == null)
      {
        Console.WriteLine("COINBASE_INTX_CREDENTIALS environment variable not set");
        return;
      }

      var credentials = JsonSerializer.Deserialize<CoinbaseCredentials>(credentialsBlob, new JsonSerializerOptions(JsonSerializerDefaults.Web));
      var client = new CoinbaseIntxClient(credentials!, "api-n5e1.coinbase.com/api/v1");

      var portfolioService = new PortfoliosService(client);

      try {
        ListPortfoliosResponse listPortfoliosResponse = portfolioService.ListPortfolios();
        foreach (Portfolio portfolio in listPortfoliosResponse.Portfolios)
        {
          Console.WriteLine($"Portfolio ID: {portfolio.PortfolioId}");
          Console.WriteLine($"Portfolio UUID: {portfolio.PortfolioUuid}");
          Console.WriteLine($"Portfolio Name: {portfolio.Name}");
          Console.WriteLine();
        }

        var instrumentsService = new InstrumentsService(client);
        var historicalFundingRates = instrumentsService.GetHistoricalFundingRates(new GetHistoricalFundingRatesRequest
        {
          Instrument = "BTC-PERP",
        });

        foreach (HistoricalFundingRate fundingRate in historicalFundingRates.Results)
        {
          Console.WriteLine($"Funding Rate: {fundingRate.FundingRate}");
          Console.WriteLine($"Event Time: {fundingRate.EventTime}");
          Console.WriteLine();
        }

      }
      catch (CoinbaseException e)
      {
        Console.WriteLine($"Error: {e.ToString()}");
        return;
      }
    }
  }
}
