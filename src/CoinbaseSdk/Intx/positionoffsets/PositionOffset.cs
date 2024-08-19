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

namespace CoinbaseSdk.Intx.PositionOffsets
{
  using System.Text.Json.Serialization;
  public class PositionOffset
  {
    [JsonPropertyName("primary_instrument_id")]
    public string? PrimaryInstrumentId { get; set; }

    [JsonPropertyName("secondary_instrument_id")]
    public string? SecondaryInstrumentId { get; set; }

    public string? Offset { get; set; }
  }
}