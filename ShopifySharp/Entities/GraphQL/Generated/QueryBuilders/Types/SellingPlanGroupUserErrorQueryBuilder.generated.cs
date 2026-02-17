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
    public sealed class SellingPlanGroupUserErrorQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupUserError, SellingPlanGroupUserErrorQueryBuilder>
    {
        protected override SellingPlanGroupUserErrorQueryBuilder Self => this;

        public SellingPlanGroupUserErrorQueryBuilder() : this("sellingPlanGroupUserError")
        {
        }

        public SellingPlanGroupUserErrorQueryBuilder(string name) : base(new Query<SellingPlanGroupUserError>(name))
        {
        }

        public SellingPlanGroupUserErrorQueryBuilder(IQuery<SellingPlanGroupUserError> query) : base(query)
        {
        }

        public SellingPlanGroupUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SellingPlanGroupUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public SellingPlanGroupUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}