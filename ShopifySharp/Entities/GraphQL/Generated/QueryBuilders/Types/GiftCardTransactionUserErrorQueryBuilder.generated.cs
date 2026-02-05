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
    public sealed class GiftCardTransactionUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardTransactionUserError, GiftCardTransactionUserErrorQueryBuilder>
    {
        protected override GiftCardTransactionUserErrorQueryBuilder Self => this;

        public GiftCardTransactionUserErrorQueryBuilder() : this("giftCardTransactionUserError")
        {
        }

        public GiftCardTransactionUserErrorQueryBuilder(string name) : base(new Query<GiftCardTransactionUserError>(name))
        {
        }

        public GiftCardTransactionUserErrorQueryBuilder(IQuery<GiftCardTransactionUserError> query) : base(query)
        {
        }

        public GiftCardTransactionUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardTransactionUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardTransactionUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}