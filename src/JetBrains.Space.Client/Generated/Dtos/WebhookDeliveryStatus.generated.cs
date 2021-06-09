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
    [JsonConverter(typeof(ClassNameDtoTypeConverter))]
    public class WebhookDeliveryStatus
         : IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public virtual string? ClassName => "WebhookDeliveryStatus";
        
        public static WebhookDeliveryStatusDTOFailedDelivery DTOFailedDelivery(string deliveryId, int responseCode, string message, DateTime sentTime)
            => new WebhookDeliveryStatusDTOFailedDelivery(deliveryId: deliveryId, responseCode: responseCode, message: message, sentTime: sentTime);
        
        public static WebhookDeliveryStatusDTOInternalError DTOInternalError(string deliveryId, DateTime sentTime)
            => new WebhookDeliveryStatusDTOInternalError(deliveryId: deliveryId, sentTime: sentTime);
        
        public static WebhookDeliveryStatusDTOSuccessful DTOSuccessful(string deliveryId, int responseCode, DateTime sentTime)
            => new WebhookDeliveryStatusDTOSuccessful(deliveryId: deliveryId, responseCode: responseCode, sentTime: sentTime);
        
        public WebhookDeliveryStatus() { }
        
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
        }
    
    }
    
}
