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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FunctionsAppBridgeQueryBuilder : FieldsQueryBuilderBase<FunctionsAppBridge, FunctionsAppBridgeQueryBuilder>
    {
        protected override FunctionsAppBridgeQueryBuilder Self => this;

        public FunctionsAppBridgeQueryBuilder() : this("functionsAppBridge")
        {
        }

        public FunctionsAppBridgeQueryBuilder(string name) : base(new Query<FunctionsAppBridge>(name))
        {
        }

        public FunctionsAppBridgeQueryBuilder(IQuery<FunctionsAppBridge> query) : base(query)
        {
        }

        public FunctionsAppBridgeQueryBuilder CreatePath()
        {
            base.InnerQuery.AddField("createPath");
            return this;
        }

        public FunctionsAppBridgeQueryBuilder DetailsPath()
        {
            base.InnerQuery.AddField("detailsPath");
            return this;
        }
    }
}