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

namespace Coinbase.IntxExample.Example
{
  using System.Text.Json;
  using Coinbase.Core.Credentials;
  using Coinbase.Intx.Client;
  using Coinbase.Intx.Portfolios;

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

      var credentials = JsonSerializer.Deserialize<CoinbaseCredentials>(credentialsBlob);

      var client = new CoinbaseIntxClient(credentials!);

      var portfolioService = new PortfoliosService(client);


    }
  }
}