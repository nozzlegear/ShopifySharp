#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FileAcknowledgeUpdateFailedArgumentsBuilder : ArgumentsBuilderBase<FileAcknowledgeUpdateFailedPayload, FileAcknowledgeUpdateFailedArgumentsBuilder>
    {
        protected override FileAcknowledgeUpdateFailedArgumentsBuilder Self => this;

        public FileAcknowledgeUpdateFailedArgumentsBuilder(IQuery<FileAcknowledgeUpdateFailedPayload> query) : base(query)
        {
        }

        public FileAcknowledgeUpdateFailedArgumentsBuilder FileIds(ICollection<string>? fileIds)
        {
            base.InnerQuery.AddArgument("fileIds", fileIds);
            return this;
        }
    }
}