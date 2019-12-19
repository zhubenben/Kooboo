﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Kooboo.Web.Frontend.KScriptDefine.BaseMembers
{
    public interface Site
    {
        [Description("The repository that contains Objects that have Url route and Text body.")]
        RoutableTextRepository Pages { get; set; }

        [Description("The repository that contains Text Objects such as Layout and View")]
        TextRepository Views { get; set; }

        [Description("The repository that contains Text Objects such as Layout and View")]
        TextRepository Layouts { get; set; }

        [Description("The text content repository")]
        TextContentRepository TextContents { get; set; }

        [Description("The repository that contains Multilingual objects like Label, htmlBlock.")]
        MultilingualRepository HtmlBlocks { get; set; }

        [Description("The repository that contains Multilingual objects like Label, htmlBlock.")]
        MultilingualRepository Labels { get; set; }

        [Description("The repository that contains Objects that have Url route and Text body.")]
        RoutableTextRepository Scripts { get; set; }

        [Description("The repository that contains Objects that have Url route and Text body.")]
        RoutableTextRepository Styles { get; set; }

        [Description("The repository that contains binary objects such as image or file")]
        BinaryRepository Images { get; set; }

        [Description("The repository that contains binary objects such as image or file")]
        BinaryRepository Files { get; set; }

    }
}