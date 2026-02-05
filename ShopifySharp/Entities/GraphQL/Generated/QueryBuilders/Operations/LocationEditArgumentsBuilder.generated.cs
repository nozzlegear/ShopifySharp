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
    public sealed class LocationEditArgumentsBuilder : ArgumentsBuilderBase<LocationEditPayload, LocationEditArgumentsBuilder>
    {
        protected override LocationEditArgumentsBuilder Self => this;

        public LocationEditArgumentsBuilder(IQuery<LocationEditPayload> query) : base(query)
        {
        }

        public LocationEditArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public LocationEditArgumentsBuilder Input(LocationEditInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}