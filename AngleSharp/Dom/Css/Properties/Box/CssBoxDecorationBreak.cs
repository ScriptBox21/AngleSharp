﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css;
    using AngleSharp.Extensions;
    using System;

    /// <summary>
    /// More infos can be found on the W3C homepage or
    /// in condensed form at 
    /// http://css-infos.net/property/box-decoration-break
    /// Gets if each box is independently wrapped with the border
    /// and padding. Otherwise no border and no padding are inserted
    /// at the break.
    /// </summary>
    sealed class CssBoxDecorationBreak : CssProperty
    {
        #region Fields

        static readonly IValueConverter<Boolean> Converter = 
            Converters.Toggle(Keywords.Clone, Keywords.Slice);

        #endregion

        #region ctor

        internal CssBoxDecorationBreak(CssStyleDeclaration rule)
            : base(PropertyNames.BoxDecorationBreak, rule)
        {
        }

        #endregion

        #region Methods

        protected override Object GetDefault(IElement element)
        {
            return false;
        }

        protected override Object Compute(IElement element)
        {
            return Converter.Convert(Value);
        }

        protected override Boolean IsValid(ICssValue value)
        {
            return Converter.Validate(value);
        }

        #endregion
    }
}
