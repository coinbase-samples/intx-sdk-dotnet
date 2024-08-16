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
  using CoinbaseSdk.Core.Credentials;
  using CoinbaseSdk.Core.Error;
  using CoinbaseSdk.Core.Serialization;
  using CoinbaseSdk.Intx.Client;
  using CoinbaseSdk.Intx.FeeRates;
  using CoinbaseSdk.Intx.Instruments;
  using CoinbaseSdk.Intx.Portfolios;

  class Example
  {
    static async Task Main()
    {
      string? credentialsBlob = Environment.GetEnvironmentVariable("COINBASE_INTX_CREDENTIALS");
      if (credentialsBlob == null)
      {
        Console.WriteLine("COINBASE_INTX_CREDENTIALS environment variable not set");
        return;
      }

      var serializer = new JsonUtility();

      var credentials = serializer.Deserialize<CoinbaseCredentials>(credentialsBlob);
      var client = new CoinbaseIntxClient(credentials!, "api-n5e1.coinbase.com/api/v1");

      var portfolioService = new PortfoliosService(client);

      try {
        ListPortfoliosResponse listPortfoliosResponse = portfolioService.ListPortfolios();
        foreach (Portfolio portfolio in listPortfoliosResponse.Portfolios)
        {
          Console.WriteLine($"Portfolio: {serializer.Serialize(portfolio.PortfolioId)}");
        }

        GetPortfolioDetailsResponse detailsResponse = portfolioService.GetPortfolioDetails(new GetPortfolioDetailsRequest(listPortfoliosResponse.Portfolios[0].PortfolioId!));

        Console.WriteLine($"Portfolio Details: {serializer.Serialize(detailsResponse)}");

        var instrumentsService = new InstrumentsService(client);
        var historicalFundingRates = instrumentsService.GetHistoricalFundingRates(new GetHistoricalFundingRatesRequest
        {
          Instrument = "BTC-PERP",
        });

        foreach (HistoricalFundingRate fundingRate in historicalFundingRates.Results)
        {
          Console.WriteLine($"Funding Rate: {serializer.Serialize(fundingRate.FundingRate)}");
        }

        var getDailyTradingVolumesResponse = instrumentsService.GetDailyTradingVolumes(new GetDailyTradingVolumesRequest
        {
          Instruments = "BTC-PERP",
          TimeFrom = DateTimeOffset.Parse("2024-08-15T00:00:00Z"),
        });

        foreach (InstrumentDailyTradingVolumes.Result dailyTradingVolume in getDailyTradingVolumesResponse.Results)
        {
          Console.WriteLine($"Daily Trading: {serializer.Serialize(dailyTradingVolume)}");
        }

        var feeRatesService = new FeeRatesService(client);

        ListFeeRateTiersResponse listFeeRateTiersResponse = await feeRatesService.ListFeeRateTiersAsync();

        foreach (FeeRate feeRate in listFeeRateTiersResponse.Results)
        {
          Console.WriteLine($"FeeRate: {serializer.Serialize(feeRate)}");
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
