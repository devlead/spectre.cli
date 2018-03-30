﻿namespace Spectre.CommandLine.Internal.Rendering.Elements
{
    internal sealed class TextElement : IRenderable
    {
        private readonly string _text;

        public TextElement(string text)
        {
            _text = text;
        }

        public void Render(IRenderer renderer)
        {
            renderer.Append(_text);
        }
    }
}