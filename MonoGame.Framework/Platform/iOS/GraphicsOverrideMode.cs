using System;
using Foundation;
using OpenGLES;

namespace Microsoft.Xna.Framework
{
    public static class GraphicsOverrideMode
    {
        public static GraphicsOverrideSettings GraphicsOverrideSettings;
    }

    public class GraphicsOverrideSettings
    {
        public GraphicsOverrideSettings(bool opaque, bool retainedBacking, NSString colorFormat)
        {
            Opaque = opaque;
            RetainedBacking = retainedBacking;
            STREAGLColorFormat = colorFormat;
        }

        public GraphicsOverrideSettings()
        {
            Opaque = false;
            RetainedBacking = true;
            STREAGLColorFormat = EAGLColorFormat.RGBA8;
        }

        public bool Opaque { get; set; }

        public bool RetainedBacking { get; set; }

        public NSString STREAGLColorFormat { get; set; }
    }
}
