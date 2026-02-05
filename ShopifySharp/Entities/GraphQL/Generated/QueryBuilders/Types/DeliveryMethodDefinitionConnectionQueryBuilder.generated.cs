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
    public sealed class DeliveryMethodDefinitionConnectionQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinitionConnection, DeliveryMethodDefinitionConnectionQueryBuilder>
    {
        protected override DeliveryMethodDefinitionConnectionQueryBuilder Self => this;

        public DeliveryMethodDefinitionConnectionQueryBuilder() : this("deliveryMethodDefinitionConnection")
        {
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder(string name) : base(new Query<DeliveryMethodDefinitionConnection>(name))
        {
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder(IQuery<DeliveryMethodDefinitionConnection> query) : base(query)
        {
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinitionEdge>(query);
            return this;
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinition>(query);
            return this;
        }

        public DeliveryMethodDefinitionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}