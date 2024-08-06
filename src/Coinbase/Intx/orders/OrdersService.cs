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

namespace Coinbase.Intx.Orders
{
  using System.Net;
  using Coinbase.Core.Client;
  using Coinbase.Core.Http;
  using Coinbase.Core.Service;

  public class OrdersService(ICoinbaseClient client) : CoinbaseService(client)
  {
    public CancelOrderResponse CancelOrder(
      CancelOrderRequest request,
      CallOptions? options = null)
    {
      return this.Request<CancelOrderResponse>(
        HttpMethod.Delete,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<CancelOrderResponse> CancelOrderAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<CancelOrderResponse>(
        HttpMethod.Delete,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public CancelOrdersResponse CancelOrders(
      CancelOrderRequest request,
      CallOptions? options = null)
    {
      return this.Request<CancelOrdersResponse>(
        HttpMethod.Delete,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<CancelOrdersResponse> CancelOrdersAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<CancelOrdersResponse>(
        HttpMethod.Delete,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public CreateOrderResponse CreateOrder(
      CreateOrderRequest request,
      CallOptions? options = null)
    {
      return this.Request<CreateOrderResponse>(
        HttpMethod.Post,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<CreateOrderResponse> CreateOrderAsync(
      CreateOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<CreateOrderResponse>(
        HttpMethod.Post,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public GetOrderResponse GetOrder(
      GetOrderRequest request,
      CallOptions? options = null)
    {
      return this.Request<GetOrderResponse>(
        HttpMethod.Get,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<GetOrderResponse> GetOrderAsync(
      GetOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<GetOrderResponse>(
        HttpMethod.Get,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public ModifyOrderResponse ModifyOpenOrder(
      ModifyOrderRequest request,
      CallOptions? options = null)
    {
      return this.Request<ModifyOrderResponse>(
        HttpMethod.Put,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ModifyOrderResponse> ModifyOpenOrderAsync(
      ModifyOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ModifyOrderResponse>(
        HttpMethod.Put,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }

    public ListOrdersResponse ListOpenOrders(
      ListOrdersRequest request,
      CallOptions? options = null)
    {
      return this.Request<ListOrdersResponse>(
        HttpMethod.Get,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options);
    }

    public Task<ListOrdersResponse> ListOpenOrdersAsync(
      ListOrdersRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return this.RequestAsync<ListOrdersResponse>(
        HttpMethod.Get,
        "/orders",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken);
    }
  }
}