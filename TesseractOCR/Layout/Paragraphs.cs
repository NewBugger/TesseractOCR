﻿//
// Paragraphs.cs
//
// Author: Kees van Spelde <sicos2002@hotmail.com>
//
// Copyright 2021-2022 Kees van Spelde
//
// Licensed under the Apache License, Version 2.0 (the "License");
//
// - You may not use this file except in compliance with the License.
// - You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections;
using System.Collections.Generic;

namespace TesseractOCR.Layout
{
    /// <summary>
    ///     All the <see cref="Paragraphs"/> in the <see cref="Block"/>
    /// </summary>
    public sealed class Paragraphs : IEnumerable<Paragraph>
    {
        #region GetEnumerator
        /// <inheritdoc />
        public IEnumerator<Paragraph> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }

    /// <summary>
    ///     A single <see cref="Paragraph"/> in the <see cref="Block"/>
    /// </summary>
    public sealed class Paragraph : IEnumerator
    {
        #region Properties
        /// <summary>
        ///     All the available <see cref="Lines"/> in this <see cref="Paragraph"/>
        /// </summary>
        public IEnumerable<Lines> Lines { get; }

        /// <summary>
        ///     Returns the current <see cref="Paragraph"/>
        /// </summary>
        public object Current { get; }
        #endregion

        #region MoveNext
        /// <summary>
        ///     Moves to the next <see cref="Paragraph"/> in the <see cref="Block"/>
        /// </summary>
        /// <returns><c>true</c> when there is a next <see cref="Line"/>, otherwise <c>false</c></returns>
        public bool MoveNext()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Reset
        /// <summary>
        ///     Resets the enumerator to the first <see cref="Paragraph"/> in the <see cref="Block"/>
        /// </summary>
        public void Reset()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}