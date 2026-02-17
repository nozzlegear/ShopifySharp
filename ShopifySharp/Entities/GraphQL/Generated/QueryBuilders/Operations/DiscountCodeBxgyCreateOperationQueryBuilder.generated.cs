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
    public sealed class DiscountCodeBxgyCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBxgyCreatePayload, DiscountCodeBxgyCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBxgyCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBxgyCreateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBxgyCreateOperationQueryBuilder Self => this;

        public DiscountCodeBxgyCreateOperationQueryBuilder() : this("discountCodeBxgyCreate")
        {
        }

        public DiscountCodeBxgyCreateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBxgyCreatePayload>(name))
        {
            Arguments = new DiscountCodeBxgyCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBxgyCreateOperationQueryBuilder(IQuery<DiscountCodeBxgyCreatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBxgyCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBxgyCreateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeBxgyCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}