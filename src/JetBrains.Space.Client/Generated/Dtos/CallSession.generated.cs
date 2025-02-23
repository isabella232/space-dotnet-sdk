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

public sealed class CallSession
     : IPropagatePropertyAccessPath
{
    public CallSession() { }
    
    public CallSession(string id, bool archived, Room room, string description, DateTime start, bool resourcesPrepared, List<SessionParticipationRecord> participations, DateTime? end = null, M2ChannelRecord? channel = null, ConnectionTopology? topology = null)
    {
        Id = id;
        IsArchived = archived;
        Room = room;
        Description = description;
        Start = start;
        End = end;
        Channel = channel;
        Topology = topology;
        IsResourcesPrepared = resourcesPrepared;
        Participations = participations;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CallSession), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CallSession), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<Room> _room = new PropertyValue<Room>(nameof(CallSession), nameof(Room), "room");
    
    [Required]
    [JsonPropertyName("room")]
    public Room Room
    {
        get => _room.GetValue(InlineErrors);
        set => _room.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(CallSession), nameof(Description), "description");
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<DateTime> _start = new PropertyValue<DateTime>(nameof(CallSession), nameof(Start), "start");
    
    [Required]
    [JsonPropertyName("start")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Start
    {
        get => _start.GetValue(InlineErrors);
        set => _start.SetValue(value);
    }

    private PropertyValue<DateTime?> _end = new PropertyValue<DateTime?>(nameof(CallSession), nameof(End), "end");
    
    [JsonPropertyName("end")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? End
    {
        get => _end.GetValue(InlineErrors);
        set => _end.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord?> _channel = new PropertyValue<M2ChannelRecord?>(nameof(CallSession), nameof(Channel), "channel");
    
    [JsonPropertyName("channel")]
    public M2ChannelRecord? Channel
    {
        get => _channel.GetValue(InlineErrors);
        set => _channel.SetValue(value);
    }

    private PropertyValue<ConnectionTopology?> _topology = new PropertyValue<ConnectionTopology?>(nameof(CallSession), nameof(Topology), "topology");
    
    [JsonPropertyName("topology")]
    public ConnectionTopology? Topology
    {
        get => _topology.GetValue(InlineErrors);
        set => _topology.SetValue(value);
    }

    private PropertyValue<bool> _resourcesPrepared = new PropertyValue<bool>(nameof(CallSession), nameof(IsResourcesPrepared), "resourcesPrepared");
    
    [Required]
    [JsonPropertyName("resourcesPrepared")]
    public bool IsResourcesPrepared
    {
        get => _resourcesPrepared.GetValue(InlineErrors);
        set => _resourcesPrepared.SetValue(value);
    }

    private PropertyValue<List<SessionParticipationRecord>> _participations = new PropertyValue<List<SessionParticipationRecord>>(nameof(CallSession), nameof(Participations), "participations", new List<SessionParticipationRecord>());
    
    [Required]
    [JsonPropertyName("participations")]
    public List<SessionParticipationRecord> Participations
    {
        get => _participations.GetValue(InlineErrors);
        set => _participations.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _room.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _start.SetAccessPath(parentChainPath, validateHasBeenSet);
        _end.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channel.SetAccessPath(parentChainPath, validateHasBeenSet);
        _topology.SetAccessPath(parentChainPath, validateHasBeenSet);
        _resourcesPrepared.SetAccessPath(parentChainPath, validateHasBeenSet);
        _participations.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

