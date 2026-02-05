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
    public sealed class MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder : FieldsQueryBuilderBase<MutationsStagedUploadTargetGenerateUploadParameter, MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder>
    {
        protected override MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder Self => this;

        public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder() : this("mutationsStagedUploadTargetGenerateUploadParameter")
        {
        }

        public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder(string name) : base(new Query<MutationsStagedUploadTargetGenerateUploadParameter>(name))
        {
        }

        public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder(IQuery<MutationsStagedUploadTargetGenerateUploadParameter> query) : base(query)
        {
        }

        public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MutationsStagedUploadTargetGenerateUploadParameterQueryBuilder Value()
        {
            base.InnerQuery.AddField("value");
            return this;
        }
    }
}