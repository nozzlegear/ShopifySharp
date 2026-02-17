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
    public sealed class DiscountCodeFreeShippingUpdateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountCodeFreeShippingUpdatePayload, DiscountCodeFreeShippingUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountCodeFreeShippingUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountCodeFreeShippingUpdateArgumentsBuilder Arguments { get; }
        protected override DiscountCodeFreeShippingUpdateOperationQueryBuilder Self => this;

        public DiscountCodeFreeShippingUpdateOperationQueryBuilder() : this("discountCodeFreeShippingUpdate")
        {
        }

        public DiscountCodeFreeShippingUpdateOperationQueryBuilder(string name) : base(new Query<DiscountCodeFreeShippingUpdatePayload>(name))
        {
            Arguments = new DiscountCodeFreeShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeFreeShippingUpdateOperationQueryBuilder(IQuery<DiscountCodeFreeShippingUpdatePayload> query) : base(query)
        {
            Arguments = new DiscountCodeFreeShippingUpdateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeFreeShippingUpdateOperationQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeFreeShippingUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}