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
    public sealed class MarketingActivityUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityUpdatePayload, MarketingActivityUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MarketingActivityUpdateArgumentsBuilder Arguments { get; }
        protected override MarketingActivityUpdateOperationQueryBuilder Self => this;

        public MarketingActivityUpdateOperationQueryBuilder() : this("marketingActivityUpdate")
        {
        }

        public MarketingActivityUpdateOperationQueryBuilder(string name) : base(new Query<MarketingActivityUpdatePayload>(name))
        {
            Arguments = new MarketingActivityUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpdateOperationQueryBuilder(IQuery<MarketingActivityUpdatePayload> query) : base(query)
        {
            Arguments = new MarketingActivityUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityUpdateOperationQueryBuilder MarketingActivity(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("marketingActivity");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityUpdateOperationQueryBuilder RedirectPath()
        {
            base.InnerQuery.AddField("redirectPath");
            return this;
        }

        public MarketingActivityUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}