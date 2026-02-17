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