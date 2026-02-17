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
    public sealed class FulfillmentConstraintRuleQueryBuilder : FieldsQueryBuilderBase<FulfillmentConstraintRule, FulfillmentConstraintRuleQueryBuilder>
    {
        protected override FulfillmentConstraintRuleQueryBuilder Self => this;

        public FulfillmentConstraintRuleQueryBuilder() : this("fulfillmentConstraintRule")
        {
        }

        public FulfillmentConstraintRuleQueryBuilder(string name) : base(new Query<FulfillmentConstraintRule>(name))
        {
        }

        public FulfillmentConstraintRuleQueryBuilder(IQuery<FulfillmentConstraintRule> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleQueryBuilder DeliveryMethodTypes()
        {
            base.InnerQuery.AddField("deliveryMethodTypes");
            return this;
        }

        public FulfillmentConstraintRuleQueryBuilder Function(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder> build)
        {
            var query = new Query<ShopifyFunction>("function");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyFunctionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyFunction>(query);
            return this;
        }

        public FulfillmentConstraintRuleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentConstraintRuleQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public FulfillmentConstraintRuleQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }
    }
}