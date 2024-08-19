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

namespace CoinbaseSdk.Intx.Instruments
{
  using System.Text.Json.Serialization;

  public class Quote
  {
    [JsonPropertyName("best_bid_price")]
    public string? BestBidPrice { get; set; }

    [JsonPropertyName("best_bid_size")]
    public string? BestBidSize { get; set; }

    [JsonPropertyName("best_ask_price")]
    public string? BestAskPrice { get; set; }

    [JsonPropertyName("best_ask_size")]
    public string? BestAskSize { get; set; }

    [JsonPropertyName("trade_price")]
    public string? TradePrice { get; set; }

    [JsonPropertyName("trade_qty")]
    public string? TradeQty { get; set; }

    [JsonPropertyName("index_price")]
    public string? IndexPrice { get; set; }

    [JsonPropertyName("mark_price")]
    public string? MarkPrice { get; set; }

    [JsonPropertyName("settlement_price")]
    public string? SettlementPrice { get; set; }

    [JsonPropertyName("limit_up")]
    public string? LimitUp { get; set; }

    [JsonPropertyName("limit_down")]
    public string? LimitDown { get; set; }

    [JsonPropertyName("predicted_funding")]
    public string? PredictedFunding { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; set; }

    public Quote() { }
  }
}
