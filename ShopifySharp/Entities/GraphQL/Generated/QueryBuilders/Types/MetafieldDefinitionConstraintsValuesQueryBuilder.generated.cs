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
    public sealed class MetafieldDefinitionConstraintsValuesQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConstraintValueConnection, MetafieldDefinitionConstraintsValuesQueryBuilder>, IHasArguments<MetafieldDefinitionConstraintsValuesArgumentsBuilder>
    {
        public MetafieldDefinitionConstraintsValuesArgumentsBuilder Arguments { get; }
        protected override MetafieldDefinitionConstraintsValuesQueryBuilder Self => this;

        public MetafieldDefinitionConstraintsValuesQueryBuilder(string name) : base(new Query<MetafieldDefinitionConstraintValueConnection>(name))
        {
            Arguments = new MetafieldDefinitionConstraintsValuesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionConstraintsValuesQueryBuilder(IQuery<MetafieldDefinitionConstraintValueConnection> query) : base(query)
        {
            Arguments = new MetafieldDefinitionConstraintsValuesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldDefinitionConstraintsValuesQueryBuilder SetArguments(Action<MetafieldDefinitionConstraintsValuesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValueEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValueEdge>(query);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConstraintValue>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConstraintValueQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConstraintValue>(query);
            return this;
        }

        public MetafieldDefinitionConstraintsValuesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}