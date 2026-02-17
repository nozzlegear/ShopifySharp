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