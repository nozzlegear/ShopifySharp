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
    public sealed class DiscountCodeDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeDeactivatePayload, DiscountCodeDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeDeactivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeDeactivateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeDeactivateOperationQueryBuilder Self => this;

        public DiscountCodeDeactivateOperationQueryBuilder() : this("discountCodeDeactivate")
        {
        }

        public DiscountCodeDeactivateOperationQueryBuilder(string name) : base(new Query<DiscountCodeDeactivatePayload>(name))
        {
            Arguments = new DiscountCodeDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeDeactivateOperationQueryBuilder(IQuery<DiscountCodeDeactivatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeDeactivateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}