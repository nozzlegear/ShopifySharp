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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class AndroidApplicationQueryBuilder : FieldsQueryBuilderBase<AndroidApplication, AndroidApplicationQueryBuilder>
    {
        protected override AndroidApplicationQueryBuilder Self => this;

        public AndroidApplicationQueryBuilder() : this("androidApplication")
        {
        }

        public AndroidApplicationQueryBuilder(string name) : base(new Query<AndroidApplication>(name))
        {
        }

        public AndroidApplicationQueryBuilder(IQuery<AndroidApplication> query) : base(query)
        {
        }

        public AndroidApplicationQueryBuilder ApplicationId()
        {
            base.InnerQuery.AddField("applicationId");
            return this;
        }

        public AndroidApplicationQueryBuilder AppLinksEnabled()
        {
            base.InnerQuery.AddField("appLinksEnabled");
            return this;
        }

        public AndroidApplicationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AndroidApplicationQueryBuilder Sha256CertFingerprints()
        {
            base.InnerQuery.AddField("sha256CertFingerprints");
            return this;
        }
    }
}