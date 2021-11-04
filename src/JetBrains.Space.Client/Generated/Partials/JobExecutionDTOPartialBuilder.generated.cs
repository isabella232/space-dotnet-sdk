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

namespace JetBrains.Space.Client.JobExecutionDTOPartialBuilder;

public static class JobExecutionDTOPartialExtensions
{
    public static Partial<JobExecutionDTO> WithExecutionId(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("executionId");
    
    public static Partial<JobExecutionDTO> WithExecutionNumber(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("executionNumber");
    
    public static Partial<JobExecutionDTO> WithJobId(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("jobId");
    
    public static Partial<JobExecutionDTO> WithJobName(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("jobName");
    
    public static Partial<JobExecutionDTO> WithProjectId(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("projectId");
    
    public static Partial<JobExecutionDTO> WithBranch(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("branch");
    
    public static Partial<JobExecutionDTO> WithStatus(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("status");
    
    public static Partial<JobExecutionDTO> WithStatus(this Partial<JobExecutionDTO> it, Func<Partial<ExecutionStatus>, Partial<ExecutionStatus>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<ExecutionStatus>(it)));
    
    public static Partial<JobExecutionDTO> WithTriggeredTime(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("triggeredTime");
    
    public static Partial<JobExecutionDTO> WithStartedTime(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("startedTime");
    
    public static Partial<JobExecutionDTO> WithFinishedTime(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("finishedTime");
    
    public static Partial<JobExecutionDTO> WithChangesCount(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("changesCount");
    
    public static Partial<JobExecutionDTO> WithPredictedEndTime(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("predictedEndTime");
    
    public static Partial<JobExecutionDTO> WithPredictedEndTime(this Partial<JobExecutionDTO> it, Func<Partial<EstimationDTO>, Partial<EstimationDTO>> partialBuilder)
        => it.AddFieldName("predictedEndTime", partialBuilder(new Partial<EstimationDTO>(it)));
    
    public static Partial<JobExecutionDTO> WithFailureConditions(this Partial<JobExecutionDTO> it)
        => it.AddFieldName("failureConditions");
    
    public static Partial<JobExecutionDTO> WithFailureConditions(this Partial<JobExecutionDTO> it, Func<Partial<FailureConditionDTO>, Partial<FailureConditionDTO>> partialBuilder)
        => it.AddFieldName("failureConditions", partialBuilder(new Partial<FailureConditionDTO>(it)));
    
}

