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
    public sealed class SellingPlanGroupDeleteOperationQueryBuilder : FieldsQueryBuilderBase<SellingPlanGroupDeletePayload, SellingPlanGroupDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<SellingPlanGroupDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SellingPlanGroupDeleteArgumentsBuilder Arguments { get; }
        protected override SellingPlanGroupDeleteOperationQueryBuilder Self => this;

        public SellingPlanGroupDeleteOperationQueryBuilder() : this("sellingPlanGroupDelete")
        {
        }

        public SellingPlanGroupDeleteOperationQueryBuilder(string name) : base(new Query<SellingPlanGroupDeletePayload>(name))
        {
            Arguments = new SellingPlanGroupDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupDeleteOperationQueryBuilder(IQuery<SellingPlanGroupDeletePayload> query) : base(query)
        {
            Arguments = new SellingPlanGroupDeleteArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanGroupDeleteOperationQueryBuilder DeletedSellingPlanGroupId()
        {
            base.InnerQuery.AddField("deletedSellingPlanGroupId");
            return this;
        }

        public SellingPlanGroupDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder> build)
        {
            var query = new Query<SellingPlanGroupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SellingPlanGroupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SellingPlanGroupUserError>(query);
            return this;
        }
    }
}