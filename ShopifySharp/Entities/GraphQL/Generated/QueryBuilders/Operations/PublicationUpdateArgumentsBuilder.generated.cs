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
    public sealed class PublicationUpdateArgumentsBuilder : ArgumentsBuilderBase<PublicationUpdatePayload, PublicationUpdateArgumentsBuilder>
    {
        protected override PublicationUpdateArgumentsBuilder Self => this;

        public PublicationUpdateArgumentsBuilder(IQuery<PublicationUpdatePayload> query) : base(query)
        {
        }

        public PublicationUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public PublicationUpdateArgumentsBuilder Input(PublicationUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}