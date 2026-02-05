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
    public sealed class MobilePlatformApplicationUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationUpdatePayload, MobilePlatformApplicationUpdatePayloadQueryBuilder>
    {
        protected override MobilePlatformApplicationUpdatePayloadQueryBuilder Self => this;

        public MobilePlatformApplicationUpdatePayloadQueryBuilder() : this("mobilePlatformApplicationUpdatePayload")
        {
        }

        public MobilePlatformApplicationUpdatePayloadQueryBuilder(string name) : base(new Query<MobilePlatformApplicationUpdatePayload>(name))
        {
        }

        public MobilePlatformApplicationUpdatePayloadQueryBuilder(IQuery<MobilePlatformApplicationUpdatePayload> query) : base(query)
        {
        }

        public MobilePlatformApplicationUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MobilePlatformApplicationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationUserError>(query);
            return this;
        }

        public MobilePlatformApplicationUpdatePayloadQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}