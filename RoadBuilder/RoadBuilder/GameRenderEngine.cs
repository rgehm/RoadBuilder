﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Roadbuilder
{
    static class GameRenderEngine
    {
        public static void DrawGameObject(PaintEventArgs e, GameObject Object)
        {
            e.Graphics.DrawImageUnscaled(Object.Texture.Image, Object.Position);
        }

        public static void DrawGameObject(PaintEventArgs e, Texture2D Texture, Rectangle Rectangle)
        {
            e.Graphics.DrawImage(Texture.Image, Rectangle);
        }

        public static void DrawRectangleOfObject(PaintEventArgs e, GameObject Object)
        {
            e.Graphics.DrawRectangle(Pens.LightGray, Object.Rectangle);
        }
    }
}
