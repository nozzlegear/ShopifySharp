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
    public sealed class StagedUploadParameterQueryBuilder : FieldsQueryBuilderBase<StagedUploadParameter, StagedUploadParameterQueryBuilder>
    {
        protected override StagedUploadParameterQueryBuilder Self => this;

        public StagedUploadParameterQueryBuilder() : this("stagedUploadParameter")
        {
        }

        public StagedUploadParameterQueryBuilder(string name) : base(new Query<StagedUploadParameter>(name))
        {
        }

        public StagedUploadParameterQueryBuilder(IQuery<StagedUploadParameter> query) : base(query)
        {
        }

        public StagedUploadParameterQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StagedUploadParameterQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}