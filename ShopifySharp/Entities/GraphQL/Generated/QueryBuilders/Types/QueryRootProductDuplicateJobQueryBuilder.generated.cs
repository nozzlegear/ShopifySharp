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
    public sealed class QueryRootProductDuplicateJobQueryBuilder : FieldsQueryBuilderBase<ProductDuplicateJob, QueryRootProductDuplicateJobQueryBuilder>, IHasArguments<QueryRootProductDuplicateJobArgumentsBuilder>
    {
        public QueryRootProductDuplicateJobArgumentsBuilder Arguments { get; }
        protected override QueryRootProductDuplicateJobQueryBuilder Self => this;

        public QueryRootProductDuplicateJobQueryBuilder(string name) : base(new Query<ProductDuplicateJob>(name))
        {
            Arguments = new QueryRootProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductDuplicateJobQueryBuilder(IQuery<ProductDuplicateJob> query) : base(query)
        {
            Arguments = new QueryRootProductDuplicateJobArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductDuplicateJobQueryBuilder SetArguments(Action<QueryRootProductDuplicateJobArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductDuplicateJobQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public QueryRootProductDuplicateJobQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}