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
    public sealed class FileUpdateArgumentsBuilder : ArgumentsBuilderBase<FileUpdatePayload, FileUpdateArgumentsBuilder>
    {
        protected override FileUpdateArgumentsBuilder Self => this;

        public FileUpdateArgumentsBuilder(IQuery<FileUpdatePayload> query) : base(query)
        {
        }

        public FileUpdateArgumentsBuilder Files(ICollection<FileUpdateInput>? files)
        {
            base.InnerQuery.AddArgument("files", files);
            return this;
        }
    }
}