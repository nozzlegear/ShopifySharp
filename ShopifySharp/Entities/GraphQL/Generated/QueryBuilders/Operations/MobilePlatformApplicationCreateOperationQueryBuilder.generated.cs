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
    public sealed class MobilePlatformApplicationCreateOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationCreatePayload, MobilePlatformApplicationCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplicationCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MobilePlatformApplicationCreateArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationCreateOperationQueryBuilder Self => this;

        public MobilePlatformApplicationCreateOperationQueryBuilder() : this("mobilePlatformApplicationCreate")
        {
        }

        public MobilePlatformApplicationCreateOperationQueryBuilder(string name) : base(new Query<MobilePlatformApplicationCreatePayload>(name))
        {
            Arguments = new MobilePlatformApplicationCreateArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationCreateOperationQueryBuilder(IQuery<MobilePlatformApplicationCreatePayload> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationCreateArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationUserError>(query);
            return this;
        }

        public MobilePlatformApplicationCreateOperationQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}