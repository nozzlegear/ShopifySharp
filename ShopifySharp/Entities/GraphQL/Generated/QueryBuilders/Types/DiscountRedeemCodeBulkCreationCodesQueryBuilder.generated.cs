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
    public sealed class DiscountRedeemCodeBulkCreationCodesQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreationCodeConnection, DiscountRedeemCodeBulkCreationCodesQueryBuilder>, IHasArguments<DiscountRedeemCodeBulkCreationCodesArgumentsBuilder>
    {
        public DiscountRedeemCodeBulkCreationCodesArgumentsBuilder Arguments { get; }
        protected override DiscountRedeemCodeBulkCreationCodesQueryBuilder Self => this;

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreationCodeConnection>(name))
        {
            Arguments = new DiscountRedeemCodeBulkCreationCodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder(IQuery<DiscountRedeemCodeBulkCreationCodeConnection> query) : base(query)
        {
            Arguments = new DiscountRedeemCodeBulkCreationCodesArgumentsBuilder(base.InnerQuery);
        }

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder SetArguments(Action<DiscountRedeemCodeBulkCreationCodesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCodeEdge>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCode>(query);
            return this;
        }

        public DiscountRedeemCodeBulkCreationCodesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}