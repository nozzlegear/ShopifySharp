using Newtonsoft.Json;
using ShopifySharp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace ShopifySharp
{
    public class UpdateBuilder<T> where T : ShopifyObject
    {
        private readonly IDictionary<string, dynamic> _updateFields = new Dictionary<string, dynamic>();
        public UpdateBuilder<T> Update<TProperty>(Expression<Func<T, TProperty>> propertySelector, TProperty newvalue)
        {
            var property = propertySelector.Body as MemberExpression;
            if (property == null)
            {
                throw new ArgumentException($"Selector must be a MemberExpression", nameof(propertySelector));
            }
            _updateFields[property.Member.Name] = newvalue;
            return this;
        }

        public JsonContent BuildContent(string rootContentElement)
        {
            if (_updateFields.Count == 0)
            {
                return null;
            }
            var propInfos = typeof(T).GetAllDeclaredProperties().Where(prop => _updateFields.Keys.Contains(prop.Name));
            IDictionary<string, object> output = new Dictionary<string, object>();

            //Inspiration for this code from https://github.com/jaymedavis/stripe.net
            foreach (PropertyInfo property in propInfos)
            {
                object value = _updateFields[property.Name];
                string propName = property.Name;

                if (property.CustomAttributes.Any(x => x.AttributeType == typeof(JsonPropertyAttribute)))
                {
                    //Get the JsonPropertyAttribute for this property, which will give us its JSON name
                    JsonPropertyAttribute attribute = property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>().FirstOrDefault();

                    propName = attribute != null ? attribute.PropertyName : property.Name;
                }

                if (value != null && value.GetType().GetTypeInfo().IsEnum)
                {
                    value = ((Enum)value).ToSerializedString();
                }

                output.Add(propName, value);
            }

            return new JsonContent(new Dictionary<string, IDictionary<string, dynamic>>(){
                    { rootContentElement, output }
                });
        }
    }
}
