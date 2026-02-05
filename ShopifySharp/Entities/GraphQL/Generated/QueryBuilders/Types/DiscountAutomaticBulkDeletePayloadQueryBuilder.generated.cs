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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class DiscountAutomaticBulkDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticBulkDeletePayload, DiscountAutomaticBulkDeletePayloadQueryBuilder>
    {
        protected override DiscountAutomaticBulkDeletePayloadQueryBuilder Self => this;

        public DiscountAutomaticBulkDeletePayloadQueryBuilder() : this("discountAutomaticBulkDeletePayload")
        {
        }

        public DiscountAutomaticBulkDeletePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticBulkDeletePayload>(name))
        {
        }

        public DiscountAutomaticBulkDeletePayloadQueryBuilder(IQuery<DiscountAutomaticBulkDeletePayload> query) : base(query)
        {
        }

        public DiscountAutomaticBulkDeletePayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public DiscountAutomaticBulkDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}