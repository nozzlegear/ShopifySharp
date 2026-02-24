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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootCollectionByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Collection?, QueryRootCollectionByIdentifierArgumentsBuilder>
    {
        protected override QueryRootCollectionByIdentifierArgumentsBuilder Self => this;

        public QueryRootCollectionByIdentifierArgumentsBuilder(IQuery<Collection?> query) : base(query)
        {
        }

        public QueryRootCollectionByIdentifierArgumentsBuilder Identifier(CollectionIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}