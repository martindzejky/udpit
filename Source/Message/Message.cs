﻿using System;
using System.Collections.Generic;
using System.Net;

namespace Udpit {

  /// <summary>
  ///   Message information and fragments.
  /// </summary>
  internal class Message {

    public Message(ushort fragmentCount, MessageOrigin origin = MessageOrigin.Local) {
      // set fragment count
      FragmentCount = fragmentCount;

      // set origin
      Origin = origin;

      // generate an id
      Id[0] = (byte)DateTime.Now.Minute;
      Id[1] = (byte)DateTime.Now.Second;
    }

    public Message(ushort fragmentCount, SortedList<ushort, byte[]> fragments, MessageOrigin origin = MessageOrigin.Local) : this(fragmentCount, origin) {
      // set the list
      FragmentList = fragments;
    }

    public Message(ushort fragmentCount, byte[] id, MessageOrigin origin = MessageOrigin.Remote) {
      // set fragment count
      FragmentCount = fragmentCount;

      // set origin
      Origin = origin;

      // set the id
      Id[0] = id[0];
      Id[1] = id[1];
    }

    /// <summary>
    ///   Number of fragments.
    /// </summary>
    public ushort FragmentCount { get; }

    /// <summary>
    ///   The sorted list of fragments.
    /// </summary>
    /// <remarks>
    ///   In the source this is a list of all fragments.
    ///   In the destination this is a list of received and checked fragments.
    /// </remarks>
    public SortedList<ushort, byte[]> FragmentList { get; } = new SortedList<ushort, byte[]>();

    /// <summary>
    ///   Message id.
    /// </summary>
    public byte[] Id { get; } = new byte[2];

    /// <summary>
    ///   The origin of the message.
    /// </summary>
    public MessageOrigin Origin { get; }

    /// <summary>
    ///   Remote's ip and port.
    /// </summary>
    public IPEndPoint RemoteEndPoint { get; set; }

    /// <summary>
    ///   Remote's name.
    /// </summary>
    public string RemoteName { get; set; }

    /// <summary>
    ///   The current status of the message.
    /// </summary>
    public MessageStatus Status = MessageStatus.Created;

  }

}
