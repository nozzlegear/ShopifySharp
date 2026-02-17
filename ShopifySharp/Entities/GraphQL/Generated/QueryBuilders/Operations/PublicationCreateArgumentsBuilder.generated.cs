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
    public sealed class PublicationCreateArgumentsBuilder : ArgumentsBuilderBase<PublicationCreatePayload, PublicationCreateArgumentsBuilder>
    {
        protected override PublicationCreateArgumentsBuilder Self => this;

        public PublicationCreateArgumentsBuilder(IQuery<PublicationCreatePayload> query) : base(query)
        {
        }

        public PublicationCreateArgumentsBuilder Input(PublicationCreateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}