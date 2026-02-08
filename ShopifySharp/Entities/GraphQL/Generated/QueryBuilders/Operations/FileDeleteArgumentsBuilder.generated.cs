#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class FileDeleteArgumentsBuilder : ArgumentsBuilderBase<FileDeletePayload, FileDeleteArgumentsBuilder>
    {
        protected override FileDeleteArgumentsBuilder Self => this;

        public FileDeleteArgumentsBuilder(IQuery<FileDeletePayload> query) : base(query)
        {
        }

        public FileDeleteArgumentsBuilder FileIds(ICollection<string>? fileIds)
        {
            base.InnerQuery.AddArgument("fileIds", fileIds);
            return this;
        }
    }
}