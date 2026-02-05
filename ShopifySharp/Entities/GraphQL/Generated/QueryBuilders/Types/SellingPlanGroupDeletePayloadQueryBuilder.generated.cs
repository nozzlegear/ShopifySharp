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
    public sealed class SellingPlanGroupDeletePayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupDeletePayload, SellingPlanGroupDeletePayloadQueryBuilder>
    {
        protected override SellingPlanGroupDeletePayloadQueryBuilder Self => this;

        public SellingPlanGroupDeletePayloadQueryBuilder() : this("sellingPlanGroupDeletePayload")
        {
        }

        public SellingPlanGroupDeletePayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupDeletePayload>(name))
        {
        }

        public SellingPlanGroupDeletePayloadQueryBuilder(IQuery<SellingPlanGroupDeletePayload> query) : base(query)
        {
        }

        public SellingPlanGroupDeletePayloadQueryBuilder DeletedSellingPlanGroupId()
        {
            base.InnerQuery.AddField("deletedSellingPlanGroupId");
            return this;
        }

        public SellingPlanGroupDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}