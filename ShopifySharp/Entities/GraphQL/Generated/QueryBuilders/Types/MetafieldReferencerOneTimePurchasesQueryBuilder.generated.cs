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
    public sealed class MetafieldReferencerOneTimePurchasesQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeConnection, MetafieldReferencerOneTimePurchasesQueryBuilder>, IHasArguments<MetafieldReferencerOneTimePurchasesArgumentsBuilder>
    {
        public MetafieldReferencerOneTimePurchasesArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerOneTimePurchasesQueryBuilder Self => this;

        public MetafieldReferencerOneTimePurchasesQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeConnection>(name))
        {
            Arguments = new MetafieldReferencerOneTimePurchasesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerOneTimePurchasesQueryBuilder(IQuery<AppPurchaseOneTimeConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerOneTimePurchasesArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerOneTimePurchasesQueryBuilder SetArguments(Action<MetafieldReferencerOneTimePurchasesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerOneTimePurchasesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTimeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTimeEdge>(query);
            return this;
        }

        public MetafieldReferencerOneTimePurchasesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }

        public MetafieldReferencerOneTimePurchasesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}