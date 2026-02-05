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
    public sealed class DiscountAutomaticBasicCreateOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBasicCreatePayload, DiscountAutomaticBasicCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomaticBasicCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DiscountAutomaticBasicCreateArgumentsBuilder Arguments { get; }
        protected override DiscountAutomaticBasicCreateOperationQueryBuilder Self => this;

        public DiscountAutomaticBasicCreateOperationQueryBuilder() : this("discountAutomaticBasicCreate")
        {
        }

        public DiscountAutomaticBasicCreateOperationQueryBuilder(string name) : base(new Query<DiscountAutomaticBasicCreatePayload>(name))
        {
            Arguments = new DiscountAutomaticBasicCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBasicCreateOperationQueryBuilder(IQuery<DiscountAutomaticBasicCreatePayload> query) : base(query)
        {
            Arguments = new DiscountAutomaticBasicCreateArgumentsBuilder(base.InnerQuery);
        }

        public DiscountAutomaticBasicCreateOperationQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticBasicCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}