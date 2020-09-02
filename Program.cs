/*
 * Copyright (c) 2015-2018 Falltergeist developers
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to
 * deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
 * sell copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
 * IN THE SOFTWARE.
 */
 
 using System;
using System.Drawing;
using System.Linq;

namespace Frm2Png
{
    class Program
    {
        static void Usage(string binaryName)
        {
            Console.WriteLine("FRM to PNG converter v0.1.4");
            Console.WriteLine("Copyright (c) 2015-2018 Falltergeist developers");
            Console.WriteLine("Usage: {0} <FRM filename>", binaryName);
        }

        static void FrmInfo(FrmFalloutFile frm)
        {
            Console.WriteLine("=== FRM info ===");
            Console.WriteLine("Version: {0}", frm.Version);
            Console.WriteLine("Frames per second: {0}", frm.FramesPerSecond);
            Console.WriteLine("Action frame: {0}", frm.ActionFrame);
            Console.WriteLine("Frames per direction: {0}", frm.FramesPerDirection);
        }

        public static int Main(string[] args)
        {
            if (args.Length != 1)
            {
                Usage("frm2png");
                return 1;
            }

            string filename = args[0];
            string outname = filename.Substring(0, filename.LastIndexOf('.')) + ".png";

            try
            {
                FrmFalloutFile frm = new FrmFalloutFile(filename);

                FrmInfo(frm);

                // find maximum width and height
                int maxWidth = frm.Frames.SelectMany(f => f).Select(f => f.GetLength(0)).Max();
                int maxHeight = frm.Frames.SelectMany(f => f).Select(f => f.GetLength(1)).Max();

                var bitmap = new Bitmap(maxWidth * frm.FramesPerDirection, maxHeight * frm.Frames.Count);

                for (var i = 0; i != frm.Frames.Count; ++i)
                {
                    for (var j = 0; j != frm.Frames[i].Count; ++j)
                    {
                        var frame = frm.Frames[i][j];
                        for (var y = 0; y != frame.GetLength(1); ++y)
                        {
                            for (var x = 0; x != frame.GetLength(0); ++x)
                            {
                                bitmap.SetPixel(maxWidth * j + x, maxHeight * i + y, frame[x, y]);
                            }
                        }
                    }
                }
                bitmap.Save(outname, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 1;
            }

            return 0;
        }
    }
}