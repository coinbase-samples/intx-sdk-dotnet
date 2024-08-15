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

namespace CoinbaseSdk.Intx.Orders
{
  using CoinbaseSdk.Core.Http;

  public interface IOrdersService
  {
    public CancelOrderResponse CancelOrder(
      CancelOrderRequest request,
      CallOptions? options = null);

    public Task<CancelOrderResponse> CancelOrderAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public CancelOrdersResponse CancelOrders(
      CancelOrderRequest request,
      CallOptions? options = null);

    public Task<CancelOrdersResponse> CancelOrdersAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public CreateOrderResponse CreateOrder(
      CreateOrderRequest request,
      CallOptions? options = null);

    public Task<CreateOrderResponse> CreateOrderAsync(
      CreateOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public GetOrderResponse GetOrder(
      GetOrderRequest request,
      CallOptions? options = null);

    public Task<GetOrderResponse> GetOrderAsync(
      GetOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ModifyOrderResponse ModifyOpenOrder(
      ModifyOrderRequest request,
      CallOptions? options = null);

    public Task<ModifyOrderResponse> ModifyOpenOrderAsync(
      ModifyOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);

    public ListOrdersResponse ListOpenOrders(
      ListOrdersRequest request,
      CallOptions? options = null);

    public Task<ListOrdersResponse> ListOpenOrdersAsync(
      ListOrdersRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default);
  }
}
