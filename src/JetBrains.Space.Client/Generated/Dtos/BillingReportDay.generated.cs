// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class BillingReportDay
     : IPropagatePropertyAccessPath
{
    public BillingReportDay() { }
    
    public BillingReportDay(DateTime date, int activeUsers, int userUsage, double userCost, long storageTotalUsage, long storageFilesUsage, long storageGitUsage, long storagePackagesUsage, double storageCost, long bandwidthTotalUsageDelta, long bandwidthTotalUsage, long bandwidthFilesUsageDelta, long bandwidthFilesUsage, long bandwidthGitUsageDelta, long bandwidthGitUsage, long bandwidthPackagesUsageDelta, long bandwidthPackagesUsage, long bandwidthAutomationExternalTrafficUsageDelta, long bandwidthAutomationExternalTrafficUsage, long bandwidthAutomationInternalUsageDelta, long bandwidthAutomationInternalUsage, double bandwidthCost, long ciUsageDelta, long ciUsage, double ciCost, long appUsage, long chatUsage, double totalCost, long? storageAllocationB = null)
    {
        Date = date;
        ActiveUsers = activeUsers;
        UserUsage = userUsage;
        UserCost = userCost;
        StorageAllocationB = storageAllocationB;
        StorageTotalUsage = storageTotalUsage;
        StorageFilesUsage = storageFilesUsage;
        StorageGitUsage = storageGitUsage;
        StoragePackagesUsage = storagePackagesUsage;
        StorageCost = storageCost;
        BandwidthTotalUsageDelta = bandwidthTotalUsageDelta;
        BandwidthTotalUsage = bandwidthTotalUsage;
        BandwidthFilesUsageDelta = bandwidthFilesUsageDelta;
        BandwidthFilesUsage = bandwidthFilesUsage;
        BandwidthGitUsageDelta = bandwidthGitUsageDelta;
        BandwidthGitUsage = bandwidthGitUsage;
        BandwidthPackagesUsageDelta = bandwidthPackagesUsageDelta;
        BandwidthPackagesUsage = bandwidthPackagesUsage;
        BandwidthAutomationExternalTrafficUsageDelta = bandwidthAutomationExternalTrafficUsageDelta;
        BandwidthAutomationExternalTrafficUsage = bandwidthAutomationExternalTrafficUsage;
        BandwidthAutomationInternalUsageDelta = bandwidthAutomationInternalUsageDelta;
        BandwidthAutomationInternalUsage = bandwidthAutomationInternalUsage;
        BandwidthCost = bandwidthCost;
        CiUsageDelta = ciUsageDelta;
        CiUsage = ciUsage;
        CiCost = ciCost;
        AppUsage = appUsage;
        ChatUsage = chatUsage;
        TotalCost = totalCost;
    }
    
    private PropertyValue<DateTime> _date = new PropertyValue<DateTime>(nameof(BillingReportDay), nameof(Date), "date");
    
    [Required]
    [JsonPropertyName("date")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime Date
    {
        get => _date.GetValue(InlineErrors);
        set => _date.SetValue(value);
    }

    private PropertyValue<int> _activeUsers = new PropertyValue<int>(nameof(BillingReportDay), nameof(ActiveUsers), "activeUsers");
    
    [Required]
    [JsonPropertyName("activeUsers")]
    public int ActiveUsers
    {
        get => _activeUsers.GetValue(InlineErrors);
        set => _activeUsers.SetValue(value);
    }

    private PropertyValue<int> _userUsage = new PropertyValue<int>(nameof(BillingReportDay), nameof(UserUsage), "userUsage");
    
    [Required]
    [JsonPropertyName("userUsage")]
    public int UserUsage
    {
        get => _userUsage.GetValue(InlineErrors);
        set => _userUsage.SetValue(value);
    }

    private PropertyValue<double> _userCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(UserCost), "userCost");
    
    [Required]
    [JsonPropertyName("userCost")]
    public double UserCost
    {
        get => _userCost.GetValue(InlineErrors);
        set => _userCost.SetValue(value);
    }

    private PropertyValue<long?> _storageAllocationB = new PropertyValue<long?>(nameof(BillingReportDay), nameof(StorageAllocationB), "storageAllocationB");
    
    [JsonPropertyName("storageAllocationB")]
    public long? StorageAllocationB
    {
        get => _storageAllocationB.GetValue(InlineErrors);
        set => _storageAllocationB.SetValue(value);
    }

    private PropertyValue<long> _storageTotalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageTotalUsage), "storageTotalUsage");
    
    [Required]
    [JsonPropertyName("storageTotalUsage")]
    public long StorageTotalUsage
    {
        get => _storageTotalUsage.GetValue(InlineErrors);
        set => _storageTotalUsage.SetValue(value);
    }

    private PropertyValue<long> _storageFilesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageFilesUsage), "storageFilesUsage");
    
    [Required]
    [JsonPropertyName("storageFilesUsage")]
    public long StorageFilesUsage
    {
        get => _storageFilesUsage.GetValue(InlineErrors);
        set => _storageFilesUsage.SetValue(value);
    }

    private PropertyValue<long> _storageGitUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StorageGitUsage), "storageGitUsage");
    
    [Required]
    [JsonPropertyName("storageGitUsage")]
    public long StorageGitUsage
    {
        get => _storageGitUsage.GetValue(InlineErrors);
        set => _storageGitUsage.SetValue(value);
    }

    private PropertyValue<long> _storagePackagesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(StoragePackagesUsage), "storagePackagesUsage");
    
    [Required]
    [JsonPropertyName("storagePackagesUsage")]
    public long StoragePackagesUsage
    {
        get => _storagePackagesUsage.GetValue(InlineErrors);
        set => _storagePackagesUsage.SetValue(value);
    }

    private PropertyValue<double> _storageCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(StorageCost), "storageCost");
    
    [Required]
    [JsonPropertyName("storageCost")]
    public double StorageCost
    {
        get => _storageCost.GetValue(InlineErrors);
        set => _storageCost.SetValue(value);
    }

    private PropertyValue<long> _bandwidthTotalUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthTotalUsageDelta), "bandwidthTotalUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthTotalUsageDelta")]
    public long BandwidthTotalUsageDelta
    {
        get => _bandwidthTotalUsageDelta.GetValue(InlineErrors);
        set => _bandwidthTotalUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthTotalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthTotalUsage), "bandwidthTotalUsage");
    
    [Required]
    [JsonPropertyName("bandwidthTotalUsage")]
    public long BandwidthTotalUsage
    {
        get => _bandwidthTotalUsage.GetValue(InlineErrors);
        set => _bandwidthTotalUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthFilesUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthFilesUsageDelta), "bandwidthFilesUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthFilesUsageDelta")]
    public long BandwidthFilesUsageDelta
    {
        get => _bandwidthFilesUsageDelta.GetValue(InlineErrors);
        set => _bandwidthFilesUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthFilesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthFilesUsage), "bandwidthFilesUsage");
    
    [Required]
    [JsonPropertyName("bandwidthFilesUsage")]
    public long BandwidthFilesUsage
    {
        get => _bandwidthFilesUsage.GetValue(InlineErrors);
        set => _bandwidthFilesUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthGitUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthGitUsageDelta), "bandwidthGitUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthGitUsageDelta")]
    public long BandwidthGitUsageDelta
    {
        get => _bandwidthGitUsageDelta.GetValue(InlineErrors);
        set => _bandwidthGitUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthGitUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthGitUsage), "bandwidthGitUsage");
    
    [Required]
    [JsonPropertyName("bandwidthGitUsage")]
    public long BandwidthGitUsage
    {
        get => _bandwidthGitUsage.GetValue(InlineErrors);
        set => _bandwidthGitUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthPackagesUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthPackagesUsageDelta), "bandwidthPackagesUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthPackagesUsageDelta")]
    public long BandwidthPackagesUsageDelta
    {
        get => _bandwidthPackagesUsageDelta.GetValue(InlineErrors);
        set => _bandwidthPackagesUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthPackagesUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthPackagesUsage), "bandwidthPackagesUsage");
    
    [Required]
    [JsonPropertyName("bandwidthPackagesUsage")]
    public long BandwidthPackagesUsage
    {
        get => _bandwidthPackagesUsage.GetValue(InlineErrors);
        set => _bandwidthPackagesUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationExternalTrafficUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationExternalTrafficUsageDelta), "bandwidthAutomationExternalTrafficUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthAutomationExternalTrafficUsageDelta")]
    public long BandwidthAutomationExternalTrafficUsageDelta
    {
        get => _bandwidthAutomationExternalTrafficUsageDelta.GetValue(InlineErrors);
        set => _bandwidthAutomationExternalTrafficUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationExternalTrafficUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationExternalTrafficUsage), "bandwidthAutomationExternalTrafficUsage");
    
    [Required]
    [JsonPropertyName("bandwidthAutomationExternalTrafficUsage")]
    public long BandwidthAutomationExternalTrafficUsage
    {
        get => _bandwidthAutomationExternalTrafficUsage.GetValue(InlineErrors);
        set => _bandwidthAutomationExternalTrafficUsage.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationInternalUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationInternalUsageDelta), "bandwidthAutomationInternalUsageDelta");
    
    [Required]
    [JsonPropertyName("bandwidthAutomationInternalUsageDelta")]
    public long BandwidthAutomationInternalUsageDelta
    {
        get => _bandwidthAutomationInternalUsageDelta.GetValue(InlineErrors);
        set => _bandwidthAutomationInternalUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _bandwidthAutomationInternalUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(BandwidthAutomationInternalUsage), "bandwidthAutomationInternalUsage");
    
    [Required]
    [JsonPropertyName("bandwidthAutomationInternalUsage")]
    public long BandwidthAutomationInternalUsage
    {
        get => _bandwidthAutomationInternalUsage.GetValue(InlineErrors);
        set => _bandwidthAutomationInternalUsage.SetValue(value);
    }

    private PropertyValue<double> _bandwidthCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(BandwidthCost), "bandwidthCost");
    
    [Required]
    [JsonPropertyName("bandwidthCost")]
    public double BandwidthCost
    {
        get => _bandwidthCost.GetValue(InlineErrors);
        set => _bandwidthCost.SetValue(value);
    }

    private PropertyValue<long> _ciUsageDelta = new PropertyValue<long>(nameof(BillingReportDay), nameof(CiUsageDelta), "ciUsageDelta");
    
    [Required]
    [JsonPropertyName("ciUsageDelta")]
    public long CiUsageDelta
    {
        get => _ciUsageDelta.GetValue(InlineErrors);
        set => _ciUsageDelta.SetValue(value);
    }

    private PropertyValue<long> _ciUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(CiUsage), "ciUsage");
    
    [Required]
    [JsonPropertyName("ciUsage")]
    public long CiUsage
    {
        get => _ciUsage.GetValue(InlineErrors);
        set => _ciUsage.SetValue(value);
    }

    private PropertyValue<double> _ciCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(CiCost), "ciCost");
    
    [Required]
    [JsonPropertyName("ciCost")]
    public double CiCost
    {
        get => _ciCost.GetValue(InlineErrors);
        set => _ciCost.SetValue(value);
    }

    private PropertyValue<long> _appUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(AppUsage), "appUsage");
    
    [Required]
    [JsonPropertyName("appUsage")]
    public long AppUsage
    {
        get => _appUsage.GetValue(InlineErrors);
        set => _appUsage.SetValue(value);
    }

    private PropertyValue<long> _chatUsage = new PropertyValue<long>(nameof(BillingReportDay), nameof(ChatUsage), "chatUsage");
    
    [Required]
    [JsonPropertyName("chatUsage")]
    public long ChatUsage
    {
        get => _chatUsage.GetValue(InlineErrors);
        set => _chatUsage.SetValue(value);
    }

    private PropertyValue<double> _totalCost = new PropertyValue<double>(nameof(BillingReportDay), nameof(TotalCost), "totalCost");
    
    [Required]
    [JsonPropertyName("totalCost")]
    public double TotalCost
    {
        get => _totalCost.GetValue(InlineErrors);
        set => _totalCost.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _date.SetAccessPath(parentChainPath, validateHasBeenSet);
        _activeUsers.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _userCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageAllocationB.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageTotalUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageFilesUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageGitUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storagePackagesUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _storageCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthTotalUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthTotalUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthFilesUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthFilesUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthGitUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthGitUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthPackagesUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthPackagesUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthAutomationExternalTrafficUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthAutomationExternalTrafficUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthAutomationInternalUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthAutomationInternalUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bandwidthCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ciUsageDelta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ciUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _ciCost.SetAccessPath(parentChainPath, validateHasBeenSet);
        _appUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _chatUsage.SetAccessPath(parentChainPath, validateHasBeenSet);
        _totalCost.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

