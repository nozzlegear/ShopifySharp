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
    public sealed class MobilePlatformApplicationUnionCasesBuilder : UnionCasesBuilderBase<MobilePlatformApplication, MobilePlatformApplicationUnionCasesBuilder>
    {
        protected override MobilePlatformApplicationUnionCasesBuilder Self => this;

        public MobilePlatformApplicationUnionCasesBuilder(string fieldName = "mobilePlatformApplication") : this(new Query<MobilePlatformApplication>(fieldName))
        {
        }

        public MobilePlatformApplicationUnionCasesBuilder(IQuery<MobilePlatformApplication> query) : base(query)
        {
        }

        public MobilePlatformApplicationUnionCasesBuilder OnAndroidApplication(Action<AndroidApplicationQueryBuilder> build)
        {
            var query = new Query<AndroidApplication>("... on AndroidApplication");
            var queryBuilder = new AndroidApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public MobilePlatformApplicationUnionCasesBuilder OnAppleApplication(Action<AppleApplicationQueryBuilder> build)
        {
            var query = new Query<AppleApplication>("... on AppleApplication");
            var queryBuilder = new AppleApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}