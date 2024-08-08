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

namespace Coinbase.Intx.Transfers
{
  using System.Text.Json.Serialization;

  public class Transfer
  {
    [JsonPropertyName("transfer_uuid")]
    public string? TransferUUID { get; set; }

    [JsonPropertyName("transfer_type")]
    public TransferType? TransferType { get; set; }

    public string? Amount { get; set; }

    public string? Asset { get; set; }

    public TransferStatus? Status { get; set; }

    [JsonPropertyName("network_name")]
    public string? NetworkName { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

    [JsonPropertyName("from_portfolio")]
    public TransferPortfolio? FromPortfolio { get; set; }

    [JsonPropertyName("to_portfolio")]
    public TransferPortfolio? ToPortfolio { get; set; }

    [JsonPropertyName("from_address")]
    public string? FromAddress { get; set; }

    [JsonPropertyName("to_address")]
    public string? ToAddress { get; set; }

    [JsonPropertyName("from_cb_account")]
    public string? FromCbAccount { get; set; }

    [JsonPropertyName("to_cb_account")]
    public string? ToCbAccount { get; set; }

    [JsonPropertyName("from_counterparty_id")]
    public string? FromCounterpartyId { get; set; }

    [JsonPropertyName("to_counterparty_id")]
    public string? ToCounterpartyId { get; set; }

    [JsonPropertyName("instrument_id")]
    public string? InstrumentId { get; set; }

    [JsonPropertyName("position_id")]
    public string? PositionId { get; set; }


    public class TransferBuilder
    {
      private string? _transferUUID;
      private TransferType? _transferType;
      private string? _amount;
      private string? _asset;
      private TransferStatus? _status;
      private string? _networkName;
      private string? _createdAt;
      private string? _updatedAt;
      private TransferPortfolio? _fromPortfolio;
      private TransferPortfolio? _toPortfolio;
      private string? _fromAddress;
      private string? _toAddress;
      private string? _fromCbAccount;
      private string? _toCbAccount;
      private string? _fromCounterpartyId;
      private string? _toCounterpartyId;
      private string? _instrumentId;
      private string? _positionId;

      public TransferBuilder WithTransferUUID(string transferUUID)
      {
        this._transferUUID = transferUUID;
        return this;
      }

      public TransferBuilder WithTransferType(TransferType transferType)
      {
        this._transferType = transferType;
        return this;
      }

      public TransferBuilder WithAmount(string amount)
      {
        this._amount = amount;
        return this;
      }

      public TransferBuilder WithAsset(string asset)
      {
        this._asset = asset;
        return this;
      }

      public TransferBuilder WithStatus(TransferStatus status)
      {
        this._status = status;
        return this;
      }

      public TransferBuilder WithNetworkName(string networkName)
      {
        this._networkName = networkName;
        return this;
      }

      public TransferBuilder WithCreatedAt(string createdAt)
      {
        this._createdAt = createdAt;
        return this;
      }

      public TransferBuilder WithUpdatedAt(string updatedAt)
      {
        this._updatedAt = updatedAt;
        return this;
      }

      public TransferBuilder WithFromPortfolio(TransferPortfolio fromPortfolio)
      {
        this._fromPortfolio = fromPortfolio;
        return this;
      }

      public TransferBuilder WithToPortfolio(TransferPortfolio toPortfolio)
      {
        this._toPortfolio = toPortfolio;
        return this;
      }

      public TransferBuilder WithFromAddress(string fromAddress)
      {
        this._fromAddress = fromAddress;
        return this;
      }

      public TransferBuilder WithToAddress(string toAddress)
      {
        this._toAddress = toAddress;
        return this;
      }

      public TransferBuilder WithFromCbAccount(string fromCbAccount)
      {
        this._fromCbAccount = fromCbAccount;
        return this;
      }

      public TransferBuilder WithToCbAccount(string toCbAccount)
      {
        this._toCbAccount = toCbAccount;
        return this;
      }

      public TransferBuilder WithFromCounterpartyId(string fromCounterpartyId)
      {
        this._fromCounterpartyId = fromCounterpartyId;
        return this;
      }

      public TransferBuilder WithToCounterpartyId(string toCounterpartyId)
      {
        this._toCounterpartyId = toCounterpartyId;
        return this;
      }

      public TransferBuilder WithInstrumentId(string instrumentId)
      {
        this._instrumentId = instrumentId;
        return this;
      }

      public TransferBuilder WithPositionId(string positionId)
      {
        this._positionId = positionId;
        return this;
      }

      public Transfer Build()
      {
        return new Transfer
        {
          TransferUUID = this._transferUUID,
          TransferType = this._transferType,
          Amount = this._amount,
          Asset = this._asset,
          Status = this._status,
          NetworkName = this._networkName,
          CreatedAt = this._createdAt,
          UpdatedAt = this._updatedAt,
          FromPortfolio = this._fromPortfolio,
          ToPortfolio = this._toPortfolio,
          FromAddress = this._fromAddress,
          ToAddress = this._toAddress,
          FromCbAccount = this._fromCbAccount,
          ToCbAccount = this._toCbAccount,
          FromCounterpartyId = this._fromCounterpartyId,
          ToCounterpartyId = this._toCounterpartyId,
          InstrumentId = this._instrumentId,
          PositionId = this._positionId
        };
      }
    }
  }
}