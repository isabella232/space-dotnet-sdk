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

public class CalendarsMeetingsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public CalendarsMeetingsForIdPatchRequest() { }
    
    public CalendarsMeetingsForIdPatchRequest(Diff locationsDiff, Diff profilesDiff, Diff externalParticipantsDiff, Diff teamsDiff, bool notifyOnExport = true, RecurrentModification modificationKind = RecurrentModification.All, string? summary = null, string? description = null, CalendarEventSpec? occurrenceRule = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, string? organizer = null, DateTime? targetDate = null, EventConferenceData? conferenceData = null, List<MeetingAttachment>? attachments = null)
    {
        Summary = summary;
        Description = description;
        OccurrenceRule = occurrenceRule;
        LocationsDiff = locationsDiff;
        ProfilesDiff = profilesDiff;
        ExternalParticipantsDiff = externalParticipantsDiff;
        TeamsDiff = teamsDiff;
        Visibility = visibility;
        ModificationPreference = modificationPreference;
        JoiningPreference = joiningPreference;
        IsNotifyOnExport = notifyOnExport;
        Organizer = organizer;
        TargetDate = targetDate;
        ModificationKind = modificationKind;
        ConferenceData = conferenceData;
        Attachments = attachments;
    }
    
    private PropertyValue<string?> _summary = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Summary), "summary");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("summary")]
    public string? Summary
    {
        get => _summary.GetValue(InlineErrors);
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<CalendarEventSpec?> _occurrenceRule = new PropertyValue<CalendarEventSpec?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(OccurrenceRule), "occurrenceRule");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("occurrenceRule")]
    public CalendarEventSpec? OccurrenceRule
    {
        get => _occurrenceRule.GetValue(InlineErrors);
        set => _occurrenceRule.SetValue(value);
    }

    private PropertyValue<Diff> _locationsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(LocationsDiff), "locationsDiff");
    
    [JsonPropertyName("locationsDiff")]
    public Diff LocationsDiff
    {
        get => _locationsDiff.GetValue(InlineErrors);
        set => _locationsDiff.SetValue(value);
    }

    private PropertyValue<Diff> _profilesDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ProfilesDiff), "profilesDiff");
    
    [JsonPropertyName("profilesDiff")]
    public Diff ProfilesDiff
    {
        get => _profilesDiff.GetValue(InlineErrors);
        set => _profilesDiff.SetValue(value);
    }

    private PropertyValue<Diff> _externalParticipantsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ExternalParticipantsDiff), "externalParticipantsDiff");
    
    [JsonPropertyName("externalParticipantsDiff")]
    public Diff ExternalParticipantsDiff
    {
        get => _externalParticipantsDiff.GetValue(InlineErrors);
        set => _externalParticipantsDiff.SetValue(value);
    }

    private PropertyValue<Diff> _teamsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(TeamsDiff), "teamsDiff");
    
    [JsonPropertyName("teamsDiff")]
    public Diff TeamsDiff
    {
        get => _teamsDiff.GetValue(InlineErrors);
        set => _teamsDiff.SetValue(value);
    }

    private PropertyValue<MeetingVisibility?> _visibility = new PropertyValue<MeetingVisibility?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Visibility), "visibility");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("visibility")]
    public MeetingVisibility? Visibility
    {
        get => _visibility.GetValue(InlineErrors);
        set => _visibility.SetValue(value);
    }

    private PropertyValue<MeetingModificationPreference?> _modificationPreference = new PropertyValue<MeetingModificationPreference?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ModificationPreference), "modificationPreference");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("modificationPreference")]
    public MeetingModificationPreference? ModificationPreference
    {
        get => _modificationPreference.GetValue(InlineErrors);
        set => _modificationPreference.SetValue(value);
    }

    private PropertyValue<MeetingJoiningPreference?> _joiningPreference = new PropertyValue<MeetingJoiningPreference?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(JoiningPreference), "joiningPreference");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("joiningPreference")]
    public MeetingJoiningPreference? JoiningPreference
    {
        get => _joiningPreference.GetValue(InlineErrors);
        set => _joiningPreference.SetValue(value);
    }

    private PropertyValue<bool> _notifyOnExport = new PropertyValue<bool>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(IsNotifyOnExport), "notifyOnExport");
    
    [JsonPropertyName("notifyOnExport")]
    public bool IsNotifyOnExport
    {
        get => _notifyOnExport.GetValue(InlineErrors);
        set => _notifyOnExport.SetValue(value);
    }

    private PropertyValue<string?> _organizer = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Organizer), "organizer");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("organizer")]
    public string? Organizer
    {
        get => _organizer.GetValue(InlineErrors);
        set => _organizer.SetValue(value);
    }

    private PropertyValue<DateTime?> _targetDate = new PropertyValue<DateTime?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(TargetDate), "targetDate");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("targetDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? TargetDate
    {
        get => _targetDate.GetValue(InlineErrors);
        set => _targetDate.SetValue(value);
    }

    private PropertyValue<RecurrentModification> _modificationKind = new PropertyValue<RecurrentModification>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ModificationKind), "modificationKind", RecurrentModification.All);
    
    [JsonPropertyName("modificationKind")]
    public RecurrentModification ModificationKind
    {
        get => _modificationKind.GetValue(InlineErrors);
        set => _modificationKind.SetValue(value);
    }

    private PropertyValue<EventConferenceData?> _conferenceData = new PropertyValue<EventConferenceData?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ConferenceData), "conferenceData");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("conferenceData")]
    public EventConferenceData? ConferenceData
    {
        get => _conferenceData.GetValue(InlineErrors);
        set => _conferenceData.SetValue(value);
    }

    private PropertyValue<List<MeetingAttachment>?> _attachments = new PropertyValue<List<MeetingAttachment>?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Attachments), "attachments");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("attachments")]
    public List<MeetingAttachment>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _summary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _occurrenceRule.SetAccessPath(parentChainPath, validateHasBeenSet);
        _locationsDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _profilesDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalParticipantsDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teamsDiff.SetAccessPath(parentChainPath, validateHasBeenSet);
        _visibility.SetAccessPath(parentChainPath, validateHasBeenSet);
        _modificationPreference.SetAccessPath(parentChainPath, validateHasBeenSet);
        _joiningPreference.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notifyOnExport.SetAccessPath(parentChainPath, validateHasBeenSet);
        _organizer.SetAccessPath(parentChainPath, validateHasBeenSet);
        _targetDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _modificationKind.SetAccessPath(parentChainPath, validateHasBeenSet);
        _conferenceData.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

