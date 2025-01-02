using System;
using System.Collections.Generic;

namespace ShopifySharp.Infrastructure.Serialization.Json;

public interface IJsonNodeObjectEnumerator : IEnumerable<IJsonNode>, IDisposable;
