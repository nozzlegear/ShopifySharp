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
    public sealed class DiscountCodeDeleteOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeDeletePayload, DiscountCodeDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeDeleteArgumentsBuilder Arguments { get; }
        protected override DiscountCodeDeleteOperationQueryBuilder Self => this;

        public DiscountCodeDeleteOperationQueryBuilder() : this("discountCodeDelete")
        {
        }

        public DiscountCodeDeleteOperationQueryBuilder(string name) : base(new Query<DiscountCodeDeletePayload>(name))
        {
            Arguments = new DiscountCodeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeDeleteOperationQueryBuilder(IQuery<DiscountCodeDeletePayload> query) : base(query)
        {
            Arguments = new DiscountCodeDeleteArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeDeleteOperationQueryBuilder DeletedCodeDiscountId()
        {
            base.InnerQuery.AddField("deletedCodeDiscountId");
            return this;
        }

        public DiscountCodeDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}