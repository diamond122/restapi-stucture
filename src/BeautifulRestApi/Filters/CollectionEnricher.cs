﻿using System;
using BeautifulRestApi.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BeautifulRestApi.Filters
{
    public class CollectionEnricher : AbstractResultEnricher<Collection>
    {
        protected override void OnEnriching(ResultExecutingContext context, Collection result, Action<ResultExecutingContext, object> enrichChildAction)
        {
            var itemsEnumerator = result.GetEnumerator();
            while (itemsEnumerator.MoveNext())
            {
                enrichChildAction(context, itemsEnumerator.Current);
            }
        }
    }
}
