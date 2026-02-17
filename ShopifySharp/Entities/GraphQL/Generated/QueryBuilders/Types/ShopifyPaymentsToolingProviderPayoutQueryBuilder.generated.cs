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
    public sealed class ShopifyPaymentsToolingProviderPayoutQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsToolingProviderPayout, ShopifyPaymentsToolingProviderPayoutQueryBuilder>
    {
        protected override ShopifyPaymentsToolingProviderPayoutQueryBuilder Self => this;

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder() : this("shopifyPaymentsToolingProviderPayout")
        {
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder(string name) : base(new Query<ShopifyPaymentsToolingProviderPayout>(name))
        {
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder(IQuery<ShopifyPaymentsToolingProviderPayout> query) : base(query)
        {
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder ArrivalDate()
        {
            base.InnerQuery.AddField("arrivalDate");
            return this;
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public ShopifyPaymentsToolingProviderPayoutQueryBuilder RemoteId()
        {
            base.InnerQuery.AddField("remoteId");
            return this;
        }
    }
}