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
    public sealed class PurchasingEntityMetafieldDefinitionsQueryBuilder : FieldsQueryBuilderBase<MetafieldDefinitionConnection, PurchasingEntityMetafieldDefinitionsQueryBuilder>, IHasArguments<PurchasingEntityMetafieldDefinitionsArgumentsBuilder>
    {
        public PurchasingEntityMetafieldDefinitionsArgumentsBuilder Arguments { get; }
        protected override PurchasingEntityMetafieldDefinitionsQueryBuilder Self => this;

        public PurchasingEntityMetafieldDefinitionsQueryBuilder(string name) : base(new Query<MetafieldDefinitionConnection>(name))
        {
            Arguments = new PurchasingEntityMetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntityMetafieldDefinitionsQueryBuilder(IQuery<MetafieldDefinitionConnection> query) : base(query)
        {
            Arguments = new PurchasingEntityMetafieldDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public PurchasingEntityMetafieldDefinitionsQueryBuilder SetArguments(Action<PurchasingEntityMetafieldDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PurchasingEntityMetafieldDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionEdge>(query);
            return this;
        }

        public PurchasingEntityMetafieldDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinition>(query);
            return this;
        }

        public PurchasingEntityMetafieldDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}