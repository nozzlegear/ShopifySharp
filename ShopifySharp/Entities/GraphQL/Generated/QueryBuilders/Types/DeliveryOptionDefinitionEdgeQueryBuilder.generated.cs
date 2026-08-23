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
    public sealed class DeliveryOptionDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<DeliveryOptionDefinitionEdge, DeliveryOptionDefinitionEdgeQueryBuilder>
    {
        protected override DeliveryOptionDefinitionEdgeQueryBuilder Self => this;

        public DeliveryOptionDefinitionEdgeQueryBuilder() : this("deliveryOptionDefinitionEdge")
        {
        }

        public DeliveryOptionDefinitionEdgeQueryBuilder(string name) : base(new Query<DeliveryOptionDefinitionEdge>(name))
        {
        }

        public DeliveryOptionDefinitionEdgeQueryBuilder(IQuery<DeliveryOptionDefinitionEdge> query) : base(query)
        {
        }

        public DeliveryOptionDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public DeliveryOptionDefinitionEdgeQueryBuilder Node(Action<DeliveryOptionDefinitionInterfaceCasesBuilder> build)
        {
            var query = new Query<IDeliveryOptionDefinition>("node");
            var unionBuilder = new DeliveryOptionDefinitionInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}