﻿using System;
using System.Net;
using System.Net.Sockets;

namespace Udpit {

  /// <summary>
  ///   Receives fragments. Lets others know via events.
  /// </summary>
  internal class Receiver {

    /// <summary>
    ///   Delegate for the fragment event.
    /// </summary>
    public delegate void FragmentDelegate(byte[] fragment, IPEndPoint remoteEndPoint);

    /// <summary>
    ///   Fired when a fragment is received.
    /// </summary>
    public event FragmentDelegate FragmentReceived;

    private Receiver() {
      // set up the UDP client
      _udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
      _udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, Options.Port));

      // start listening
      Listen();
    }

    /// <summary>
    ///   Creates the singleton instance.
    /// </summary>
    public static Receiver Create() {
      // check instance
      if (Singleton != null)
        return Singleton;

      // create instance
      Singleton = new Receiver();

      // return it
      return Singleton;
    }

    /// <summary>
    ///   Starts listening.
    /// </summary>
    private void Listen() {
      _udpClient.BeginReceive(OnReceive, null);
    }

    /// <summary>
    ///   Called on incoming fragment.
    /// </summary>
    private void OnReceive(IAsyncResult ar) {
      // receive fragment
      var remoteEndPoint = new IPEndPoint(IPAddress.Any, Options.Port);
      var fragment = _udpClient.EndReceive(ar, ref remoteEndPoint);

      // listen again
      Listen();

      // fire an event
      FragmentReceived?.Invoke(fragment, remoteEndPoint);
    }

    /// <summary>
    ///   The singleton instance.
    /// </summary>
    public static Receiver Singleton { get; private set; }

    /// <summary>
    ///   The UDP client.
    /// </summary>
    private readonly UdpClient _udpClient = new UdpClient();

  }

}
