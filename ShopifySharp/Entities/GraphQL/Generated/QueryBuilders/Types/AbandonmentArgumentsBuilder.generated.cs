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
    public sealed class AbandonmentArgumentsBuilder : ArgumentsBuilderBase<Abandonment, AbandonmentArgumentsBuilder>
    {
        protected override AbandonmentArgumentsBuilder Self => this;

        public AbandonmentArgumentsBuilder(IQuery<Abandonment> query) : base(query)
        {
        }

        public AbandonmentArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public AbandonmentArgumentsBuilder AbandonedCheckoutId(string? abandonedCheckoutId)
        {
            base.InnerQuery.AddArgument("abandonedCheckoutId", abandonedCheckoutId);
            return this;
        }
    }
}