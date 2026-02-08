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