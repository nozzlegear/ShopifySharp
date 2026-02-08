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
    public sealed class GiftCardDeactivateUserErrorQueryBuilder : FieldsQueryBuilderBase<GiftCardDeactivateUserError, GiftCardDeactivateUserErrorQueryBuilder>
    {
        protected override GiftCardDeactivateUserErrorQueryBuilder Self => this;

        public GiftCardDeactivateUserErrorQueryBuilder() : this("giftCardDeactivateUserError")
        {
        }

        public GiftCardDeactivateUserErrorQueryBuilder(string name) : base(new Query<GiftCardDeactivateUserError>(name))
        {
        }

        public GiftCardDeactivateUserErrorQueryBuilder(IQuery<GiftCardDeactivateUserError> query) : base(query)
        {
        }

        public GiftCardDeactivateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public GiftCardDeactivateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public GiftCardDeactivateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}