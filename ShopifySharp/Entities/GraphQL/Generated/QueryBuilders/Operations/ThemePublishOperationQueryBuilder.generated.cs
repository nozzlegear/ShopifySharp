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
    public sealed class ThemePublishOperationQueryBuilder : FieldsQueryBuilderBase<ThemePublishPayload, ThemePublishOperationQueryBuilder>, IGraphOperationQueryBuilder<ThemePublishPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ThemePublishArgumentsBuilder Arguments { get; }
        protected override ThemePublishOperationQueryBuilder Self => this;

        public ThemePublishOperationQueryBuilder() : this("themePublish")
        {
        }

        public ThemePublishOperationQueryBuilder(string name) : base(new Query<ThemePublishPayload>(name))
        {
            Arguments = new ThemePublishArgumentsBuilder(base.InnerQuery);
        }

        public ThemePublishOperationQueryBuilder(IQuery<ThemePublishPayload> query) : base(query)
        {
            Arguments = new ThemePublishArgumentsBuilder(base.InnerQuery);
        }

        public ThemePublishOperationQueryBuilder Theme(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("theme");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public ThemePublishOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ThemePublishUserErrorQueryBuilder> build)
        {
            var query = new Query<ThemePublishUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ThemePublishUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ThemePublishUserError>(query);
            return this;
        }
    }
}