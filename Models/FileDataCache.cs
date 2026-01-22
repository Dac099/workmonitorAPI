using System;
using System.Collections.Generic;

namespace workmonitorAPI.Models;

public partial class FileDataCache
{
    public int Id { get; set; }

    public string? RfqSys { get; set; }

    public string? PoStatus { get; set; }

    public string? LineStatus { get; set; }

    public DateOnly? OrderDate { get; set; }

    public string? OrderNumber { get; set; }

    public string? VendorCode { get; set; }

    public string? VendorName { get; set; }

    public string? Project { get; set; }

    public string? ItemCode { get; set; }

    public string? ManufacturerNumber { get; set; }

    public string? ItemDescription { get; set; }

    public string? PriceCurrency { get; set; }

    public decimal? UnitPrice { get; set; }

    public decimal? OrderedQuantity { get; set; }

    public decimal? TotalOrderAmountFc { get; set; }

    public decimal? TotalOrderAmount { get; set; }

    public DateOnly? PromisedDeliveryDate { get; set; }

    public DateOnly? ReceivedDate { get; set; }

    public string? ReceiptNumbers { get; set; }

    public decimal? ReceivedQuantity { get; set; }

    public decimal? TotalReceivedAmount { get; set; }

    public decimal? TotalReceivedAmountFc { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public string? InvoiceNumbers { get; set; }

    public decimal? InvoicedQuantity { get; set; }

    public decimal? TotalInvoicedAmount { get; set; }

    public decimal? TotalInvoicedAmountFc { get; set; }

    public decimal? PendingInvoiceQuantity { get; set; }

    public decimal? PendingInvoiceAmount { get; set; }

    public decimal? PendingInvoiceAmountFc { get; set; }

    public decimal? PendingReceiptQuantity { get; set; }

    public decimal? PendingReceiptAmount { get; set; }

    public decimal? PendingReceiptAmountFc { get; set; }

    public decimal? ReceivedPercentAmount { get; set; }

    public decimal? InvoicedPercentAmount { get; set; }

    public decimal? ReceivedPercentQuantity { get; set; }

    public decimal? InvoicedPercentQuantity { get; set; }

    public DateTime? UploadTimestamp { get; set; }

    public Guid? BatchId { get; set; }
}
