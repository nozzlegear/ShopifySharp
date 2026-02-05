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
    public sealed class JobResultQueryBuilder : FieldsQueryBuilderBase<IJobResult, JobResultQueryBuilder>
    {
        protected override JobResultQueryBuilder Self => this;

        public JobResultQueryBuilder() : this("jobResult")
        {
        }

        public JobResultQueryBuilder(string name) : base(new Query<IJobResult>(name))
        {
        }

        public JobResultQueryBuilder(IQuery<IJobResult> query) : base(query)
        {
        }

        public JobResultQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public JobResultQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}