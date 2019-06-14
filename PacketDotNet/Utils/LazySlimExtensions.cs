﻿/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace PacketDotNet.Utils
{
    public static class LazySlimExtensions
    {
        /// <summary>
        /// Evaluates the specified lazy function, if necessary.
        /// </summary>
        /// <param name="lazy">The lazy.</param>
        public static void Evaluate<T>(this LazySlim<T> lazy) where T : class
        {
            if (lazy.IsValueCreated)
                return;


            var _ = lazy.Value;
        }
    }
}