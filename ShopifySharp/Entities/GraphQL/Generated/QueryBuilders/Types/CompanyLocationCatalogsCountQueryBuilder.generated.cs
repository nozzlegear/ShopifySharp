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
    public sealed class CompanyLocationCatalogsCountQueryBuilder : FieldsQueryBuilderBase<Count, CompanyLocationCatalogsCountQueryBuilder>, IHasArguments<CompanyLocationCatalogsCountArgumentsBuilder>
    {
        public CompanyLocationCatalogsCountArgumentsBuilder Arguments { get; }
        protected override CompanyLocationCatalogsCountQueryBuilder Self => this;

        public CompanyLocationCatalogsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CompanyLocationCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCatalogsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CompanyLocationCatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationCatalogsCountQueryBuilder SetArguments(Action<CompanyLocationCatalogsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CompanyLocationCatalogsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CompanyLocationCatalogsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}