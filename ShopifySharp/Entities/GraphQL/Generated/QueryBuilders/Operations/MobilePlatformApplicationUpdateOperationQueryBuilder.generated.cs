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
    public sealed class MobilePlatformApplicationUpdateOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationUpdatePayload, MobilePlatformApplicationUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplicationUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MobilePlatformApplicationUpdateArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationUpdateOperationQueryBuilder Self => this;

        public MobilePlatformApplicationUpdateOperationQueryBuilder() : this("mobilePlatformApplicationUpdate")
        {
        }

        public MobilePlatformApplicationUpdateOperationQueryBuilder(string name) : base(new Query<MobilePlatformApplicationUpdatePayload>(name))
        {
            Arguments = new MobilePlatformApplicationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationUpdateOperationQueryBuilder(IQuery<MobilePlatformApplicationUpdatePayload> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationUpdateArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationUserError>(query);
            return this;
        }

        public MobilePlatformApplicationUpdateOperationQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}