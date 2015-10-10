﻿using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      InitializeComponent();
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void RestartApplication(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    /// Shows the name modal dialog.
    /// </summary>
    private void ShowNameForm(object sender, EventArgs e) {
      var dialog = new NameForm();
      dialog.ShowDialog(this);
      dialog.Dispose();
    }
  }

}
