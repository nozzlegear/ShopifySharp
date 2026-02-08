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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SellingPlanGroupCreateOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupCreatePayload, SellingPlanGroupCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupCreateArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupCreateOperationQueryBuilder Self => this;

        public SellingPlanGroupCreateOperationQueryBuilder() : this("sellingPlanGroupCreate")
        {
        }

        public SellingPlanGroupCreateOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupCreatePayload>(name))
        {
            Arguments = new SellingPlanGroupCreateArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupCreateOperationQueryBuilder(IQuery<SellingPlanGroupCreatePayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupCreateArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupCreateOperationQueryBuilder SellingPlanGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroup>("sellingPlanGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroup>(query);
            return this;
        }

        public SellingPlanGroupCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}