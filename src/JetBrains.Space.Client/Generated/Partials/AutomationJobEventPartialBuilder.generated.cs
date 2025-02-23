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

namespace JetBrains.Space.Client.AutomationJobEventPartialBuilder;

public static class AutomationJobEventPartialExtensions
{
    public static Partial<AutomationJobEvent> WithMeta(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<AutomationJobEvent> WithMeta(this Partial<AutomationJobEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<AutomationJobEvent> WithExecutionId(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("executionId");
    
    public static Partial<AutomationJobEvent> WithProject(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("project");
    
    public static Partial<AutomationJobEvent> WithProject(this Partial<AutomationJobEvent> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<AutomationJobEvent> WithRepositoryName(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("repositoryName");
    
    public static Partial<AutomationJobEvent> WithJobName(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("jobName");
    
    public static Partial<AutomationJobEvent> WithExecutionNumber(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("executionNumber");
    
    public static Partial<AutomationJobEvent> WithTrigger(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("trigger");
    
    public static Partial<AutomationJobEvent> WithTrigger(this Partial<AutomationJobEvent> it, Func<Partial<JobExecutionTrigger>, Partial<JobExecutionTrigger>> partialBuilder)
        => it.AddFieldName("trigger", partialBuilder(new Partial<JobExecutionTrigger>(it)));
    
    public static Partial<AutomationJobEvent> WithTriggerTime(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("triggerTime");
    
    public static Partial<AutomationJobEvent> WithStatus(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("status");
    
    public static Partial<AutomationJobEvent> WithFailureReasons(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("failureReasons");
    
    public static Partial<AutomationJobEvent> WithStoppedBy(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("stoppedBy");
    
    public static Partial<AutomationJobEvent> WithStartTime(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("startTime");
    
    public static Partial<AutomationJobEvent> WithEndTime(this Partial<AutomationJobEvent> it)
        => it.AddFieldName("endTime");
    
}

