
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using OpenTK.Graphics;
//using OpenTK.Graphics.ES20;
//using OpenTK.Platform.Android;
//using Microsoft.Xna.Framework.Graphics;
using Android.Content;

namespace Microsoft.Xna.Framework
{		
    internal class TransparentMonoGameView : MonoGameAndroidGameView
    {
        public  TransparentMonoGameView(Context context, AndroidGameWindow androidGameWindow, Game game)
            : base(context, androidGameWindow, game)
        {
            //this.SetZOrderMediaOverlay(true);
            //this.Holder.SetFormat(global::Android.Graphics.Format.Rgba8888);
        }


        ///// <Docs>To be added.</Docs>
        ///// <summary>
        ///// Creates a new frame buffer hardcoded into transparent mode
        ///// </summary>
        //protected override void CreateFrameBuffer()
        //{
           
            //GraphicsMode mode = new AndroidGraphicsMode(new ColorFormat(8, 8, 8, 8), 1, 0, 0, 0, false);

            //if (mode != null)
            //    Android.Util.Log.Debug("MonoGame", "Creating Color: {0}, Depth: {1}, Stencil: {2}, Accum:{3}", mode.ColorFormat, mode.Depth, mode.Stencil, mode.AccumulatorFormat);
            //else
            //    Android.Util.Log.Debug("MonoGame", "Creating default mode");
            //GraphicsMode = mode;
            //try
            //{
            //    base.CreateFrameBuffer();
            //}
            //catch (Exception e)
            //{
            //    throw new NoSuitableGraphicsDeviceException("Could not create OpenGLES 2.0 frame buffer", e);
            //}
            //Android.Util.Log.Debug("MonoGame", "Created format {0}", GraphicsContext.GraphicsMode);
            //var status = GL.CheckFramebufferStatus(FramebufferTarget.Framebuffer);
            //Android.Util.Log.Debug("MonoGame", "Framebuffer Status: " + status.ToString());

            //MakeCurrent();
           
       // }
    }
}

