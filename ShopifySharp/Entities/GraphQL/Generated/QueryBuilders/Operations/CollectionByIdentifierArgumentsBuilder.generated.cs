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
    public sealed class CollectionByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Collection, CollectionByIdentifierArgumentsBuilder>
    {
        protected override CollectionByIdentifierArgumentsBuilder Self => this;

        public CollectionByIdentifierArgumentsBuilder(IQuery<Collection> query) : base(query)
        {
        }

        public CollectionByIdentifierArgumentsBuilder Identifier(CollectionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}