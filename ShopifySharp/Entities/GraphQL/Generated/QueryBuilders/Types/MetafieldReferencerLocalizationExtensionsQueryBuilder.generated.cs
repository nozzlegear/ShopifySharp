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
    public sealed class MetafieldReferencerLocalizationExtensionsQueryBuilder : FieldsQueryBuilderBase<LocalizationExtensionConnection, MetafieldReferencerLocalizationExtensionsQueryBuilder>, IHasArguments<MetafieldReferencerLocalizationExtensionsArgumentsBuilder>
    {
        public MetafieldReferencerLocalizationExtensionsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerLocalizationExtensionsQueryBuilder Self => this;

        public MetafieldReferencerLocalizationExtensionsQueryBuilder(string name) : base(new Query<LocalizationExtensionConnection>(name))
        {
            Arguments = new MetafieldReferencerLocalizationExtensionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLocalizationExtensionsQueryBuilder(IQuery<LocalizationExtensionConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerLocalizationExtensionsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerLocalizationExtensionsQueryBuilder SetArguments(Action<MetafieldReferencerLocalizationExtensionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionEdge>(query);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtension>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizationExtensionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtension>(query);
            return this;
        }

        public MetafieldReferencerLocalizationExtensionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}