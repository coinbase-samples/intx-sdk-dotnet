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

namespace CoinbaseSdk.Intx.Assets
{
  public class GetSupportedNetworksResponse
  {
    public SupportedNetwork[] Networks = [];

    public class GetSupportedNetworksResponseBuilder
    {
      private SupportedNetwork[] _networks = [];

      public GetSupportedNetworksResponseBuilder WithNetworks(SupportedNetwork[] networks)
      {
        this._networks = networks;
        return this;
      }

      public GetSupportedNetworksResponse Build()
      {
        return new GetSupportedNetworksResponse
        {
          Networks = this._networks
        };
      }
    }
  }
}