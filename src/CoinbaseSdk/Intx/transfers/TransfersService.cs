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

namespace CoinbaseSdk.Intx.Transfers
{
  using System.Net;
  using CoinbaseSdk.Core.Client;
  using CoinbaseSdk.Core.Http;
  using CoinbaseSdk.Core.Service;

  public class TransfersService(ICoinbaseClient client) : CoinbaseService(client), ITransfersService
  {
    public CreateCounterpartyIdResponse CreateCounterpartyId(
      CreateCounterpartyIdRequest request,
      CallOptions? options = null)
    {
      return new CreateCounterpartyIdResponse()
      {
        Counterparty = this.Request<Counterparty>(
          HttpMethod.Post,
          $"/transfers/create-counterparty-id",
          [HttpStatusCode.Created, HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<CreateCounterpartyIdResponse> CreateCounterpartyIdAsync(
      CreateCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new CreateCounterpartyIdResponse()
      {
        Counterparty = await this.RequestAsync<Counterparty>(
          HttpMethod.Post,
          $"/transfers/create-counterparty-id",
          [HttpStatusCode.Created, HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public CreateCryptoAddressResponse CreateCryptoAddress(
      CreateCryptoAddressRequest request,
      CallOptions? options = null)
    {
      return new CreateCryptoAddressResponse()
      {
        CryptoAddress = this.Request<CryptoAddress>(
          HttpMethod.Post,
          $"/transfers/address",
          [HttpStatusCode.Created, HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<CreateCryptoAddressResponse> CreateCryptoAddressAsync(
      CreateCryptoAddressRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new CreateCryptoAddressResponse()
      {
        CryptoAddress = await this.RequestAsync<CryptoAddress>(
          HttpMethod.Post,
          $"/transfers/address",
          [HttpStatusCode.Created, HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public GetTransferResponse GetTransfer(
      GetTransferRequest request,
      CallOptions? options = null)
    {
      return new GetTransferResponse()
      {
        Transfer = this.Request<Transfer>(
          HttpMethod.Get,
          $"transfers/{request.TransferUUID}",
          [HttpStatusCode.OK],
          null,
          options)
      };
    }

    public async Task<GetTransferResponse> GetTransferAsync(
      GetTransferRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new GetTransferResponse()
      {
        Transfer = await this.RequestAsync<Transfer>(
          HttpMethod.Get,
          $"transfers/{request.TransferUUID}",
          [HttpStatusCode.OK],
          null,
          options,
          cancellationToken)
      };
    }

    public ListTransfersResponse ListMatchingTransfers(
      ListTransfersRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListTransfersResponse>(
        HttpMethod.Get,
        $"/transfers",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ListTransfersResponse> ListMatchingTransfersAsync(
      ListTransfersRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListTransfersResponse>(
        HttpMethod.Get,
        $"/transfers",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public ValidateCounterpartyIdResponse ValidateCounterpartyId(
      ValidateCounterpartyIdRequest request,
      CallOptions? options = null)
    {
      return this.Request<ValidateCounterpartyIdResponse>(
        HttpMethod.Post,
        $"/transfers/validate-counterparty-id",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ValidateCounterpartyIdResponse> ValidateCounterpartyIdAsync(
      ValidateCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ValidateCounterpartyIdResponse>(
        HttpMethod.Post,
        $"/transfers/validate-counterparty-id",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public WithdrawToCounterpartyIdResponse WithdrawToCounterpartyId(
      WithdrawToCounterpartyIdRequest request,
      CallOptions? options = null)
    {
      return this.Request<WithdrawToCounterpartyIdResponse>(
        HttpMethod.Post,
        $"/transfers/withdraw/counterparty",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<WithdrawToCounterpartyIdResponse> WithdrawToCounterpartyIdAsync(
      WithdrawToCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<WithdrawToCounterpartyIdResponse>(
        HttpMethod.Post,
        $"/transfers/withdraw/counterparty",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public WithdrawToCryptoAddressResponse WithdrawToCryptoAddress(
      WithdrawToCryptoAddressRequest request,
      CallOptions? options = null)
    {
      return this.Request<WithdrawToCryptoAddressResponse>(
        HttpMethod.Post,
        $"/transfers/withdraw",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<WithdrawToCryptoAddressResponse> WithdrawToCryptoAddressAsync(
      WithdrawToCryptoAddressRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<WithdrawToCryptoAddressResponse>(
        HttpMethod.Post,
        $"/transfers/withdraw",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }
  }
}
