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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CompanyContactRoleOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContactRole, CompanyContactRoleOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContactRole>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompanyContactRoleArgumentsBuilder Arguments { get; }
        protected override CompanyContactRoleOperationQueryBuilder Self => this;

        public CompanyContactRoleOperationQueryBuilder() : this("companyContactRole")
        {
        }

        public CompanyContactRoleOperationQueryBuilder(string name) : base(new Query<CompanyContactRole>(name))
        {
            Arguments = new CompanyContactRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRoleOperationQueryBuilder(IQuery<CompanyContactRole> query) : base(query)
        {
            Arguments = new CompanyContactRoleArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactRoleOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyContactRoleOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CompanyContactRoleOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }
    }
}