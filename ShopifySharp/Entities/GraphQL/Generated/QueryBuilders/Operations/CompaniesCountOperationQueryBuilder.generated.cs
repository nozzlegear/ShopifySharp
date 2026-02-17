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
    public sealed class CompaniesCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, CompaniesCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompaniesCountArgumentsBuilder Arguments { get; }
        protected override CompaniesCountOperationQueryBuilder Self => this;

        public CompaniesCountOperationQueryBuilder() : this("companiesCount")
        {
        }

        public CompaniesCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CompaniesCountArgumentsBuilder(base.InnerQuery);
        }

        public CompaniesCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CompaniesCountArgumentsBuilder(base.InnerQuery);
        }

        public CompaniesCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CompaniesCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}