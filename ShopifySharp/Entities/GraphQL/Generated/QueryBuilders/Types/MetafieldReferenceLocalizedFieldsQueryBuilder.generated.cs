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
    public sealed class MetafieldReferenceLocalizedFieldsQueryBuilder : FieldsQueryBuilderBase<LocalizedFieldConnection, MetafieldReferenceLocalizedFieldsQueryBuilder>, IHasArguments<MetafieldReferenceLocalizedFieldsArgumentsBuilder>
    {
        public MetafieldReferenceLocalizedFieldsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceLocalizedFieldsQueryBuilder Self => this;

        public MetafieldReferenceLocalizedFieldsQueryBuilder(string name) : base(new Query<LocalizedFieldConnection>(name))
        {
            Arguments = new MetafieldReferenceLocalizedFieldsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceLocalizedFieldsQueryBuilder(IQuery<LocalizedFieldConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceLocalizedFieldsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceLocalizedFieldsQueryBuilder SetArguments(Action<MetafieldReferenceLocalizedFieldsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceLocalizedFieldsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldEdge>(query);
            return this;
        }

        public MetafieldReferenceLocalizedFieldsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder> build)
        {
            var query = new Query<LocalizedField>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocalizedFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedField>(query);
            return this;
        }

        public MetafieldReferenceLocalizedFieldsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}