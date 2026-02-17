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
    public sealed class DiscountCodeBxgyUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBxgyUpdatePayload, DiscountCodeBxgyUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBxgyUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBxgyUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBxgyUpdateOperationQueryBuilder Self => this;

        public DiscountCodeBxgyUpdateOperationQueryBuilder() : this("discountCodeBxgyUpdate")
        {
        }

        public DiscountCodeBxgyUpdateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBxgyUpdatePayload>(name))
        {
            Arguments = new DiscountCodeBxgyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBxgyUpdateOperationQueryBuilder(IQuery<DiscountCodeBxgyUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBxgyUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBxgyUpdateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeBxgyUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}