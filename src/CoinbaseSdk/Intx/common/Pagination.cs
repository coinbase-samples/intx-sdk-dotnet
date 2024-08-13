/*
 * Copyright 2024-present Coinbase Global, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Text.Json.Serialization;

namespace CoinbaseSdk.Intx.Common
{
  public class Pagination
  {
    [JsonPropertyName("result_limit")]
    public int? ResultLimit { get; set; }

    [JsonPropertyName("result_offset")]
    public int? ResultOffset { get; set; }

    public class PaginationBuilder
    {
      private int? _resultLimit;
      private int? _resultOffset;

      public PaginationBuilder WithResultLimit(int resultLimit)
      {
        this._resultLimit = resultLimit;
        return this;
      }

      public PaginationBuilder WithResultOffset(int resultOffset)
      {
        this._resultOffset = resultOffset;
        return this;
      }

      public Pagination Build()
      {
        return new Pagination
        {
          ResultLimit = this._resultLimit,
          ResultOffset = this._resultOffset
        };
      }
    }
  }
}