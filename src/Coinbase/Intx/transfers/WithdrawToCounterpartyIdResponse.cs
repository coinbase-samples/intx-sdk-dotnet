/*
 * Copyright 2024-present Coinbase Global, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License") { get; set; }
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

namespace Coinbase.Intx.Transfers
{
  using System.Text.Json.Serialization;
  public class WithdrawToCounterpartyIdResponse
  {
    [JsonPropertyName("idem")]
    public string? Idem { get; set; }

    [JsonPropertyName("portfolio_uuid")]
    public string? PortfolioUuid { get; set; }

    [JsonPropertyName("source_counterparty_id")]
    public string? SourceCounterpartyId { get; set; }

    [JsonPropertyName("target_counterparty_id")]
    public string? TargetCounterpartyId { get; set; }

    [JsonPropertyName("asset")]
    public string? Asset { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }
  }
}