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

        public MobilePlatformApplicationCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
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