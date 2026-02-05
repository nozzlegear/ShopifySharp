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
    public sealed class DiscountCodeBasicUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBasicUpdatePayload, DiscountCodeBasicUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBasicUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBasicUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBasicUpdateOperationQueryBuilder Self => this;

        public DiscountCodeBasicUpdateOperationQueryBuilder() : this("discountCodeBasicUpdate")
        {
        }

        public DiscountCodeBasicUpdateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBasicUpdatePayload>(name))
        {
            Arguments = new DiscountCodeBasicUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBasicUpdateOperationQueryBuilder(IQuery<DiscountCodeBasicUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBasicUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBasicUpdateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeBasicUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}