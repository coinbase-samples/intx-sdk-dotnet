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
  using System.Net;
  using CoinbaseSdk.Core.Client;
  using CoinbaseSdk.Core.Http;
  using CoinbaseSdk.Core.Service;

  public class OrdersService(ICoinbaseClient client) : CoinbaseService(client), IOrdersService
  {
    public CancelOrderResponse CancelOrder(
      CancelOrderRequest request,
      CallOptions? options = null)
    {
      return new CancelOrderResponse()
      {
        Order = this.Request<Order>(
          HttpMethod.Delete,
          $"/orders/{request.Id}",
          [HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<CancelOrderResponse> CancelOrderAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new CancelOrderResponse()
      {
        Order = await this.RequestAsync<Order>(
          HttpMethod.Delete,
          $"/orders/{request.Id}",
          [HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public CancelOrdersResponse CancelOrders(
      CancelOrderRequest request,
      CallOptions? options = null)
    {
      return new CancelOrdersResponse()
      {
        Results = this.Request<Order[]>(
          HttpMethod.Delete,
          "/orders",
          [HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<CancelOrdersResponse> CancelOrdersAsync(
      CancelOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new CancelOrdersResponse()
      {
        Results = await this.RequestAsync<Order[]>(
          HttpMethod.Delete,
          "/orders",
          [HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public CreateOrderResponse CreateOrder(
      CreateOrderRequest request,
      CallOptions? options = null)
    {
      return new CreateOrderResponse()
      {
        Order = this.Request<Order>(
          HttpMethod.Post,
          "/orders",
          [HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<CreateOrderResponse> CreateOrderAsync(
      CreateOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new CreateOrderResponse()
      {
        Order = await this.RequestAsync<Order>(
          HttpMethod.Post,
          "/orders",
          [HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public GetOrderResponse GetOrder(
      GetOrderRequest request,
      CallOptions? options = null)
    {
      return new GetOrderResponse()
      {
        Order = this.Request<Order>(
          HttpMethod.Get,
          $"/orders/{request.Id}",
          [HttpStatusCode.OK],
          request,
          options)
      };
    }

    public async Task<GetOrderResponse> GetOrderAsync(
      GetOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new GetOrderResponse()
      {
        Order = await this.RequestAsync<Order>(
          HttpMethod.Get,
          $"/orders/{request.Id}",
          [HttpStatusCode.OK],
          request,
          options,
          cancellationToken)
      };
    }

    public ModifyOrderResponse ModifyOpenOrder(
      ModifyOrderRequest request,
      CallOptions? options = null)
    {
      return new ModifyOrderResponse()
      {
        Order = this.Request<Order>(
        HttpMethod.Put,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options)
      };
    }

    public async Task<ModifyOrderResponse> ModifyOpenOrderAsync(
      ModifyOrderRequest request,
      CallOptions? options = null,
      CancellationToken cancellationToken = default)
    {
      return new ModifyOrderResponse()
      {
        Order = await this.RequestAsync<Order>(
        HttpMethod.Put,
        $"/orders/{request.Id}",
        [HttpStatusCode.OK],
        request,
        options,
        cancellationToken)
      };
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
