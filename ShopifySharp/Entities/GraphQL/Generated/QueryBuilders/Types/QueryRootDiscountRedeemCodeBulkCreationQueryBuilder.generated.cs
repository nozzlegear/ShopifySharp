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
    public sealed class QueryRootDiscountRedeemCodeBulkCreationQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkCreation, QueryRootDiscountRedeemCodeBulkCreationQueryBuilder>, IHasArguments<QueryRootDiscountRedeemCodeBulkCreationArgumentsBuilder>
    {
        public QueryRootDiscountRedeemCodeBulkCreationArgumentsBuilder Arguments { get; }
        protected override QueryRootDiscountRedeemCodeBulkCreationQueryBuilder Self => this;

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkCreation>(name))
        {
            Arguments = new QueryRootDiscountRedeemCodeBulkCreationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder(IQuery<DiscountRedeemCodeBulkCreation> query) : base(query)
        {
            Arguments = new QueryRootDiscountRedeemCodeBulkCreationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder SetArguments(Action<QueryRootDiscountRedeemCodeBulkCreationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder Codes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreationCodeConnection>("codes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountRedeemCodeBulkCreationCodeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreationCodeConnection>(query);
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder CodesCount()
        {
            base.InnerQuery.AddField("codesCount");
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder DiscountCode(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("discountCode");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder Done()
        {
            base.InnerQuery.AddField("done");
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder FailedCount()
        {
            base.InnerQuery.AddField("failedCount");
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootDiscountRedeemCodeBulkCreationQueryBuilder ImportedCount()
        {
            base.InnerQuery.AddField("importedCount");
            return this;
        }
    }
}