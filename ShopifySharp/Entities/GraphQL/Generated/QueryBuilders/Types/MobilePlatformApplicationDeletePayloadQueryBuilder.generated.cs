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
    public sealed class MobilePlatformApplicationDeletePayloadQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationDeletePayload, MobilePlatformApplicationDeletePayloadQueryBuilder>
    {
        protected override MobilePlatformApplicationDeletePayloadQueryBuilder Self => this;

        public MobilePlatformApplicationDeletePayloadQueryBuilder() : this("mobilePlatformApplicationDeletePayload")
        {
        }

        public MobilePlatformApplicationDeletePayloadQueryBuilder(string name) : base(new Query<MobilePlatformApplicationDeletePayload>(name))
        {
        }

        public MobilePlatformApplicationDeletePayloadQueryBuilder(IQuery<MobilePlatformApplicationDeletePayload> query) : base(query)
        {
        }

        public MobilePlatformApplicationDeletePayloadQueryBuilder DeletedMobilePlatformApplicationId()
        {
            base.InnerQuery.AddField("deletedMobilePlatformApplicationId");
            return this;
        }

        public MobilePlatformApplicationDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationUserError>(query);
            return this;
        }
    }
}