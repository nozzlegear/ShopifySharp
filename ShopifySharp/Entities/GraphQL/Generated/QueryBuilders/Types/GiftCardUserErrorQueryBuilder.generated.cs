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
    public sealed class GiftCardUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardUserError, GiftCardUserErrorQueryBuilder>
    {
        protected override GiftCardUserErrorQueryBuilder Self => this;

        public GiftCardUserErrorQueryBuilder() : this("giftCardUserError")
        {
        }

        public GiftCardUserErrorQueryBuilder(string name) : base(new Query<GiftCardUserError>(name))
        {
        }

        public GiftCardUserErrorQueryBuilder(IQuery<GiftCardUserError> query) : base(query)
        {
        }

        public GiftCardUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}