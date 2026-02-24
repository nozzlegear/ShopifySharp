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
    public sealed class MetafieldReferencerAvailableChannelAppsQueryBuilder : FieldsQueryBuilderBase<AppConnection, MetafieldReferencerAvailableChannelAppsQueryBuilder>, IHasArguments<MetafieldReferencerAvailableChannelAppsArgumentsBuilder>
    {
        public MetafieldReferencerAvailableChannelAppsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerAvailableChannelAppsQueryBuilder Self => this;

        public MetafieldReferencerAvailableChannelAppsQueryBuilder(string name) : base(new Query<AppConnection>(name))
        {
            Arguments = new MetafieldReferencerAvailableChannelAppsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerAvailableChannelAppsQueryBuilder(IQuery<AppConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerAvailableChannelAppsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerAvailableChannelAppsQueryBuilder SetArguments(Action<MetafieldReferencerAvailableChannelAppsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerAvailableChannelAppsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder> build)
        {
            var query = new Query<AppEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppEdge>(query);
            return this;
        }

        public MetafieldReferencerAvailableChannelAppsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public MetafieldReferencerAvailableChannelAppsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}