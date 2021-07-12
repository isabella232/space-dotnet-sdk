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
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class AutomationJobUnfurlDetails
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "AutomationJobUnfurlDetails";
        
        public AutomationJobUnfurlDetails() { }
        
        public AutomationJobUnfurlDetails(string jobId, string jobName, PRProject projectRef, string repoName, JobExecutionDisplayStatus? jobExecutionDisplayStatusFilter = null, JobTriggerType? jobTriggerFilter = null, Branch? branch = null)
        {
            JobId = jobId;
            JobName = jobName;
            ProjectRef = projectRef;
            RepoName = repoName;
            JobExecutionDisplayStatusFilter = jobExecutionDisplayStatusFilter;
            JobTriggerFilter = jobTriggerFilter;
            Branch = branch;
        }
        
        private PropertyValue<string> _jobId = new PropertyValue<string>(nameof(AutomationJobUnfurlDetails), nameof(JobId));
        
        [Required]
        [JsonPropertyName("jobId")]
        public string JobId
        {
            get => _jobId.GetValue();
            set => _jobId.SetValue(value);
        }
    
        private PropertyValue<string> _jobName = new PropertyValue<string>(nameof(AutomationJobUnfurlDetails), nameof(JobName));
        
        [Required]
        [JsonPropertyName("jobName")]
        public string JobName
        {
            get => _jobName.GetValue();
            set => _jobName.SetValue(value);
        }
    
        private PropertyValue<PRProject> _projectRef = new PropertyValue<PRProject>(nameof(AutomationJobUnfurlDetails), nameof(ProjectRef));
        
        [Required]
        [JsonPropertyName("projectRef")]
        public PRProject ProjectRef
        {
            get => _projectRef.GetValue();
            set => _projectRef.SetValue(value);
        }
    
        private PropertyValue<string> _repoName = new PropertyValue<string>(nameof(AutomationJobUnfurlDetails), nameof(RepoName));
        
        [Required]
        [JsonPropertyName("repoName")]
        public string RepoName
        {
            get => _repoName.GetValue();
            set => _repoName.SetValue(value);
        }
    
        private PropertyValue<JobExecutionDisplayStatus?> _jobExecutionDisplayStatusFilter = new PropertyValue<JobExecutionDisplayStatus?>(nameof(AutomationJobUnfurlDetails), nameof(JobExecutionDisplayStatusFilter));
        
        [JsonPropertyName("jobExecutionDisplayStatusFilter")]
        public JobExecutionDisplayStatus? JobExecutionDisplayStatusFilter
        {
            get => _jobExecutionDisplayStatusFilter.GetValue();
            set => _jobExecutionDisplayStatusFilter.SetValue(value);
        }
    
        private PropertyValue<JobTriggerType?> _jobTriggerFilter = new PropertyValue<JobTriggerType?>(nameof(AutomationJobUnfurlDetails), nameof(JobTriggerFilter));
        
        [JsonPropertyName("jobTriggerFilter")]
        public JobTriggerType? JobTriggerFilter
        {
            get => _jobTriggerFilter.GetValue();
            set => _jobTriggerFilter.SetValue(value);
        }
    
        private PropertyValue<Branch?> _branch = new PropertyValue<Branch?>(nameof(AutomationJobUnfurlDetails), nameof(Branch));
        
        [JsonPropertyName("branch")]
        public Branch? Branch
        {
            get => _branch.GetValue();
            set => _branch.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _jobId.SetAccessPath(path, validateHasBeenSet);
            _jobName.SetAccessPath(path, validateHasBeenSet);
            _projectRef.SetAccessPath(path, validateHasBeenSet);
            _repoName.SetAccessPath(path, validateHasBeenSet);
            _jobExecutionDisplayStatusFilter.SetAccessPath(path, validateHasBeenSet);
            _jobTriggerFilter.SetAccessPath(path, validateHasBeenSet);
            _branch.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
