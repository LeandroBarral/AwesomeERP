﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Awe.Mvc.Core.TagHelpers;

namespace Awe.Remark.Theme.TagHelpers
{
    /// <summary>
    /// 
    /// </summary>
    [HtmlTargetElement("bootstrap-button")]
    public class RemarkButtonTagHelper : IAweOverrideTagHelper<ButtonTagHelper>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceProvider">Injected IServiceProvider</param>
        public RemarkButtonTagHelper(IServiceProvider serviceProvider) 
            : base()
        {
        }

        /// <summary>
        /// Custom implementation
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public async void CustomProcess(ButtonTagHelper baseClassInstance, TagBuilder builder, TagHelperContext context, TagHelperOutput output)
        {
            builder.MergeAttribute("data-custommerge", "true");

            builder.Attributes.Add("data-customadd", "true");

            var childContent = output.Content.IsModified ? output.Content.GetContent() : (await output.GetChildContentAsync()).GetContent();
        }
    }
}
