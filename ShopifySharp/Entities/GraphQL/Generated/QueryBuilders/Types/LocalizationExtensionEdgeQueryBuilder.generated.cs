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
    public sealed class LocalizationExtensionEdgeQueryBuilder : FieldsQueryBuilderBase<LocalizationExtensionEdge, LocalizationExtensionEdgeQueryBuilder>
    {
        protected override LocalizationExtensionEdgeQueryBuilder Self => this;

        public LocalizationExtensionEdgeQueryBuilder() : this("localizationExtensionEdge")
        {
        }

        public LocalizationExtensionEdgeQueryBuilder(string name) : base(new Query<LocalizationExtensionEdge>(name))
        {
        }

        public LocalizationExtensionEdgeQueryBuilder(IQuery<LocalizationExtensionEdge> query) : base(query)
        {
        }

        public LocalizationExtensionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public LocalizationExtensionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtension>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtension>(query);
            return this;
        }
    }
}