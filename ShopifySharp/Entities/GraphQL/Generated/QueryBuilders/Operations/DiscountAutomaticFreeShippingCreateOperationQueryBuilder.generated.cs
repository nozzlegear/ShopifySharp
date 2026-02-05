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
    public sealed class DiscountAutomaticFreeShippingCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticFreeShippingCreatePayload, DiscountAutomaticFreeShippingCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticFreeShippingCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticFreeShippingCreateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticFreeShippingCreateOperationQueryBuilder Self => this;

        public DiscountAutomaticFreeShippingCreateOperationQueryBuilder() : this("discountAutomaticFreeShippingCreate")
        {
        }

        public DiscountAutomaticFreeShippingCreateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticFreeShippingCreatePayload>(name))
        {
            Arguments = new DiscountAutomaticFreeShippingCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticFreeShippingCreateOperationQueryBuilder(IQuery<DiscountAutomaticFreeShippingCreatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticFreeShippingCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticFreeShippingCreateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}