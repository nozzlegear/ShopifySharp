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
    public sealed class PublishablePublishArgumentsBuilder : ArgumentsBuilderBase<PublishablePublishPayload, PublishablePublishArgumentsBuilder>
    {
        protected override PublishablePublishArgumentsBuilder Self => this;

        public PublishablePublishArgumentsBuilder(IQuery<PublishablePublishPayload> query) : base(query)
        {
        }

        public PublishablePublishArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public PublishablePublishArgumentsBuilder Input(ICollection<PublicationInput>? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}