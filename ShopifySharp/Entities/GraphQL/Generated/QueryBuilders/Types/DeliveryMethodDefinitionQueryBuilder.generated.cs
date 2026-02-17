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
    public sealed class DeliveryMethodDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryMethodDefinition, DeliveryMethodDefinitionQueryBuilder>
    {
        protected override DeliveryMethodDefinitionQueryBuilder Self => this;

        public DeliveryMethodDefinitionQueryBuilder() : this("deliveryMethodDefinition")
        {
        }

        public DeliveryMethodDefinitionQueryBuilder(string name) : base(new Query<DeliveryMethodDefinition>(name))
        {
        }

        public DeliveryMethodDefinitionQueryBuilder(IQuery<DeliveryMethodDefinition> query) : base(query)
        {
        }

        public DeliveryMethodDefinitionQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public DeliveryMethodDefinitionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public DeliveryMethodDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryMethodDefinitionQueryBuilder MethodConditions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryConditionQueryBuilder> build)
        {
            var query = new Query<DeliveryCondition>("methodConditions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryConditionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryCondition>(query);
            return this;
        }

        public DeliveryMethodDefinitionQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public DeliveryMethodDefinitionQueryBuilder RateProvider(Action<DeliveryRateProviderUnionCasesBuilder> build)
        {
            var query = new Query<DeliveryRateProvider>("rateProvider");
            var unionBuilder = new DeliveryRateProviderUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}