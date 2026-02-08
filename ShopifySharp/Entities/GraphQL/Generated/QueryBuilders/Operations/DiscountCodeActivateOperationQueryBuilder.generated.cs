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
    public sealed class DiscountCodeActivateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeActivatePayload, DiscountCodeActivateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeActivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeActivateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeActivateOperationQueryBuilder Self => this;

        public DiscountCodeActivateOperationQueryBuilder() : this("discountCodeActivate")
        {
        }

        public DiscountCodeActivateOperationQueryBuilder(string name) : base(new Query<DiscountCodeActivatePayload>(name))
        {
            Arguments = new DiscountCodeActivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeActivateOperationQueryBuilder(IQuery<DiscountCodeActivatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeActivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeActivateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeActivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}