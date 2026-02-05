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
    public sealed class StoreCreditAccountDebitPayloadQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountDebitPayload, StoreCreditAccountDebitPayloadQueryBuilder>
    {
        protected override StoreCreditAccountDebitPayloadQueryBuilder Self => this;

        public StoreCreditAccountDebitPayloadQueryBuilder() : this("storeCreditAccountDebitPayload")
        {
        }

        public StoreCreditAccountDebitPayloadQueryBuilder(string name) : base(new Query<StoreCreditAccountDebitPayload>(name))
        {
        }

        public StoreCreditAccountDebitPayloadQueryBuilder(IQuery<StoreCreditAccountDebitPayload> query) : base(query)
        {
        }

        public StoreCreditAccountDebitPayloadQueryBuilder StoreCreditAccountTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("storeCreditAccountTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountDebitTransaction>(query);
            return this;
        }

        public StoreCreditAccountDebitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitUserErrorQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountDebitUserError>(query);
            return this;
        }
    }
}