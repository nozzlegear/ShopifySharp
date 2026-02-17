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
    public sealed class EditablePropertyQueryBuilder : FieldsQueryBuilderBase<EditableProperty, EditablePropertyQueryBuilder>
    {
        protected override EditablePropertyQueryBuilder Self => this;

        public EditablePropertyQueryBuilder() : this("editableProperty")
        {
        }

        public EditablePropertyQueryBuilder(string name) : base(new Query<EditableProperty>(name))
        {
        }

        public EditablePropertyQueryBuilder(IQuery<EditableProperty> query) : base(query)
        {
        }

        public EditablePropertyQueryBuilder Locked()
        {
            base.InnerQuery.AddField("locked");
            return this;
        }

        public EditablePropertyQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }
    }
}