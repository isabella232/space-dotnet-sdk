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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class TeamDirectoryProfilesForProfileSettingsPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryProfilesForProfileSettingsPatchRequest() { }
        
        public TeamDirectoryProfilesForProfileSettingsPatchRequest(string? themeName = null, Weekday? firstDayOfWeek = null, DraftDocumentType? draftType = null, bool? todoFilters = null, string? calendarView = null, bool? emailNotificationsEnabled = null, string? notificationEmail = null)
        {
            ThemeName = themeName;
            FirstDayOfWeek = firstDayOfWeek;
            DraftType = draftType;
            IsTodoFilters = todoFilters;
            CalendarView = calendarView;
            IsEmailNotificationsEnabled = emailNotificationsEnabled;
            NotificationEmail = notificationEmail;
        }
        
        private PropertyValue<string?> _themeName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(ThemeName));
        
        [JsonPropertyName("themeName")]
        public string? ThemeName
        {
            get => _themeName.GetValue();
            set => _themeName.SetValue(value);
        }
    
        private PropertyValue<Weekday?> _firstDayOfWeek = new PropertyValue<Weekday?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(FirstDayOfWeek));
        
        [JsonPropertyName("firstDayOfWeek")]
        public Weekday? FirstDayOfWeek
        {
            get => _firstDayOfWeek.GetValue();
            set => _firstDayOfWeek.SetValue(value);
        }
    
        private PropertyValue<DraftDocumentType?> _draftType = new PropertyValue<DraftDocumentType?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(DraftType));
        
        [JsonPropertyName("draftType")]
        public DraftDocumentType? DraftType
        {
            get => _draftType.GetValue();
            set => _draftType.SetValue(value);
        }
    
        private PropertyValue<bool?> _todoFilters = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(IsTodoFilters));
        
        [JsonPropertyName("todoFilters")]
        public bool? IsTodoFilters
        {
            get => _todoFilters.GetValue();
            set => _todoFilters.SetValue(value);
        }
    
        private PropertyValue<string?> _calendarView = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(CalendarView));
        
        [JsonPropertyName("calendarView")]
        public string? CalendarView
        {
            get => _calendarView.GetValue();
            set => _calendarView.SetValue(value);
        }
    
        private PropertyValue<bool?> _emailNotificationsEnabled = new PropertyValue<bool?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(IsEmailNotificationsEnabled));
        
        [JsonPropertyName("emailNotificationsEnabled")]
        public bool? IsEmailNotificationsEnabled
        {
            get => _emailNotificationsEnabled.GetValue();
            set => _emailNotificationsEnabled.SetValue(value);
        }
    
        private PropertyValue<string?> _notificationEmail = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSettingsPatchRequest), nameof(NotificationEmail));
        
        [JsonPropertyName("notificationEmail")]
        public string? NotificationEmail
        {
            get => _notificationEmail.GetValue();
            set => _notificationEmail.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _themeName.SetAccessPath(path, validateHasBeenSet);
            _firstDayOfWeek.SetAccessPath(path, validateHasBeenSet);
            _draftType.SetAccessPath(path, validateHasBeenSet);
            _todoFilters.SetAccessPath(path, validateHasBeenSet);
            _calendarView.SetAccessPath(path, validateHasBeenSet);
            _emailNotificationsEnabled.SetAccessPath(path, validateHasBeenSet);
            _notificationEmail.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
