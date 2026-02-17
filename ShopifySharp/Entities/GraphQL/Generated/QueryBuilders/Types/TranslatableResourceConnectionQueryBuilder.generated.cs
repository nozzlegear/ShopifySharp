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
    public sealed class TranslatableResourceConnectionQueryBuilder : FieldsQueryBuilderBase<TranslatableResourceConnection, TranslatableResourceConnectionQueryBuilder>
    {
        protected override TranslatableResourceConnectionQueryBuilder Self => this;

        public TranslatableResourceConnectionQueryBuilder() : this("translatableResourceConnection")
        {
        }

        public TranslatableResourceConnectionQueryBuilder(string name) : base(new Query<TranslatableResourceConnection>(name))
        {
        }

        public TranslatableResourceConnectionQueryBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
        }

        public TranslatableResourceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<TranslatableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResourceEdge>(query);
            return this;
        }

        public TranslatableResourceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder> build)
        {
            var query = new Query<TranslatableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TranslatableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TranslatableResource>(query);
            return this;
        }

        public TranslatableResourceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}