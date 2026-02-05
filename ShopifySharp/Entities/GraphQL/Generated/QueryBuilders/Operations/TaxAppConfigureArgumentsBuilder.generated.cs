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