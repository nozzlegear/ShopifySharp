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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class GiftCardConfigurationOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardConfiguration, GiftCardConfigurationOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardConfiguration>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override GiftCardConfigurationOperationQueryBuilder Self => this;

        public GiftCardConfigurationOperationQueryBuilder() : this("giftCardConfiguration")
        {
        }

        public GiftCardConfigurationOperationQueryBuilder(string name) : base(new Query<GiftCardConfiguration>(name))
        {
        }

        public GiftCardConfigurationOperationQueryBuilder(IQuery<GiftCardConfiguration> query) : base(query)
        {
        }

        public GiftCardConfigurationOperationQueryBuilder IssueLimit(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("issueLimit");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardConfigurationOperationQueryBuilder PurchaseLimit(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("purchaseLimit");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }
    }
}