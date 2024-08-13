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
  public class PortfolioDetails
  {
    public Summary? Summary { get; set; }
    public Balance[] Balances { get; set; } = [];
    public Position[] Positions { get; set; } = [];

    public PortfolioDetails()
    {
    }

    public class PortfolioDetailBuilder
    {
      private Summary? _summary;
      private Balance[] _balances = [];
      private Position[] _positions = [];

      public PortfolioDetailBuilder()
      {
      }

      public PortfolioDetailBuilder WithSummary(Summary summary)
      {
        this._summary = summary;
        return this;
      }

      public PortfolioDetailBuilder WithBalances(Balance[] balances)
      {
        this._balances = balances;
        return this;
      }

      public PortfolioDetailBuilder WithPositions(Position[] positions)
      {
        this._positions = positions;
        return this;
      }

      public PortfolioDetails Build()
      {
        return new PortfolioDetails
        {
          Summary = this._summary,
          Balances = this._balances,
          Positions = this._positions,
        };
      }
    }
  }
}