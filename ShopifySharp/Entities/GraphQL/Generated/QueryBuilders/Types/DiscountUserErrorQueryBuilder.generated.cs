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
    public sealed class DiscountUserErrorQueryBuilder : FieldsQueryBuilderBase<DiscountUserError, DiscountUserErrorQueryBuilder>
    {
        protected override DiscountUserErrorQueryBuilder Self => this;

        public DiscountUserErrorQueryBuilder() : this("discountUserError")
        {
        }

        public DiscountUserErrorQueryBuilder(string name) : base(new Query<DiscountUserError>(name))
        {
        }

        public DiscountUserErrorQueryBuilder(IQuery<DiscountUserError> query) : base(query)
        {
        }

        public DiscountUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public DiscountUserErrorQueryBuilder ExtraInfo()
        {
            base.InnerQuery.AddField("extraInfo");
            return this;
        }

        public DiscountUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public DiscountUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}