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
    public sealed class DiscountCodeBasicCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeBasicCreatePayload, DiscountCodeBasicCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeBasicCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeBasicCreateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeBasicCreateOperationQueryBuilder Self => this;

        public DiscountCodeBasicCreateOperationQueryBuilder() : this("discountCodeBasicCreate")
        {
        }

        public DiscountCodeBasicCreateOperationQueryBuilder(string name) : base(new Query<DiscountCodeBasicCreatePayload>(name))
        {
            Arguments = new DiscountCodeBasicCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBasicCreateOperationQueryBuilder(IQuery<DiscountCodeBasicCreatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeBasicCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeBasicCreateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeBasicCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}