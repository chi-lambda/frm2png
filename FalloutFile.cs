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
using System.IO;

namespace Frm2Png
{
    class FalloutFile : IDisposable
    {
            public FalloutFile(string filename)
        {
            _stream = new FileStream(filename, FileMode.Open);
        }
        public void Dispose()
        {
            _stream.Close();
        }

        protected byte ReadByte()
        {
            var b = _stream.ReadByte();
            if (b >= 0)
            {
                return (byte)b;
            }
            else
            {
                throw new InvalidOperationException(string.Format("Read past end of file, position {0}", _stream.Position));
            }
        }
        protected ushort ReadShort()
        {
            var buffer = new byte[2];
            _stream.Read(buffer, 0, 2);
            return (ushort)(buffer[1] + 256 * buffer[0]);
        }
        protected uint ReadInt()
        {
            var buffer = new byte[4];
            _stream.Read(buffer, 0, 4);
            return (uint)(buffer[3] + 256 * buffer[2] + 65536 * buffer[1] + 16777216 * buffer[0]);
        }

        protected readonly Stream _stream;
    };
}
