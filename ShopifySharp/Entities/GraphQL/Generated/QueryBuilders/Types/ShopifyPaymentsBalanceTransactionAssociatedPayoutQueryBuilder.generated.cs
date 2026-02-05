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
    public sealed class ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsBalanceTransactionAssociatedPayout, ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder>
    {
        protected override ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder Self => this;

        public ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder() : this("shopifyPaymentsBalanceTransactionAssociatedPayout")
        {
        }

        public ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder(string name) : base(new Query<ShopifyPaymentsBalanceTransactionAssociatedPayout>(name))
        {
        }

        public ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder(IQuery<ShopifyPaymentsBalanceTransactionAssociatedPayout> query) : base(query)
        {
        }

        public ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsBalanceTransactionAssociatedPayoutQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}