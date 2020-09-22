// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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

namespace SpaceDotNet.Client.TextDocumentPartialBuilder
{
    public static class TextDocumentPartialExtensions
    {
        public static Partial<TextDocument> WithId(this Partial<TextDocument> it)
            => it.AddFieldName("id");
        
        public static Partial<TextDocument> WithResetCounter(this Partial<TextDocument> it)
            => it.AddFieldName("resetCounter");
        
        public static Partial<TextDocument> WithVersion(this Partial<TextDocument> it)
            => it.AddFieldName("version");
        
        public static Partial<TextDocument> WithType(this Partial<TextDocument> it)
            => it.AddFieldName("type");
        
        public static Partial<TextDocument> WithType(this Partial<TextDocument> it, Func<Partial<DraftDocumentType>, Partial<DraftDocumentType>> partialBuilder)
            => it.AddFieldName("type", partialBuilder(new Partial<DraftDocumentType>(it)));
        
        public static Partial<TextDocument> WithText(this Partial<TextDocument> it)
            => it.AddFieldName("text");
        
        public static Partial<TextDocument> WithModel(this Partial<TextDocument> it)
            => it.AddFieldName("model");
        
    }
    
}
