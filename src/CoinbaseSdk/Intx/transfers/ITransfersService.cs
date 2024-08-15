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
  using CoinbaseSdk.Core.Http;

  public interface ITransfersService
  {
    public CreateCounterpartyIdResponse CreateCounterpartyId(
      CreateCounterpartyIdRequest request,
      CallOptions? options = null);

    public Task<CreateCounterpartyIdResponse> CreateCounterpartyIdAsync(
      CreateCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public CreateCryptoAddressResponse CreateCryptoAddress(
      CreateCryptoAddressRequest request,
      CallOptions? options = null);

    public Task<CreateCryptoAddressResponse> CreateCryptoAddressAsync(
      CreateCryptoAddressRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetTransferResponse GetTransfer(
      GetTransferRequest request,
      CallOptions? options = null);

    public Task<GetTransferResponse> GetTransferAsync(
      GetTransferRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListTransfersResponse ListMatchingTransfers(
      ListTransfersRequest request,
      CallOptions? options = null);

    public Task<ListTransfersResponse> ListMatchingTransfersAsync(
      ListTransfersRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ValidateCounterpartyIdResponse ValidateCounterpartyId(
      ValidateCounterpartyIdRequest request,
      CallOptions? options = null);

    public Task<ValidateCounterpartyIdResponse> ValidateCounterpartyIdAsync(
      ValidateCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public WithdrawToCounterpartyIdResponse WithdrawToCounterpartyId(
      WithdrawToCounterpartyIdRequest request,
      CallOptions? options = null);

    public Task<WithdrawToCounterpartyIdResponse> WithdrawToCounterpartyIdAsync(
      WithdrawToCounterpartyIdRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public WithdrawToCryptoAddressResponse WithdrawToCryptoAddress(
      WithdrawToCryptoAddressRequest request,
      CallOptions? options = null);

    public Task<WithdrawToCryptoAddressResponse> WithdrawToCryptoAddressAsync(
      WithdrawToCryptoAddressRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);
  }
}
