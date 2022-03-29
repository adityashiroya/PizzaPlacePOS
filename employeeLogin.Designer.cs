
namespace PizzaPlaceGUI
{
    partial class customerLogin
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

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerLogin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.returnHome = new System.Windows.Forms.ToolStripButton();
            this.LanguageButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.espaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnHome,
            this.LanguageButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(741, 52);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // returnHome
            // 
            this.returnHome.AutoSize = false;
            this.returnHome.AutoToolTip = false;
            this.returnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.returnHome.Image = global::PizzaPlaceGUI.Properties.Resources.icon2;
            this.returnHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(436, 47);
            this.returnHome.Text = "toolStripButton1";
            this.returnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.returnHome.ToolTipText = "Return to homepage\r\n";
            this.returnHome.Click += new System.EventHandler(this.onHomeClick);
            // 
            // LanguageButton
            // 
            this.LanguageButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LanguageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LanguageButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.espaToolStripMenuItem});
            this.LanguageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LanguageButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LanguageButton.Image = ((System.Drawing.Image)(resources.GetObject("LanguageButton.Image")));
            this.LanguageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.ShowDropDownArrow = false;
            this.LanguageButton.Size = new System.Drawing.Size(65, 47);
            this.LanguageButton.Text = "🌐 ˅";
            this.LanguageButton.ToolTipText = "Language";
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(211, 38);
            this.toolStripComboBox1.Text = "English";
            // 
            // espaToolStripMenuItem
            // 
            this.espaToolStripMenuItem.Name = "espaToolStripMenuItem";
            this.espaToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.espaToolStripMenuItem.Text = "Español";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.Location = new System.Drawing.Point(212, 103);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(302, 37);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "Customer Log In";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(326, 222);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(78, 20);
            this.password.TabIndex = 12;
            this.password.Text = "Password";
            // 
            // phone
            // 
            this.phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(296, 151);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(141, 20);
            this.phone.TabIndex = 13;
            this.phone.Text = "Customer Phone #";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneBox
            // 
            this.phoneBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phoneBox.Location = new System.Drawing.Point(248, 180);
            this.phoneBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(232, 26);
            this.phoneBox.TabIndex = 14;
            // 
            // passBox
            // 
            this.passBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passBox.Location = new System.Drawing.Point(248, 251);
            this.passBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(232, 26);
            this.passBox.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(19)))), ((int)(((byte)(26)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(300, 295);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 57);
            this.button2.TabIndex = 17;
            this.button2.Text = "Log In";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.passwordBoxClick);
            // 
            // customerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.password);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "customerLogin";
            this.Size = new System.Drawing.Size(741, 560);
            this.Load += new System.EventHandler(this.customerLogin_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton returnHome;
        private System.Windows.Forms.ToolStripDropDownButton LanguageButton;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem espaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button button2;
    }
}
