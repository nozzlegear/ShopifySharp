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
    public sealed class PublicationDeleteArgumentsBuilder : ArgumentsBuilderBase<PublicationDeletePayload, PublicationDeleteArgumentsBuilder>
    {
        protected override PublicationDeleteArgumentsBuilder Self => this;

        public PublicationDeleteArgumentsBuilder(IQuery<PublicationDeletePayload> query) : base(query)
        {
        }

        public PublicationDeleteArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}