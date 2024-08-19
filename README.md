# Coinbase International Exchange (INTX) .NET SDK

## Overview
The *INTX .NET SDK* is a sample library that demonstrates the structure of a
[Coinbase International Exchange (INTX)](https://international.coinbase.com/)
driver for the [REST APIs](https://docs.cloud.coinbase.com/intx/reference).

It is compatible with the .NET Standard 2.0 and .NET Core 3.1 frameworks. It
is tested and targeted .NET 5.0+ but is intended for .NET 8.0+.

## License
The *INTX .NET SDK* is a free and open source sample library released under the
[Apache License, Version 2.0](LICENSE).

The application and code are only available for demonstration purposes.

## Installation

The _Coinbase INTX .NET SDK_ is vended through [NuGet](https://www.nuget.org/packages/CoinbaseSdk.Intx//) and available for installation via the `dotnet` CLI.

```bash
dotnet add package CoinbaseSdk.Intx --version x.y.z
```

or if using [paket](https://fsprojects.github.io/Paket/):

```bash
paket add CoinbaseSdk.Intx --version x.y.z
```

## Usage

To use the _Coinbase INTX .NET SDK_, initialize the Credentials class and create a new client. The Credentials struct is JSON
enabled. Ensure that INTX API credentials are stored in a secure manner.

```c#
  using CoinbaseSdk.Core.Credentials;
  using CoinbaseSdk.Core.Error;
  using CoinbaseSdk.Core.Serialization;
  using CoinbaseSdk.Intx.Client;
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
      }
      catch (CoinbaseException e)
      {
        Console.WriteLine($"Error: {e.ToString()}");
        return;
      }
    }
  }
}
```

The JSON format expected for `COINBASE_INTX_CREDENTIALS` is:

```
{
  "accessKey": "",
  "passphrase": "",
  "signingKey": ""
}
```

For an example of how to use the client, see the [`Example`](src/CoinbaseSdk/IntxExample/example/Example.cs) class under the CoinbaseSdk.IntxExample.Example namespace.

**Warning**: this does place a limit order for a very small amount of ETH-USDC. Please ensure that you have the necessary funds in your account before running this code. If you do have the necessary funds, you may need to track the order incase network errors result in an inability to automatically cancel the order.

