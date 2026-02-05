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
    public sealed class DiscountAutomaticDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticDeactivatePayload, DiscountAutomaticDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticDeactivatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticDeactivateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticDeactivateOperationQueryBuilder Self => this;

        public DiscountAutomaticDeactivateOperationQueryBuilder() : this("discountAutomaticDeactivate")
        {
        }

        public DiscountAutomaticDeactivateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticDeactivatePayload>(name))
        {
            Arguments = new DiscountAutomaticDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticDeactivateOperationQueryBuilder(IQuery<DiscountAutomaticDeactivatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticDeactivateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}