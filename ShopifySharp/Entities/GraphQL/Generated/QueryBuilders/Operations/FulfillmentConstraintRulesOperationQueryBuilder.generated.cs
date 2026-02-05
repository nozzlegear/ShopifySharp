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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class FulfillmentConstraintRulesOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRule, FulfillmentConstraintRulesOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentConstraintRule>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override FulfillmentConstraintRulesOperationQueryBuilder Self => this;

        public FulfillmentConstraintRulesOperationQueryBuilder() : this("fulfillmentConstraintRules")
        {
        }

        public FulfillmentConstraintRulesOperationQueryBuilder(string name) : base(new Query<FulfillmentConstraintRule>(name))
        {
        }

        public FulfillmentConstraintRulesOperationQueryBuilder(IQuery<FulfillmentConstraintRule> query) : base(query)
        {
        }

        public FulfillmentConstraintRulesOperationQueryBuilder DeliveryMethodTypes()
        {
            base.InnerQuery.AddField("deliveryMethodTypes");
            return this;
        }

        public FulfillmentConstraintRulesOperationQueryBuilder Function(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("function");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public FulfillmentConstraintRulesOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentConstraintRulesOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public FulfillmentConstraintRulesOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }
    }
}