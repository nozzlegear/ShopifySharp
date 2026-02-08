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
    public sealed class TranslatableResourceEdgeQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceEdge, TranslatableResourceEdgeQueryBuilder>
    {
        protected override TranslatableResourceEdgeQueryBuilder Self => this;

        public TranslatableResourceEdgeQueryBuilder() : this("translatableResourceEdge")
        {
        }

        public TranslatableResourceEdgeQueryBuilder(string name) : base(new Query<TranslatableResourceEdge>(name))
        {
        }

        public TranslatableResourceEdgeQueryBuilder(IQuery<TranslatableResourceEdge> query) : base(query)
        {
        }

        public TranslatableResourceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public TranslatableResourceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }
    }
}