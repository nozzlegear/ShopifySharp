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
    public sealed class OrderLocalizationExtensionsQueryBuilder : FieldsQueryBuilderBase<LocalizationExtensionConnection, OrderLocalizationExtensionsQueryBuilder>, IHasArguments<OrderLocalizationExtensionsArgumentsBuilder>
    {
        public OrderLocalizationExtensionsArgumentsBuilder Arguments { get; }
        protected override OrderLocalizationExtensionsQueryBuilder Self => this;

        public OrderLocalizationExtensionsQueryBuilder(string name) : base(new Query<LocalizationExtensionConnection>(name))
        {
            Arguments = new OrderLocalizationExtensionsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLocalizationExtensionsQueryBuilder(IQuery<LocalizationExtensionConnection> query) : base(query)
        {
            Arguments = new OrderLocalizationExtensionsArgumentsBuilder(base.InnerQuery);
        }

        public OrderLocalizationExtensionsQueryBuilder SetArguments(Action<OrderLocalizationExtensionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderLocalizationExtensionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionEdge>(query);
            return this;
        }

        public OrderLocalizationExtensionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtension>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtension>(query);
            return this;
        }

        public OrderLocalizationExtensionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}