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
    public sealed class GiftCardProductSetUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardProductSetUserError, GiftCardProductSetUserErrorQueryBuilder>
    {
        protected override GiftCardProductSetUserErrorQueryBuilder Self => this;

        public GiftCardProductSetUserErrorQueryBuilder() : this("giftCardProductSetUserError")
        {
        }

        public GiftCardProductSetUserErrorQueryBuilder(string name) : base(new Query<GiftCardProductSetUserError>(name))
        {
        }

        public GiftCardProductSetUserErrorQueryBuilder(IQuery<GiftCardProductSetUserError> query) : base(query)
        {
        }

        public GiftCardProductSetUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardProductSetUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardProductSetUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}