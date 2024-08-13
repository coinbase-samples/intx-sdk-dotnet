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

## Usage

To use the _Coinbase INTX .NET SDK_, initialize the Credentials class and create a new client. The Credentials struct is JSON
enabled. Ensure that INTX API credentials are stored in a secure manner.

```c#
public class Main {
    static void Main()
    {
      string? value = Environment.GetEnvironmentVariable("COINBASE_INTX_CREDENTIALS");
      if (value == null)
      {
        Console.WriteLine("COINBASE_INTX_CREDENTIALS environment variable not set");
        return;
      }
      var credentials = new CoinbaseCredentials(value);
      var client = new CoinbaseIntxClient(credentials);
      var service = new PortfoliosService(client);
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

**Warning**: this does place a market order for a very small amount of ADA. Please ensure that you have the necessary funds in your account before running this code.

