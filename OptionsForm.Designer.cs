﻿namespace Udpit {
  partial class OptionsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.destinationLabel = new System.Windows.Forms.Label();
      this.destinationBox = new System.Windows.Forms.MaskedTextBox();
      this.errorLabel = new System.Windows.Forms.Label();
      this.errorCheckbox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // destinationLabel
      // 
      this.destinationLabel.AutoSize = true;
      this.destinationLabel.Location = new System.Drawing.Point(12, 15);
      this.destinationLabel.Name = "destinationLabel";
      this.destinationLabel.Size = new System.Drawing.Size(58, 13);
      this.destinationLabel.TabIndex = 0;
      this.destinationLabel.Text = "destination";
      // 
      // destinationBox
      // 
      this.destinationBox.Location = new System.Drawing.Point(76, 12);
      this.destinationBox.Name = "destinationBox";
      this.destinationBox.Size = new System.Drawing.Size(116, 20);
      this.destinationBox.TabIndex = 1;
      // 
      // errorLabel
      // 
      this.errorLabel.AutoSize = true;
      this.errorLabel.Location = new System.Drawing.Point(12, 45);
      this.errorLabel.Name = "errorLabel";
      this.errorLabel.Size = new System.Drawing.Size(54, 13);
      this.errorLabel.TabIndex = 2;
      this.errorLabel.Text = "send error";
      // 
      // errorCheckbox
      // 
      this.errorCheckbox.AutoSize = true;
      this.errorCheckbox.Location = new System.Drawing.Point(76, 45);
      this.errorCheckbox.Name = "errorCheckbox";
      this.errorCheckbox.Size = new System.Drawing.Size(15, 14);
      this.errorCheckbox.TabIndex = 3;
      this.errorCheckbox.UseVisualStyleBackColor = true;
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(204, 71);
      this.Controls.Add(this.errorCheckbox);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.destinationBox);
      this.Controls.Add(this.destinationLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "options";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label destinationLabel;
    private System.Windows.Forms.MaskedTextBox destinationBox;
    private System.Windows.Forms.Label errorLabel;
    private System.Windows.Forms.CheckBox errorCheckbox;
  }
}