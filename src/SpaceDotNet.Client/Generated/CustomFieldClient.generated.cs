// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class CustomFieldClient
    {
        private readonly Connection _connection;
        
        public CustomFieldClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ExtendedTypeClient ExtendedTypes => new ExtendedTypeClient(_connection);
        
        public partial class ExtendedTypeClient
        {
            private readonly Connection _connection;
            
            public ExtendedTypeClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<List<ExtendedTypeDto>> GetAllExtendedTypesAsync(Func<Partial<ExtendedTypeDto>, Partial<ExtendedTypeDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<ExtendedTypeDto>>("GET", $"api/http/custom-fields/extended-types?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ExtendedTypeDto>()) : Partial<ExtendedTypeDto>.Default()));            
            
        }
        
        public AllValueClient AllValues => new AllValueClient(_connection);
        
        public partial class AllValueClient
        {
            private readonly Connection _connection;
            
            public AllValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<Batch<CustomFieldsRecordDto>> GetAllAllValuesAsync(string typeKey, string? skip = null, int? top = null, List<string>? extendedEntityIds = null, Func<Partial<Batch<CustomFieldsRecordDto>>, Partial<Batch<CustomFieldsRecordDto>>> partialBuilder = null)
                => await _connection.RequestResourceAsync<Batch<CustomFieldsRecordDto>>("GET", $"api/http/custom-fields/{typeKey}/all-values?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&extendedEntityIds={extendedEntityIds?.JoinToString("extendedEntityIds", it => it.ToString()) ?? "null"}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<Batch<CustomFieldsRecordDto>>()) : Partial<Batch<CustomFieldsRecordDto>>.Default()));            
            
        }
        
        public FieldClient Fields => new FieldClient(_connection);
        
        public partial class FieldClient
        {
            private readonly Connection _connection;
            
            public FieldClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<CustomFieldDto> CreateFieldAsync(string typeKey, CreateFieldRequestDto data, Func<Partial<CustomFieldDto>, Partial<CustomFieldDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CreateFieldRequestDto, CustomFieldDto>("POST", $"api/http/custom-fields/{typeKey}/fields?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<CustomFieldDto>()) : Partial<CustomFieldDto>.Default()), data);            
            
            public async Task ReorderAsync(string typeKey, ReorderRequestDto data)
                => await _connection.RequestResourceAsync<ReorderRequestDto>("POST", $"api/http/custom-fields/{typeKey}/fields/reorder", data);            
            
            public async Task ArchiveAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/archive");            
            
            public async Task RestoreAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/restore");            
            
            public async Task<List<CustomFieldDto>> GetAllFieldsAsync(string typeKey, bool withArchived, Func<Partial<CustomFieldDto>, Partial<CustomFieldDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<List<CustomFieldDto>>("GET", $"api/http/custom-fields/{typeKey}/fields?withArchived={withArchived.ToString().ToLowerInvariant()}&$fields=" + (partialBuilder != null ? partialBuilder(new Partial<CustomFieldDto>()) : Partial<CustomFieldDto>.Default()));            
            
            public async Task UpdateFieldAsync(string typeKey, string id, UpdateFieldRequestDto data)
                => await _connection.RequestResourceAsync<UpdateFieldRequestDto>("PATCH", $"api/http/custom-fields/{typeKey}/fields/{id}", data);            
            
            public async Task DeleteFieldAsync(string typeKey, string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/custom-fields/{typeKey}/fields/{id}");            
            
        }
        
        public ValueClient Values => new ValueClient(_connection);
        
        public partial class ValueClient
        {
            private readonly Connection _connection;
            
            public ValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<CustomFieldsRecordDto> GetValueAsync(string typeKey, string entityId, Func<Partial<CustomFieldsRecordDto>, Partial<CustomFieldsRecordDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<CustomFieldsRecordDto>("GET", $"api/http/custom-fields/{typeKey}/{entityId}/values?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<CustomFieldsRecordDto>()) : Partial<CustomFieldsRecordDto>.Default()));            
            
            public async Task UpdateValueAsync(string entityId, string typeKey, UpdateValueRequestDto data)
                => await _connection.RequestResourceAsync<UpdateValueRequestDto>("PATCH", $"api/http/custom-fields/{typeKey}/{entityId}/values", data);            
            
        }
        
    }
    
}
