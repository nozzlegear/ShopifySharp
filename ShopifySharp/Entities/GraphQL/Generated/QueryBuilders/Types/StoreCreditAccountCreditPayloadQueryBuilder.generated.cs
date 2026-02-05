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
    public sealed class StoreCreditAccountCreditPayloadQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountCreditPayload, StoreCreditAccountCreditPayloadQueryBuilder>
    {
        protected override StoreCreditAccountCreditPayloadQueryBuilder Self => this;

        public StoreCreditAccountCreditPayloadQueryBuilder() : this("storeCreditAccountCreditPayload")
        {
        }

        public StoreCreditAccountCreditPayloadQueryBuilder(string name) : base(new Query<StoreCreditAccountCreditPayload>(name))
        {
        }

        public StoreCreditAccountCreditPayloadQueryBuilder(IQuery<StoreCreditAccountCreditPayload> query) : base(query)
        {
        }

        public StoreCreditAccountCreditPayloadQueryBuilder StoreCreditAccountTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("storeCreditAccountTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountCreditTransaction>(query);
            return this;
        }

        public StoreCreditAccountCreditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditUserErrorQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountCreditUserError>(query);
            return this;
        }
    }
}