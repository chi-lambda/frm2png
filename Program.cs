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
using System.IO;
using System.Linq;

namespace Frm2Png
{
    class Program
    {

        private static string baseInPath = ".";
        private static string baseOutPath = ".";

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
            ParseParameters(args);
            if (File.GetAttributes(baseInPath).HasFlag(FileAttributes.Directory))
            {
                WalkDirectory(baseInPath, baseOutPath);
            }
            else
            {
                DoFile(baseInPath, baseOutPath);
            }

            return 0;
        }

        private static void ParseParameters(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                var arg = args[i];
                switch (arg)
                {
                    case "-o":
                        if (args.Length >= i)
                        {
                            baseOutPath = args[i + 1];
                        }
                        else
                        {
                            throw new ArgumentException("must provide path to -o");
                        }
                        i++;
                        break;
                    default:
                        baseInPath = arg;
                        break;
                }
                i++;
            }
        }

        private static void WalkDirectory(string inPath, string outPath = ".")
        {
            foreach (var file in Directory.EnumerateFileSystemEntries(inPath))
            {
                var filename = Path.GetFileName(file);
                if (File.GetAttributes(file).HasFlag(FileAttributes.Directory))
                {
                    WalkDirectory(file, Path.Combine(outPath, filename));
                }
                else
                {
                    DoFile(file, outPath);
                }
            }
        }

        private static void DoFile(string inFile, string outPath = ".")
        {
            if (!string.Equals(Path.GetExtension(inFile), ".frm", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }
            string outFile = Path.Combine(outPath, Path.GetFileNameWithoutExtension(inFile) + ".png");
            Console.WriteLine("{0} -> {1}", inFile, outFile);
            FrmFalloutFile frm = new FrmFalloutFile(inFile);
            FrmInfo(frm);

            // find maximum width and height
            int maxWidth = frm.Frames.SelectMany(f => f).Select(f => f.GetLength(0)).Max();
            int maxHeight = frm.Frames.SelectMany(f => f).Select(f => f.GetLength(1)).Max();

            var bitmap = frm.ToBitmap();
            bitmap.Save(outFile, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}