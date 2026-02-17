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
    public sealed class TaxAppConfigureArgumentsBuilder : ArgumentsBuilderBase<TaxAppConfigurePayload, TaxAppConfigureArgumentsBuilder>
    {
        protected override TaxAppConfigureArgumentsBuilder Self => this;

        public TaxAppConfigureArgumentsBuilder(IQuery<TaxAppConfigurePayload> query) : base(query)
        {
        }

        public TaxAppConfigureArgumentsBuilder Ready(bool? ready)
        {
            base.InnerQuery.AddArgument("ready", ready);
            return this;
        }
    }
}