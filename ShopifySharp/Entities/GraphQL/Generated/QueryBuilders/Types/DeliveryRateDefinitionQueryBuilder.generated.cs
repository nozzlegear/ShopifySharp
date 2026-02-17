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
    public sealed class DeliveryRateDefinitionQueryBuilder : FieldsQueryBuilderBase<DeliveryRateDefinition, DeliveryRateDefinitionQueryBuilder>
    {
        protected override DeliveryRateDefinitionQueryBuilder Self => this;

        public DeliveryRateDefinitionQueryBuilder() : this("deliveryRateDefinition")
        {
        }

        public DeliveryRateDefinitionQueryBuilder(string name) : base(new Query<DeliveryRateDefinition>(name))
        {
        }

        public DeliveryRateDefinitionQueryBuilder(IQuery<DeliveryRateDefinition> query) : base(query)
        {
        }

        public DeliveryRateDefinitionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public DeliveryRateDefinitionQueryBuilder Price(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("price");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}