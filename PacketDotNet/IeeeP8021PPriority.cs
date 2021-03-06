/*
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
/*
 *  Copyright 2013 Chris Morgan <chmorgan@gmail.com>
 */

using System.Diagnostics.CodeAnalysis;

namespace PacketDotNet
{
    /// <summary>
    /// Ieee p8021 P priorities.
    /// http://en.wikipedia.org/wiki/IEEE_802.1p
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum IeeeP8021PPriority : byte
    {
        /// <summary>
        /// Background
        /// </summary>
        Background = 1,

        /// <summary>
        /// Best effort
        /// </summary>
        BestEffort = 0,

        /// <summary>
        /// Excellent effort
        /// </summary>
        ExcellentEffort = 2,

        /// <summary>
        /// Critical application
        /// </summary>
        CriticalApplications = 3,

        /// <summary>
        /// Video, &lt; 100ms latency and jitter
        /// </summary>
        Video100ms = 4,

        /// <summary>
        /// Voice, &lt; 10ms latency and jitter
        /// </summary>
        Voice10ms = 5,

        /// <summary>
        /// InterNetwork control
        /// </summary>
        InterNetworkControl = 6,

        /// <summary>
        /// Network control
        /// </summary>
        NetworkControl = 7
    }
}