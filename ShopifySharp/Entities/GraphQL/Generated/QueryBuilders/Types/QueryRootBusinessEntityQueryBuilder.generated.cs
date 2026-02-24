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
    public sealed class QueryRootBusinessEntityQueryBuilder : FieldsQueryBuilderBase<BusinessEntity, QueryRootBusinessEntityQueryBuilder>, IHasArguments<QueryRootBusinessEntityArgumentsBuilder>
    {
        public QueryRootBusinessEntityArgumentsBuilder Arguments { get; }
        protected override QueryRootBusinessEntityQueryBuilder Self => this;

        public QueryRootBusinessEntityQueryBuilder(string name) : base(new Query<BusinessEntity>(name))
        {
            Arguments = new QueryRootBusinessEntityArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBusinessEntityQueryBuilder(IQuery<BusinessEntity> query) : base(query)
        {
            Arguments = new QueryRootBusinessEntityArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootBusinessEntityQueryBuilder SetArguments(Action<QueryRootBusinessEntityArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder Address(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder> build)
        {
            var query = new Query<BusinessEntityAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BusinessEntityAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BusinessEntityAddress>(query);
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder Archived()
        {
            base.InnerQuery.AddField("archived");
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder CompanyName()
        {
            base.InnerQuery.AddField("companyName");
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder Primary()
        {
            base.InnerQuery.AddField("primary");
            return this;
        }

        public QueryRootBusinessEntityQueryBuilder ShopifyPaymentsAccount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder> build)
        {
            var query = new Query<ShopifyPaymentsAccount>("shopifyPaymentsAccount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyPaymentsAccountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyPaymentsAccount>(query);
            return this;
        }
    }
}