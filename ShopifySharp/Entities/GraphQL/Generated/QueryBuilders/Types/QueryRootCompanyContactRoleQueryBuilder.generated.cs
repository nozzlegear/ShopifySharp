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
    public sealed class QueryRootCompanyContactRoleQueryBuilder : FieldsQueryBuilderBase<CompanyContactRole, QueryRootCompanyContactRoleQueryBuilder>, IHasArguments<QueryRootCompanyContactRoleArgumentsBuilder>
    {
        public QueryRootCompanyContactRoleArgumentsBuilder Arguments { get; }
        protected override QueryRootCompanyContactRoleQueryBuilder Self => this;

        public QueryRootCompanyContactRoleQueryBuilder(string name) : base(new Query<CompanyContactRole>(name))
        {
            Arguments = new QueryRootCompanyContactRoleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyContactRoleQueryBuilder(IQuery<CompanyContactRole> query) : base(query)
        {
            Arguments = new QueryRootCompanyContactRoleArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyContactRoleQueryBuilder SetArguments(Action<QueryRootCompanyContactRoleArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompanyContactRoleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCompanyContactRoleQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCompanyContactRoleQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }
    }
}