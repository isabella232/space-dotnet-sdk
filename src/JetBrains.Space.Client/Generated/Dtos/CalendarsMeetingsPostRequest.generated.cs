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

public class CalendarsMeetingsPostRequest
     : IPropagatePropertyAccessPath
{
    public CalendarsMeetingsPostRequest() { }
    
    public CalendarsMeetingsPostRequest(string summary, CalendarEventSpec occurrenceRule, List<string>? locations = null, List<string>? profiles = null, List<string>? externalParticipants = null, List<string>? teams = null, MeetingVisibility visibility = MeetingVisibility.EVERYONE, MeetingModificationPreference modificationPreference = MeetingModificationPreference.PARTICIPANTS, MeetingJoiningPreference joiningPreference = MeetingJoiningPreference.NOBODY, bool notifyOnExport = true, string? description = null, string? organizer = null, EventConferenceData? conferenceData = null, List<MeetingAttachment>? attachments = null)
    {
        Summary = summary;
        Description = description;
        OccurrenceRule = occurrenceRule;
        Locations = (locations ?? new List<string>());
        Profiles = (profiles ?? new List<string>());
        ExternalParticipants = (externalParticipants ?? new List<string>());
        Teams = (teams ?? new List<string>());
        Visibility = visibility;
        ModificationPreference = modificationPreference;
        JoiningPreference = joiningPreference;
        IsNotifyOnExport = notifyOnExport;
        Organizer = organizer;
        ConferenceData = conferenceData;
        Attachments = attachments;
    }
    
    private PropertyValue<string> _summary = new PropertyValue<string>(nameof(CalendarsMeetingsPostRequest), nameof(Summary), "summary");
    
    [Required]
    [JsonPropertyName("summary")]
    public string Summary
    {
        get => _summary.GetValue(InlineErrors);
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CalendarsMeetingsPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<CalendarEventSpec> _occurrenceRule = new PropertyValue<CalendarEventSpec>(nameof(CalendarsMeetingsPostRequest), nameof(OccurrenceRule), "occurrenceRule");
    
    [Required]
    [JsonPropertyName("occurrenceRule")]
    public CalendarEventSpec OccurrenceRule
    {
        get => _occurrenceRule.GetValue(InlineErrors);
        set => _occurrenceRule.SetValue(value);
    }

    private PropertyValue<List<string>> _locations = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Locations), "locations", new List<string>());
    
    [JsonPropertyName("locations")]
    public List<string> Locations
    {
        get => _locations.GetValue(InlineErrors);
        set => _locations.SetValue(value);
    }

    private PropertyValue<List<string>> _profiles = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Profiles), "profiles", new List<string>());
    
    [JsonPropertyName("profiles")]
    public List<string> Profiles
    {
        get => _profiles.GetValue(InlineErrors);
        set => _profiles.SetValue(value);
    }

    private PropertyValue<List<string>> _externalParticipants = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(ExternalParticipants), "externalParticipants", new List<string>());
    
    [JsonPropertyName("externalParticipants")]
    public List<string> ExternalParticipants
    {
        get => _externalParticipants.GetValue(InlineErrors);
        set => _externalParticipants.SetValue(value);
    }

    private PropertyValue<List<string>> _teams = new PropertyValue<List<string>>(nameof(CalendarsMeetingsPostRequest), nameof(Teams), "teams", new List<string>());
    
    [JsonPropertyName("teams")]
    public List<string> Teams
    {
        get => _teams.GetValue(InlineErrors);
        set => _teams.SetValue(value);
    }

    private PropertyValue<MeetingVisibility> _visibility = new PropertyValue<MeetingVisibility>(nameof(CalendarsMeetingsPostRequest), nameof(Visibility), "visibility", MeetingVisibility.EVERYONE);
    
    [JsonPropertyName("visibility")]
    public MeetingVisibility Visibility
    {
        get => _visibility.GetValue(InlineErrors);
        set => _visibility.SetValue(value);
    }

    private PropertyValue<MeetingModificationPreference> _modificationPreference = new PropertyValue<MeetingModificationPreference>(nameof(CalendarsMeetingsPostRequest), nameof(ModificationPreference), "modificationPreference", MeetingModificationPreference.PARTICIPANTS);
    
    [JsonPropertyName("modificationPreference")]
    public MeetingModificationPreference ModificationPreference
    {
        get => _modificationPreference.GetValue(InlineErrors);
        set => _modificationPreference.SetValue(value);
    }

    private PropertyValue<MeetingJoiningPreference> _joiningPreference = new PropertyValue<MeetingJoiningPreference>(nameof(CalendarsMeetingsPostRequest), nameof(JoiningPreference), "joiningPreference", MeetingJoiningPreference.NOBODY);
    
    [JsonPropertyName("joiningPreference")]
    public MeetingJoiningPreference JoiningPreference
    {
        get => _joiningPreference.GetValue(InlineErrors);
        set => _joiningPreference.SetValue(value);
    }

    private PropertyValue<bool> _notifyOnExport = new PropertyValue<bool>(nameof(CalendarsMeetingsPostRequest), nameof(IsNotifyOnExport), "notifyOnExport");
    
    [JsonPropertyName("notifyOnExport")]
    public bool IsNotifyOnExport
    {
        get => _notifyOnExport.GetValue(InlineErrors);
        set => _notifyOnExport.SetValue(value);
    }

    private PropertyValue<string?> _organizer = new PropertyValue<string?>(nameof(CalendarsMeetingsPostRequest), nameof(Organizer), "organizer");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("organizer")]
    public string? Organizer
    {
        get => _organizer.GetValue(InlineErrors);
        set => _organizer.SetValue(value);
    }

    private PropertyValue<EventConferenceData?> _conferenceData = new PropertyValue<EventConferenceData?>(nameof(CalendarsMeetingsPostRequest), nameof(ConferenceData), "conferenceData");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("conferenceData")]
    public EventConferenceData? ConferenceData
    {
        get => _conferenceData.GetValue(InlineErrors);
        set => _conferenceData.SetValue(value);
    }

    private PropertyValue<List<MeetingAttachment>?> _attachments = new PropertyValue<List<MeetingAttachment>?>(nameof(CalendarsMeetingsPostRequest), nameof(Attachments), "attachments");
    
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
        _locations.SetAccessPath(parentChainPath, validateHasBeenSet);
        _profiles.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalParticipants.SetAccessPath(parentChainPath, validateHasBeenSet);
        _teams.SetAccessPath(parentChainPath, validateHasBeenSet);
        _visibility.SetAccessPath(parentChainPath, validateHasBeenSet);
        _modificationPreference.SetAccessPath(parentChainPath, validateHasBeenSet);
        _joiningPreference.SetAccessPath(parentChainPath, validateHasBeenSet);
        _notifyOnExport.SetAccessPath(parentChainPath, validateHasBeenSet);
        _organizer.SetAccessPath(parentChainPath, validateHasBeenSet);
        _conferenceData.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

