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
    public sealed class FileEdgeQueryBuilder : FieldsQueryBuilderBase<FileEdge, FileEdgeQueryBuilder>
    {
        protected override FileEdgeQueryBuilder Self => this;

        public FileEdgeQueryBuilder() : this("fileEdge")
        {
        }

        public FileEdgeQueryBuilder(string name) : base(new Query<FileEdge>(name))
        {
        }

        public FileEdgeQueryBuilder(IQuery<FileEdge> query) : base(query)
        {
        }

        public FileEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public FileEdgeQueryBuilder Node(Action<FileInterfaceCasesBuilder> build)
        {
            var query = new Query<IFile>("node");
            var unionBuilder = new FileInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}