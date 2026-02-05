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
    public sealed class AppPurchaseOneTimeCreateOperationQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeCreatePayload, AppPurchaseOneTimeCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<AppPurchaseOneTimeCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public AppPurchaseOneTimeCreateArgumentsBuilder Arguments { get; }
        protected override AppPurchaseOneTimeCreateOperationQueryBuilder Self => this;

        public AppPurchaseOneTimeCreateOperationQueryBuilder() : this("appPurchaseOneTimeCreate")
        {
        }

        public AppPurchaseOneTimeCreateOperationQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeCreatePayload>(name))
        {
            Arguments = new AppPurchaseOneTimeCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppPurchaseOneTimeCreateOperationQueryBuilder(IQuery<AppPurchaseOneTimeCreatePayload> query) : base(query)
        {
            Arguments = new AppPurchaseOneTimeCreateArgumentsBuilder(base.InnerQuery);
        }

        public AppPurchaseOneTimeCreateOperationQueryBuilder AppPurchaseOneTime(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("appPurchaseOneTime");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }

        public AppPurchaseOneTimeCreateOperationQueryBuilder ConfirmationUrl()
        {
            base.InnerQuery.AddField("confirmationUrl");
            return this;
        }

        public AppPurchaseOneTimeCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}