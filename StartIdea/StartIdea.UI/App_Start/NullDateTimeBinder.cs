﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StartIdea.UI.App_Start
{
    public class NullDateTimeBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, value);

            return value == null
                ? null
                : value.ConvertTo(typeof(DateTime), CultureInfo.CurrentCulture);
        }
    }
}