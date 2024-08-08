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


namespace Coinbase.Intx.Portfolios
{
  using System.Text.Json.Serialization;
  public class PatchPortfolioRequest(string portfolio)
  {
    public string Portfolio { get; set; } = portfolio;

    [JsonPropertyName("auto_margin_enabled")]
    public bool? AutoMarginEnabled { get; set; }

    [JsonPropertyName("cross_collateral_enabled")]
    public bool? CrossCollateralEnabled { get; set; }

    [JsonPropertyName("position_offsets_enabled")]
    public bool? PositionOffsetsEnabled { get; set; }

    [JsonPropertyName("portfolio_name")]
    public string? PortfolioName { get; set; }
  }
}