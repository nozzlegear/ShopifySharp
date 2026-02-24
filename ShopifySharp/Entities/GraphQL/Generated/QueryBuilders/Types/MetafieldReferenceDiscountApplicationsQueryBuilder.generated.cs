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
    public sealed class MetafieldReferenceDiscountApplicationsQueryBuilder : FieldsQueryBuilderBase<DiscountApplicationConnection, MetafieldReferenceDiscountApplicationsQueryBuilder>, IHasArguments<MetafieldReferenceDiscountApplicationsArgumentsBuilder>
    {
        public MetafieldReferenceDiscountApplicationsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceDiscountApplicationsQueryBuilder Self => this;

        public MetafieldReferenceDiscountApplicationsQueryBuilder(string name) : base(new Query<DiscountApplicationConnection>(name))
        {
            Arguments = new MetafieldReferenceDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceDiscountApplicationsQueryBuilder(IQuery<DiscountApplicationConnection> query) : base(query)
        {
            Arguments = new MetafieldReferenceDiscountApplicationsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceDiscountApplicationsQueryBuilder SetArguments(Action<MetafieldReferenceDiscountApplicationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceDiscountApplicationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountApplicationEdge>(query);
            return this;
        }

        public MetafieldReferenceDiscountApplicationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder> build)
        {
            var query = new Query<IDiscountApplication>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IDiscountApplication>(query);
            return this;
        }

        public MetafieldReferenceDiscountApplicationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}