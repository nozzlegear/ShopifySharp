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
    public sealed class SellingPlanGroupCreatePayloadQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupCreatePayload, SellingPlanGroupCreatePayloadQueryBuilder>
    {
        protected override SellingPlanGroupCreatePayloadQueryBuilder Self => this;

        public SellingPlanGroupCreatePayloadQueryBuilder() : this("sellingPlanGroupCreatePayload")
        {
        }

        public SellingPlanGroupCreatePayloadQueryBuilder(string name) : base(new Query<SellingPlanGroupCreatePayload>(name))
        {
        }

        public SellingPlanGroupCreatePayloadQueryBuilder(IQuery<SellingPlanGroupCreatePayload> query) : base(query)
        {
        }

        public SellingPlanGroupCreatePayloadQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}