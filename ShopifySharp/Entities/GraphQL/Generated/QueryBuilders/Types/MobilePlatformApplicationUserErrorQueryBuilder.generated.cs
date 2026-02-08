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
    public sealed class MobilePlatformApplicationUserErrorQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationUserError, MobilePlatformApplicationUserErrorQueryBuilder>
    {
        protected override MobilePlatformApplicationUserErrorQueryBuilder Self => this;

        public MobilePlatformApplicationUserErrorQueryBuilder() : this("mobilePlatformApplicationUserError")
        {
        }

        public MobilePlatformApplicationUserErrorQueryBuilder(string name) : base(new Query<MobilePlatformApplicationUserError>(name))
        {
        }

        public MobilePlatformApplicationUserErrorQueryBuilder(IQuery<MobilePlatformApplicationUserError> query) : base(query)
        {
        }

        public MobilePlatformApplicationUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MobilePlatformApplicationUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public MobilePlatformApplicationUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}