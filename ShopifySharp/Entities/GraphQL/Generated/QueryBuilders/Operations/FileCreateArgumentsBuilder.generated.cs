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
    public sealed class FileCreateArgumentsBuilder : ArgumentsBuilderBase<FileCreatePayload, FileCreateArgumentsBuilder>
    {
        protected override FileCreateArgumentsBuilder Self => this;

        public FileCreateArgumentsBuilder(IQuery<FileCreatePayload> query) : base(query)
        {
        }

        public FileCreateArgumentsBuilder Files(ICollection<FileCreateInput>? files)
        {
            base.InnerQuery.AddArgument("files", files);
            return this;
        }
    }
}