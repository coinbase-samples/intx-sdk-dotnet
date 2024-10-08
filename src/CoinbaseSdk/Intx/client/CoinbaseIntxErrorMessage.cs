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

namespace CoinbaseSdk.Intx.Client
{
  using System.Net;
  using CoinbaseSdk.Core.Error;

  public class CoinbaseIntxErrorMessage : ICoinbaseErrorMessage
  {
    required public string Title { get; set; }

    required public HttpStatusCode Status { get; set; }

    required public string Error { get; set; }

    public CoinbaseIntxErrorMessage(string title, HttpStatusCode statusCode, string error)
    {
      this.Title = title;
      this.Status = statusCode;
      this.Error = error;
    }

    public CoinbaseIntxErrorMessage()
    {
    }

    public CoinbaseException CreateCoinbaseException()
    {
      return new CoinbaseException(this.Status, this.Title);
    }
  }
}
