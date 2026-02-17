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
    public sealed class DeliveryMethodDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinitionEdge, DeliveryMethodDefinitionEdgeQueryBuilder>
    {
        protected override DeliveryMethodDefinitionEdgeQueryBuilder Self => this;

        public DeliveryMethodDefinitionEdgeQueryBuilder() : this("deliveryMethodDefinitionEdge")
        {
        }

        public DeliveryMethodDefinitionEdgeQueryBuilder(string name) : base(new Query<DeliveryMethodDefinitionEdge>(name))
        {
        }

        public DeliveryMethodDefinitionEdgeQueryBuilder(IQuery<DeliveryMethodDefinitionEdge> query) : base(query)
        {
        }

        public DeliveryMethodDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryMethodDefinitionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder> build)
        {
            var query = new Query<DeliveryMethodDefinition>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethodDefinition>(query);
            return this;
        }
    }
}