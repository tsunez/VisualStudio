﻿using System;

namespace CxViewerAction.Views.DockedView
{
    partial class OptionsAuthCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        [STAThread]
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupAuth = new System.Windows.Forms.GroupBox();
            this.radioButtonSaml = new System.Windows.Forms.RadioButton();
            this.rbUseCredentials = new System.Windows.Forms.RadioButton();
            this.rbUseCurrentUser = new System.Windows.Forms.RadioButton();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btTestConnection = new System.Windows.Forms.Button();
            this.groupAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAuth
            // 
            this.groupAuth.AutoSize = true;
            this.groupAuth.Controls.Add(this.radioButtonSaml);
            this.groupAuth.Controls.Add(this.rbUseCredentials);
            this.groupAuth.Controls.Add(this.rbUseCurrentUser);
            this.groupAuth.Controls.Add(this.txtServer);
            this.groupAuth.Controls.Add(this.txtUserName);
            this.groupAuth.Controls.Add(this.txtPassword);
            this.groupAuth.Controls.Add(this.label3);
            this.groupAuth.Controls.Add(this.label2);
            this.groupAuth.Controls.Add(this.label1);
            this.groupAuth.Location = new System.Drawing.Point(0, 4);
            this.groupAuth.Name = "groupAuth";
            this.groupAuth.Size = new System.Drawing.Size(524, 182);
            this.groupAuth.TabIndex = 0;
            this.groupAuth.TabStop = false;
            this.groupAuth.Text = "Authentication";
            // 
            // radioButtonSaml
            // 
            this.radioButtonSaml.AutoSize = true;
            this.radioButtonSaml.Location = new System.Drawing.Point(40, 36);
            this.radioButtonSaml.Name = "radioButtonSaml";
            this.radioButtonSaml.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSaml.TabIndex = 6;
            this.radioButtonSaml.Text = "SAML";
            this.radioButtonSaml.UseVisualStyleBackColor = true;
            this.radioButtonSaml.CheckedChanged += new System.EventHandler(this.radioButtonSaml_CheckedChanged);
            // 
            // rbUseCredentials
            // 
            this.rbUseCredentials.AutoSize = true;
            this.rbUseCredentials.Checked = true;
            this.rbUseCredentials.Location = new System.Drawing.Point(40, 82);
            this.rbUseCredentials.Name = "rbUseCredentials";
            this.rbUseCredentials.Size = new System.Drawing.Size(99, 17);
            this.rbUseCredentials.TabIndex = 5;
            this.rbUseCredentials.TabStop = true;
            this.rbUseCredentials.Text = "Use Credentials";
            this.rbUseCredentials.UseVisualStyleBackColor = true;
            this.rbUseCredentials.CheckedChanged += new System.EventHandler(this.rbUseCredentials_CheckedChanged);
            // 
            // rbUseCurrentUser
            // 
            this.rbUseCurrentUser.AutoSize = true;
            this.rbUseCurrentUser.Location = new System.Drawing.Point(40, 59);
            this.rbUseCurrentUser.Name = "rbUseCurrentUser";
            this.rbUseCurrentUser.Size = new System.Drawing.Size(106, 17);
            this.rbUseCurrentUser.TabIndex = 4;
            this.rbUseCurrentUser.Text = "Use Current User";
            this.rbUseCurrentUser.UseVisualStyleBackColor = true;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(156, 17);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(218, 20);
            this.txtServer.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 111);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(218, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 143);
            this.txtPassword.MaxLength = 400;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(0, 189);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Apply";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btTestConnection
            // 
            this.btTestConnection.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btTestConnection.Location = new System.Drawing.Point(97, 189);
            this.btTestConnection.Name = "btTestConnection";
            this.btTestConnection.Size = new System.Drawing.Size(116, 23);
            this.btTestConnection.TabIndex = 2;
            this.btTestConnection.Text = "Test Connection";
            this.btTestConnection.UseVisualStyleBackColor = true;
            this.btTestConnection.Click += new System.EventHandler(this.btTestConnection_Click);
            // 
            // OptionsAuthCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupAuth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btTestConnection);
            this.Name = "OptionsAuthCtrl";
            this.Size = new System.Drawing.Size(700, 297);
            this.VisibleChanged += new System.EventHandler(this.OptionsAuthCtrl_VisibleChanged);
            this.groupAuth.ResumeLayout(false);
            this.groupAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.Button btTestConnection;
        private System.Windows.Forms.RadioButton rbUseCredentials;
        private System.Windows.Forms.RadioButton rbUseCurrentUser;
        private System.Windows.Forms.RadioButton radioButtonSaml;
    }
}