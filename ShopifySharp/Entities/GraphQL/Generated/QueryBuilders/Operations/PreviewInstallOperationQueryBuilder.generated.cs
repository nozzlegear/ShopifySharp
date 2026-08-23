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
    public sealed class PreviewInstallOperationQueryBuilder : FieldsQueryBuilderBase<PreviewInstallPayload, PreviewInstallOperationQueryBuilder>, IGraphOperationQueryBuilder<PreviewInstallPayload>, IHasArguments<PreviewInstallArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PreviewInstallArgumentsBuilder Arguments { get; }
        protected override PreviewInstallOperationQueryBuilder Self => this;

        public PreviewInstallOperationQueryBuilder() : this("previewInstall")
        {
        }

        public PreviewInstallOperationQueryBuilder(string name) : base(new Query<PreviewInstallPayload>(name))
        {
            Arguments = new PreviewInstallArgumentsBuilder(base.InnerQuery);
        }

        public PreviewInstallOperationQueryBuilder(IQuery<PreviewInstallPayload> query) : base(query)
        {
            Arguments = new PreviewInstallArgumentsBuilder(base.InnerQuery);
        }

        public PreviewInstallOperationQueryBuilder SetArguments(Action<PreviewInstallArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PreviewInstallOperationQueryBuilder NewTheme(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder> build)
        {
            var query = new Query<OnlineStoreTheme>("newTheme");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OnlineStoreThemeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OnlineStoreTheme>(query);
            return this;
        }

        public PreviewInstallOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PreviewInstallUserErrorQueryBuilder> build)
        {
            var query = new Query<PreviewInstallUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PreviewInstallUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PreviewInstallUserError>(query);
            return this;
        }
    }
}