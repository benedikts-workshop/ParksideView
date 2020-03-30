﻿using System;

namespace ParksideView
{
    /// <summary>
    /// Represents a single data packet received from the multimeter.
    /// </summary>
    public struct Packet
    {
        /// <summary>
        /// The mode that the packet was taken in.
        /// </summary>
        public Mode Mode;

        /// <summary>
        /// The range that the value was taken in.
        /// </summary>
        public Range Range;

        /// <summary>
        /// The raw value of the packet.
        /// </summary>
        public short Value;

        /// <summary>
        /// The unknown data (3 byte) in each packet that has not yet been decoded.
        /// </summary>
        public byte[] Unknown;

        /// <summary>
        /// The time at which the packet was received.
        /// </summary>
        public DateTime ReceptionTime;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="mode">The mode that the packet was taken in.</param>
        /// <param name="range">The range that the value was taken in.</param>
        /// <param name="value">The raw value of the packet.</param>
        /// <param name="unknown">The unknown data (3 byte) in each packet that has not yet been decoded.</param>
        /// <param name="receptionTime">The time at which the packet was received.</param>
        public Packet(Mode mode, Range range, short value, byte[] unknown, DateTime receptionTime)
        {
            // Copy the values
            Mode = mode;
            Range = range;
            Value = value;
            Unknown = unknown;
            ReceptionTime = receptionTime;
        }
    }
}
