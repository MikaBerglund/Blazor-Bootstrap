﻿using BlazorBootstrap.Components.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorBootstrap.Components
{
    public partial class Card
    {
        public Card()
        {
            this.ImagePosition = CardImagePosition.Top;
        }


        [Parameter]
        public RenderFragment BodyTemplate { get; set; }

        [Parameter]
        public string Footer { get; set; }

        [Parameter]
        public RenderFragment<string> FooterTemplate { get; set; }

        [Parameter]
        public string Header { get; set; }

        [Parameter]
        public RenderFragment<string> HeaderTemplate { get; set; }

        /// <summary>
        /// Specifies the position for the image specified in <see cref="ImageUrl"/>.
        /// </summary>
        [Parameter]
        public CardImagePosition ImagePosition { get; set; }

        /// <summary>
        /// The URL, either absolute or relative, to the image to show in the card.
        /// </summary>
        [Parameter]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The template to use.
        /// </summary>
        [Parameter]
        public RenderFragment<string> ImageTemplate { get; set; }

        /// <summary>
        /// A collection of links to show in the card.
        /// </summary>
        [Parameter]
        public IEnumerable<ILink> Links { get; set; }

        /// <summary>
        /// The template to use for each link.
        /// </summary>
        /// <remarks>
        /// If not specified, a default template is used.
        /// </remarks>
        [Parameter]
        public RenderFragment<ILink> LinkTemplate { get; set; }

        /// <summary>
        /// A template that allows you to completely customize the links section of a card.
        /// </summary>
        /// <remarks>
        /// If not specified, a default template is used.
        /// </remarks>
        [Parameter]
        public RenderFragment<IEnumerable<ILink>> LinkSectionTemplate { get; set; }

        /// <summary>
        /// The subtitle of the card.
        /// </summary>
        [Parameter]
        public string Subtitle { get; set; }

        /// <summary>
        /// The template to use for the subtitle.
        /// </summary>
        /// <remarks>
        /// This will override <see cref="Subtitle"/>
        /// </remarks>
        [Parameter]
        public RenderFragment<string> SubtitleTemplate { get; set; }

        [Parameter]
        public string Text { get; set; }

        [Parameter]
        public RenderFragment<string> TextTemplate { get; set; }

        /// <summary>
        /// The title for the card.
        /// </summary>
        [Parameter]
        public string Title { get; set; }

        /// <summary>
        /// The template to use for the title.
        /// </summary>
        /// <remarks>
        /// <see cref="Title"/> is ignored if a template is specified in this parameter.
        /// </remarks>
        [Parameter]
        public RenderFragment<string> TitleTemplate { get; set; }



        protected override void OnParametersSet()
        {
            this.AddClass(ClassNames.Cards.Card);

            base.OnParametersSet();
        }


    }
}
