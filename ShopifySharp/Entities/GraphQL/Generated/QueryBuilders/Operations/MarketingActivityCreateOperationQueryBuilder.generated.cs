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
    public sealed class MarketingActivityCreateOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityCreatePayload, MarketingActivityCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityCreateArgumentsBuilder Arguments { get; }
        protected override MarketingActivityCreateOperationQueryBuilder Self => this;

        public MarketingActivityCreateOperationQueryBuilder() : this("marketingActivityCreate")
        {
        }

        public MarketingActivityCreateOperationQueryBuilder(string name) : base(new Query<MarketingActivityCreatePayload>(name))
        {
            Arguments = new MarketingActivityCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityCreateOperationQueryBuilder(IQuery<MarketingActivityCreatePayload> query) : base(query)
        {
            Arguments = new MarketingActivityCreateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityCreateOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        [Obsolete("Marketing activity app extensions are deprecated and will be removed in the near future.")]
        public MarketingActivityCreateOperationQueryBuilder RedirectPath()
        {
            base.InnerQuery.AddField("redirectPath");
            return this;
        }

        public MarketingActivityCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}