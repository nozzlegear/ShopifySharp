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
    public sealed class DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreationCodeConnection, DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder>, IHasArguments<DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder>
    {
        public DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder Arguments { get; }
        protected override DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder() : this("discountRedeemCodeBulkCreationCodeConnection")
        {
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreationCodeConnection>(name))
        {
            Arguments = new DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder(IQuery<DiscountRedeemCodeBulkCreationCodeConnection> query) : base(query)
        {
            Arguments = new DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder SetArguments(Action<DiscountRedeemCodeBulkCreationCodeConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCodeEdge>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCode>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}