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
    public sealed class TransactionFeeQueryBuilder : FieldsQueryBuilderBase<TransactionFee, TransactionFeeQueryBuilder>
    {
        protected override TransactionFeeQueryBuilder Self => this;

        public TransactionFeeQueryBuilder() : this("transactionFee")
        {
        }

        public TransactionFeeQueryBuilder(string name) : base(new Query<TransactionFee>(name))
        {
        }

        public TransactionFeeQueryBuilder(IQuery<TransactionFee> query) : base(query)
        {
        }

        public TransactionFeeQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public TransactionFeeQueryBuilder FlatFee(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("flatFee");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public TransactionFeeQueryBuilder FlatFeeName()
        {
            base.InnerQuery.AddField("flatFeeName");
            return this;
        }

        public TransactionFeeQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TransactionFeeQueryBuilder Rate()
        {
            base.InnerQuery.AddField("rate");
            return this;
        }

        public TransactionFeeQueryBuilder RateName()
        {
            base.InnerQuery.AddField("rateName");
            return this;
        }

        public TransactionFeeQueryBuilder TaxAmount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("taxAmount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public TransactionFeeQueryBuilder Type()
        {
            base.InnerQuery.AddField("type");
            return this;
        }
    }
}