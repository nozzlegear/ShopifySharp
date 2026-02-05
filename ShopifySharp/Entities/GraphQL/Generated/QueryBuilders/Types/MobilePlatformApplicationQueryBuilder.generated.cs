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
    public sealed class MobilePlatformApplicationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplication, MobilePlatformApplicationQueryBuilder>
    {
        protected override MobilePlatformApplicationQueryBuilder Self => this;

        public MobilePlatformApplicationQueryBuilder() : this("mobilePlatformApplication")
        {
        }

        public MobilePlatformApplicationQueryBuilder(string name) : base(new Query<MobilePlatformApplication>(name))
        {
        }

        public MobilePlatformApplicationQueryBuilder(IQuery<MobilePlatformApplication> query) : base(query)
        {
        }

        public MobilePlatformApplicationQueryBuilder MobilePlatformApplication(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("mobilePlatformApplication");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}