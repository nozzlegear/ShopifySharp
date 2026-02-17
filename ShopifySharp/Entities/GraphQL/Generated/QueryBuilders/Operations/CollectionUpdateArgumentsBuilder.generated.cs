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
    public sealed class CollectionUpdateArgumentsBuilder : ArgumentsBuilderBase<CollectionUpdatePayload, CollectionUpdateArgumentsBuilder>
    {
        protected override CollectionUpdateArgumentsBuilder Self => this;

        public CollectionUpdateArgumentsBuilder(IQuery<CollectionUpdatePayload> query) : base(query)
        {
        }

        public CollectionUpdateArgumentsBuilder Input(CollectionInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}