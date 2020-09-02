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
using System.Collections.Generic;
using System.Drawing;

namespace Frm2Png
{
    class FrmFalloutFile : FalloutFile
    {
        public FrmFalloutFile(string filename) : base(filename)
        {
            Version = ReadInt(); // version
            FramesPerSecond = ReadShort(); // frames per second
            ActionFrame = ReadShort(); // action frame
            FramesPerDirection = ReadShort();

            for (uint i = 0; i != 6; ++i)
            {
                ReadShort(); // direction x shift
            }

            for (uint i = 0; i != 6; ++i)
            {
                ReadShort(); // direction y shift
            }

            var lastOffset = uint.MaxValue;
            for (byte i = 0; i != 6; ++i)
            {
                uint offset = ReadInt(); // direction pixel data offset
                if (offset == lastOffset)
                {
                    continue;
                }

                lastOffset = offset;
                Frames.Add(new List<Color[,]>());
            }

            ReadInt(); // frm data size

            for (int i = 0; i != Frames.Count; ++i)
            {
                for (int j = 0; j != FramesPerDirection; ++j)
                {
                    ushort width = ReadShort();
                    ushort height = ReadShort();
                    ReadInt(); // frame pixel data size
                    ReadShort(); // x offset
                    ReadShort(); // y offset

                    Color[,] frame = new Color[width, height];
                    for (var y = 0; y < frame.GetLength(1); ++y)
                    {
                        for (var x = 0; x < frame.GetLength(0); ++x)
                        {
                            byte index = ReadByte();

                            if (index == 0)
                            {
                                frame[x, y] = Color.Transparent;
                                continue;
                            }
                            else
                            {
                                byte red = (byte)Math.Min(255, Palette.pallete[index].R * _colorModifier);
                                byte green = (byte)Math.Min(255, Palette.pallete[index].G * _colorModifier);
                                byte blue = (byte)Math.Min(255, Palette.pallete[index].B * _colorModifier);
                                frame[x, y] = Color.FromArgb(red, green, blue);
                            }
                        }
                    }
                    Frames[i].Add(frame);
                }
            }
        }

        private byte _colorModifier = 4;

        public ushort ActionFrame { get; }
        public ushort FramesPerDirection { get; }
        public ushort FramesPerSecond { get; }
        public uint Version { get; }

        // direction => frames
        public List<List<Color[,]>> Frames { get; } = new List<List<Color[,]>>();
    };
}
