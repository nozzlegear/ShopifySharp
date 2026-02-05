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
    public sealed class SellingPlanGroupUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupUpdatePayload, SellingPlanGroupUpdatePayloadQueryBuilder>
    {
        protected override SellingPlanGroupUpdatePayloadQueryBuilder Self => this;

        public SellingPlanGroupUpdatePayloadQueryBuilder() : this("sellingPlanGroupUpdatePayload")
        {
        }

        public SellingPlanGroupUpdatePayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupUpdatePayload>(name))
        {
        }

        public SellingPlanGroupUpdatePayloadQueryBuilder(IQuery<SellingPlanGroupUpdatePayload> query) : base(query)
        {
        }

        public SellingPlanGroupUpdatePayloadQueryBuilder DeletedSellingPlanIds()
        {
            base.InnerQuery.AddField("deletedSellingPlanIds");
            return this;
        }

        public SellingPlanGroupUpdatePayloadQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}