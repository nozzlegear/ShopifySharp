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
    public sealed class LocationByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Location, LocationByIdentifierArgumentsBuilder>
    {
        protected override LocationByIdentifierArgumentsBuilder Self => this;

        public LocationByIdentifierArgumentsBuilder(IQuery<Location> query) : base(query)
        {
        }

        public LocationByIdentifierArgumentsBuilder Identifier(LocationIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}