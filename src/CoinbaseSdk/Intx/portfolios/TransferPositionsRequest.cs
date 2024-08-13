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

namespace CoinbaseSdk.Intx.Portfolios
{
  using CoinbaseSdk.Intx.Orders;
  public class TransferPositionsRequest(
    string from,
    string to,
    string instrument,
    string quantity,
    OrderSide side)
  {
    public string From { get; set; } = from;
    public string To { get; set; } = to;
    public string Instrument { get; set; } = instrument;
    public string Quantity { get; set; } = quantity;
    public OrderSide Side { get; set; } = side;
  }
}