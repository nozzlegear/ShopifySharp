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
    public sealed class UTMParametersQueryBuilder : FieldsQueryBuilderBase<UTMParameters, UTMParametersQueryBuilder>
    {
        protected override UTMParametersQueryBuilder Self => this;

        public UTMParametersQueryBuilder() : this("uTMParameters")
        {
        }

        public UTMParametersQueryBuilder(string name) : base(new Query<UTMParameters>(name))
        {
        }

        public UTMParametersQueryBuilder(IQuery<UTMParameters> query) : base(query)
        {
        }

        public UTMParametersQueryBuilder Campaign()
        {
            base.InnerQuery.AddField("campaign");
            return this;
        }

        public UTMParametersQueryBuilder Content()
        {
            base.InnerQuery.AddField("content");
            return this;
        }

        public UTMParametersQueryBuilder Medium()
        {
            base.InnerQuery.AddField("medium");
            return this;
        }

        public UTMParametersQueryBuilder Source()
        {
            base.InnerQuery.AddField("source");
            return this;
        }

        public UTMParametersQueryBuilder Term()
        {
            base.InnerQuery.AddField("term");
            return this;
        }
    }
}