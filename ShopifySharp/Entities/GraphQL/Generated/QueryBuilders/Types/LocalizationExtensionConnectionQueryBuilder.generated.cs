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
    public sealed class LocalizationExtensionConnectionQueryBuilder : FieldsQueryBuilderBase<LocalizationExtensionConnection, LocalizationExtensionConnectionQueryBuilder>
    {
        protected override LocalizationExtensionConnectionQueryBuilder Self => this;

        public LocalizationExtensionConnectionQueryBuilder() : this("localizationExtensionConnection")
        {
        }

        public LocalizationExtensionConnectionQueryBuilder(string name) : base(new Query<LocalizationExtensionConnection>(name))
        {
        }

        public LocalizationExtensionConnectionQueryBuilder(IQuery<LocalizationExtensionConnection> query) : base(query)
        {
        }

        public LocalizationExtensionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionEdge>(query);
            return this;
        }

        public LocalizationExtensionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtension>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtension>(query);
            return this;
        }

        public LocalizationExtensionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}