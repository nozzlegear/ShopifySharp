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
    public sealed class CatalogContextUpdateArgumentsBuilder : ArgumentsBuilderBase<CatalogContextUpdatePayload, CatalogContextUpdateArgumentsBuilder>
    {
        protected override CatalogContextUpdateArgumentsBuilder Self => this;

        public CatalogContextUpdateArgumentsBuilder(IQuery<CatalogContextUpdatePayload> query) : base(query)
        {
        }

        public CatalogContextUpdateArgumentsBuilder CatalogId(string? catalogId)
        {
            base.InnerQuery.AddArgument("catalogId", catalogId);
            return this;
        }

        public CatalogContextUpdateArgumentsBuilder ContextsToAdd(CatalogContextInput? contextsToAdd)
        {
            base.InnerQuery.AddArgument("contextsToAdd", contextsToAdd);
            return this;
        }

        public CatalogContextUpdateArgumentsBuilder ContextsToRemove(CatalogContextInput? contextsToRemove)
        {
            base.InnerQuery.AddArgument("contextsToRemove", contextsToRemove);
            return this;
        }
    }
}