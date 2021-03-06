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

using System.Drawing;

namespace Frm2Png
{

    public static class Palette
    {
        public static readonly Color[] pallete = {
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(59,  59,  59),
            Color.FromArgb(55,  55,  55),
            Color.FromArgb(51,  51,  51),
            Color.FromArgb(47,  47,  47),
            Color.FromArgb(44,  44,  44),
            Color.FromArgb(40,  40,  40),
            Color.FromArgb(36,  36,  36),
            Color.FromArgb(32,  32,  32),
            Color.FromArgb(29,  29,  29),
            Color.FromArgb(25,  25,  25),
            Color.FromArgb(21,  21,  21),
            Color.FromArgb(18,  18,  18),
            Color.FromArgb(14,  14,  14),
            Color.FromArgb(10,  10,  10),
            Color.FromArgb(8,   8,   8),
            Color.FromArgb(63,  59,  59),
            Color.FromArgb(59,  54,  54),
            Color.FromArgb(55,  49,  49),
            Color.FromArgb(52,  44,  44),
            Color.FromArgb(48,  40,  40),
            Color.FromArgb(44,  36,  36),
            Color.FromArgb(41,  32,  32),
            Color.FromArgb(37,  28,  28),
            Color.FromArgb(33,  24,  24),
            Color.FromArgb(30,  21,  21),
            Color.FromArgb(26,  17,  17),
            Color.FromArgb(22,  14,  14),
            Color.FromArgb(19,  11,  11),
            Color.FromArgb(15,  9,   9),
            Color.FromArgb(11,  6,   6),
            Color.FromArgb(8,   4,   4),
            Color.FromArgb(59,  59,  63),
            Color.FromArgb(54,  54,  59),
            Color.FromArgb(49,  49,  55),
            Color.FromArgb(44,  44,  52),
            Color.FromArgb(40,  40,  48),
            Color.FromArgb(36,  36,  44),
            Color.FromArgb(32,  32,  41),
            Color.FromArgb(28,  28,  37),
            Color.FromArgb(24,  24,  33),
            Color.FromArgb(21,  21,  30),
            Color.FromArgb(17,  17,  26),
            Color.FromArgb(14,  14,  22),
            Color.FromArgb(11,  11,  19),
            Color.FromArgb(9,   9,   15),
            Color.FromArgb(6,   6,   11),
            Color.FromArgb(4,   4,   8),
            Color.FromArgb(63,  44,  60),
            Color.FromArgb(49,  24,  42),
            Color.FromArgb(26,  9,   24),
            Color.FromArgb(19,  5,   18),
            Color.FromArgb(14,  3,   13),
            Color.FromArgb(10,  4,   9),
            Color.FromArgb(9,   1,   9),
            Color.FromArgb(7,   3,   6),
            Color.FromArgb(63,  63,  50),
            Color.FromArgb(63,  63,  31),
            Color.FromArgb(57,  54,  3),
            Color.FromArgb(51,  46,  7),
            Color.FromArgb(46,  39,  10),
            Color.FromArgb(41,  34,  12),
            Color.FromArgb(36,  30,  9),
            Color.FromArgb(31,  26,  6),
            Color.FromArgb(27,  22,  4),
            Color.FromArgb(22,  18,  2),
            Color.FromArgb(18,  14,  1),
            Color.FromArgb(13,  10,  0),
            Color.FromArgb(8,   6,   0),
            Color.FromArgb(54,  63,  39),
            Color.FromArgb(45,  54,  33),
            Color.FromArgb(38,  46,  28),
            Color.FromArgb(30,  38,  23),
            Color.FromArgb(23,  30,  18),
            Color.FromArgb(16,  22,  13),
            Color.FromArgb(10,  14,  8),
            Color.FromArgb(28,  24,  20),
            Color.FromArgb(21,  18,  13),
            Color.FromArgb(14,  12,  8),
            Color.FromArgb(26,  30,  20),
            Color.FromArgb(28,  30,  8),
            Color.FromArgb(28,  26,  10),
            Color.FromArgb(24,  24,  9),
            Color.FromArgb(19,  17,  9),
            Color.FromArgb(14,  12,  8),
            Color.FromArgb(39,  43,  39),
            Color.FromArgb(30,  37,  30),
            Color.FromArgb(22,  31,  22),
            Color.FromArgb(16,  26,  16),
            Color.FromArgb(14,  22,  22),
            Color.FromArgb(12,  19,  18),
            Color.FromArgb(10,  17,  15),
            Color.FromArgb(8,   15,  11),
            Color.FromArgb(7,   12,  9),
            Color.FromArgb(5,   10,  6),
            Color.FromArgb(4,   8,   4),
            Color.FromArgb(6,   12,  6),
            Color.FromArgb(4,   9,   3),
            Color.FromArgb(2,   7,   1),
            Color.FromArgb(1,   5,   0),
            Color.FromArgb(1,   3,   0),
            Color.FromArgb(35,  39,  39),
            Color.FromArgb(30,  37,  38),
            Color.FromArgb(25,  34,  37),
            Color.FromArgb(20,  31,  36),
            Color.FromArgb(16,  27,  35),
            Color.FromArgb(12,  22,  35),
            Color.FromArgb(11,  19,  31),
            Color.FromArgb(10,  17,  27),
            Color.FromArgb(8,   14,  23),
            Color.FromArgb(7,   12,  19),
            Color.FromArgb(6,   10,  16),
            Color.FromArgb(39,  41,  41),
            Color.FromArgb(14,  18,  26),
            Color.FromArgb(20,  22,  22),
            Color.FromArgb(22,  26,  33),
            Color.FromArgb(14,  16,  20),
            Color.FromArgb(47,  47,  47),
            Color.FromArgb(43,  41,  38),
            Color.FromArgb(40,  36,  31),
            Color.FromArgb(37,  31,  24),
            Color.FromArgb(34,  26,  19),
            Color.FromArgb(31,  22,  13),
            Color.FromArgb(28,  18,  9),
            Color.FromArgb(25,  15,  5),
            Color.FromArgb(22,  12,  2),
            Color.FromArgb(63,  51,  51),
            Color.FromArgb(63,  44,  44),
            Color.FromArgb(63,  38,  38),
            Color.FromArgb(63,  31,  31),
            Color.FromArgb(63,  25,  25),
            Color.FromArgb(63,  18,  18),
            Color.FromArgb(63,  12,  12),
            Color.FromArgb(63,  0,   0),
            Color.FromArgb(56,  0,   0),
            Color.FromArgb(49,  0,   0),
            Color.FromArgb(42,  0,   0),
            Color.FromArgb(36,  0,   0),
            Color.FromArgb(29,  0,   0),
            Color.FromArgb(22,  0,   0),
            Color.FromArgb(16,  0,   0),
            Color.FromArgb(63,  56,  50),
            Color.FromArgb(63,  49,  37),
            Color.FromArgb(63,  46,  30),
            Color.FromArgb(63,  43,  24),
            Color.FromArgb(63,  39,  18),
            Color.FromArgb(63,  37,  11),
            Color.FromArgb(63,  34,  5),
            Color.FromArgb(63,  31,  0),
            Color.FromArgb(55,  27,  0),
            Color.FromArgb(48,  24,  0),
            Color.FromArgb(41,  20,  0),
            Color.FromArgb(33,  17,  0),
            Color.FromArgb(26,  13,  0),
            Color.FromArgb(19,  9,   0),
            Color.FromArgb(12,  6,   0),
            Color.FromArgb(62,  53,  41),
            Color.FromArgb(54,  44,  30),
            Color.FromArgb(50,  40,  25),
            Color.FromArgb(47,  36,  21),
            Color.FromArgb(43,  32,  17),
            Color.FromArgb(39,  29,  13),
            Color.FromArgb(35,  25,  10),
            Color.FromArgb(31,  22,  7),
            Color.FromArgb(28,  19,  5),
            Color.FromArgb(24,  16,  2),
            Color.FromArgb(20,  13,  1),
            Color.FromArgb(16,  10,  0),
            Color.FromArgb(13,  8,   0),
            Color.FromArgb(63,  57,  46),
            Color.FromArgb(58,  50,  38),
            Color.FromArgb(53,  43,  31),
            Color.FromArgb(49,  36,  25),
            Color.FromArgb(44,  29,  19),
            Color.FromArgb(40,  23,  14),
            Color.FromArgb(36,  19,  11),
            Color.FromArgb(33,  15,  8),
            Color.FromArgb(30,  11,  6),
            Color.FromArgb(27,  8,   4),
            Color.FromArgb(23,  5,   2),
            Color.FromArgb(18,  3,   1),
            Color.FromArgb(15,  1,   0),
            Color.FromArgb(63,  58,  55),
            Color.FromArgb(62,  53,  47),
            Color.FromArgb(61,  48,  40),
            Color.FromArgb(60,  44,  33),
            Color.FromArgb(60,  40,  27),
            Color.FromArgb(60,  37,  23),
            Color.FromArgb(54,  32,  21),
            Color.FromArgb(48,  28,  18),
            Color.FromArgb(42,  24,  16),
            Color.FromArgb(36,  20,  14),
            Color.FromArgb(30,  16,  12),
            Color.FromArgb(24,  12,  9),
            Color.FromArgb(18,  9,   7),
            Color.FromArgb(14,  6,   5),
            Color.FromArgb(25,  57,  25),
            Color.FromArgb(5,   38,  5),
            Color.FromArgb(0,   41,  0),
            Color.FromArgb(20,  20,  18),
            Color.FromArgb(0,   27,  0),
            Color.FromArgb(35,  35,  33),
            Color.FromArgb(7,   7,   7),
            Color.FromArgb(26,  20,  14),
            Color.FromArgb(12,  10,  8),
            Color.FromArgb(35,  28,  24),
            Color.FromArgb(18,  14,  10),
            Color.FromArgb(3,   3,   3),
            Color.FromArgb(15,  15,  15),
            Color.FromArgb(27,  29,  27),
            Color.FromArgb(30,  33,  30),
            Color.FromArgb(34,  37,  34),
            Color.FromArgb(37,  41,  37),
            Color.FromArgb(22,  26,  24),
            Color.FromArgb(24,  28,  26),
            Color.FromArgb(15,  62,  0),
            Color.FromArgb(14,  53,  2),
            Color.FromArgb(13,  45,  4),
            Color.FromArgb(12,  37,  5),
            Color.FromArgb(10,  29,  6),
            Color.FromArgb(63,  63,  63),
            Color.FromArgb(60,  59,  52),
            Color.FromArgb(52,  46,  34),
            Color.FromArgb(38,  31,  20),
            Color.FromArgb(26,  22,  15),
            Color.FromArgb(20,  16,  9),
            Color.FromArgb(13,  10,  7),
            Color.FromArgb(6,   4,   3),
            Color.FromArgb(0,   0,   0),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255),
            Color.FromArgb(255, 255, 255)
    };
    }
}