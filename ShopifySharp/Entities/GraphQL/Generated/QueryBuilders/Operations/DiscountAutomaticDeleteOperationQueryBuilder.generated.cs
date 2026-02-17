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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class DiscountAutomaticDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticDeletePayload, DiscountAutomaticDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticDeleteArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticDeleteOperationQueryBuilder Self => this;

        public DiscountAutomaticDeleteOperationQueryBuilder() : this("discountAutomaticDelete")
        {
        }

        public DiscountAutomaticDeleteOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticDeletePayload>(name))
        {
            Arguments = new DiscountAutomaticDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticDeleteOperationQueryBuilder(IQuery<DiscountAutomaticDeletePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticDeleteOperationQueryBuilder DeletedAutomaticDiscountId()
        {
            base.InnerQuery.AddField("deletedAutomaticDiscountId");
            return this;
        }

        public DiscountAutomaticDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}