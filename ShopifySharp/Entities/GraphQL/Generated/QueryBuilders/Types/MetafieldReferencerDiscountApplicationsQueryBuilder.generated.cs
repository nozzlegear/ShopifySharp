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
    public sealed class MetafieldReferencerDiscountApplicationsQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationConnection, MetafieldReferencerDiscountApplicationsQueryBuilder>, IHasArguments<MetafieldReferencerDiscountApplicationsArgumentsBuilder>
    {
        public MetafieldReferencerDiscountApplicationsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerDiscountApplicationsQueryBuilder Self => this;

        public MetafieldReferencerDiscountApplicationsQueryBuilder(string name) : base(new Query<DiscountApplicationConnection>(name))
        {
            Arguments = new MetafieldReferencerDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerDiscountApplicationsQueryBuilder(IQuery<DiscountApplicationConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerDiscountApplicationsQueryBuilder SetArguments(Action<MetafieldReferencerDiscountApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerDiscountApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationEdge>(query);
            return this;
        }

        public MetafieldReferencerDiscountApplicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }

        public MetafieldReferencerDiscountApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}