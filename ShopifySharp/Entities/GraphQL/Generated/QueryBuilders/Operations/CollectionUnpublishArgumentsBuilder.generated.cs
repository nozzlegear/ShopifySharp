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
    public sealed class CollectionUnpublishArgumentsBuilder : ArgumentsBuilderBase<CollectionUnpublishPayload, CollectionUnpublishArgumentsBuilder>
    {
        protected override CollectionUnpublishArgumentsBuilder Self => this;

        public CollectionUnpublishArgumentsBuilder(IQuery<CollectionUnpublishPayload> query) : base(query)
        {
        }

        public CollectionUnpublishArgumentsBuilder Input(CollectionUnpublishInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}