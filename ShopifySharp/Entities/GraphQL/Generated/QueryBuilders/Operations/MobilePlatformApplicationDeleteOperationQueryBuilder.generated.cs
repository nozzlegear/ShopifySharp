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
    public sealed class MobilePlatformApplicationDeleteOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationDeletePayload, MobilePlatformApplicationDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplicationDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public MobilePlatformApplicationDeleteArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationDeleteOperationQueryBuilder Self => this;

        public MobilePlatformApplicationDeleteOperationQueryBuilder() : this("mobilePlatformApplicationDelete")
        {
        }

        public MobilePlatformApplicationDeleteOperationQueryBuilder(string name) : base(new Query<MobilePlatformApplicationDeletePayload>(name))
        {
            Arguments = new MobilePlatformApplicationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationDeleteOperationQueryBuilder(IQuery<MobilePlatformApplicationDeletePayload> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationDeleteArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationDeleteOperationQueryBuilder DeletedMobilePlatformApplicationId()
        {
            base.InnerQuery.AddField("deletedMobilePlatformApplicationId");
            return this;
        }

        public MobilePlatformApplicationDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationUserError>(query);
            return this;
        }
    }
}