namespace CayleyTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.drawPanel = new System.Windows.Forms.Panel();
            this.panelPropt = new System.Windows.Forms.Panel();
            this.txtBoxLengh = new System.Windows.Forms.TextBox();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.txtBoxBifurcate = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.txtBoxPer2 = new System.Windows.Forms.TextBox();
            this.labelPer2 = new System.Windows.Forms.Label();
            this.txtBoxPer1 = new System.Windows.Forms.TextBox();
            this.txtBoxTh2 = new System.Windows.Forms.TextBox();
            this.txtBoxTh1 = new System.Windows.Forms.TextBox();
            this.labelPer1 = new System.Windows.Forms.Label();
            this.labelTh2 = new System.Windows.Forms.Label();
            this.labelTh1 = new System.Windows.Forms.Label();
            this.checkBoxRd = new System.Windows.Forms.CheckBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.dialogColor = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelPropt.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawPanel
            // 
            this.drawPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drawPanel.Location = new System.Drawing.Point(22, 22);
            this.drawPanel.Name = "drawPanel";
            this.drawPanel.Size = new System.Drawing.Size(609, 650);
            this.drawPanel.TabIndex = 29;
            this.drawPanel.Resize += new System.EventHandler(this.DrawPanelResized);
            // 
            // panelPropt
            // 
            this.panelPropt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPropt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPropt.Controls.Add(this.btnColor);
            this.panelPropt.Controls.Add(this.txtBoxLengh);
            this.panelPropt.Controls.Add(this.labelLength);
            this.panelPropt.Controls.Add(this.labelN);
            this.panelPropt.Controls.Add(this.txtBoxN);
            this.panelPropt.Controls.Add(this.txtBoxBifurcate);
            this.panelPropt.Controls.Add(this.labelK);
            this.panelPropt.Controls.Add(this.txtBoxPer2);
            this.panelPropt.Controls.Add(this.labelPer2);
            this.panelPropt.Controls.Add(this.txtBoxPer1);
            this.panelPropt.Controls.Add(this.txtBoxTh2);
            this.panelPropt.Controls.Add(this.txtBoxTh1);
            this.panelPropt.Controls.Add(this.labelPer1);
            this.panelPropt.Controls.Add(this.labelTh2);
            this.panelPropt.Controls.Add(this.labelTh1);
            this.panelPropt.Controls.Add(this.checkBoxRd);
            this.panelPropt.Controls.Add(this.drawButton);
            this.panelPropt.Location = new System.Drawing.Point(646, 22);
            this.panelPropt.Name = "panelPropt";
            this.panelPropt.Size = new System.Drawing.Size(290, 650);
            this.panelPropt.TabIndex = 30;
            // 
            // txtBoxLengh
            // 
            this.txtBoxLengh.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxLengh.Location = new System.Drawing.Point(100, 421);
            this.txtBoxLengh.Name = "txtBoxLengh";
            this.txtBoxLengh.Size = new System.Drawing.Size(107, 27);
            this.txtBoxLengh.TabIndex = 59;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLength.Location = new System.Drawing.Point(25, 424);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(64, 20);
            this.labelLength.TabIndex = 58;
            this.labelLength.Text = "Length:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN.Location = new System.Drawing.Point(64, 200);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(25, 20);
            this.labelN.TabIndex = 57;
            this.labelN.Text = "N:";
            // 
            // txtBoxN
            // 
            this.txtBoxN.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxN.Location = new System.Drawing.Point(99, 196);
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(107, 27);
            this.txtBoxN.TabIndex = 56;
            // 
            // txtBoxBifurcate
            // 
            this.txtBoxBifurcate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxBifurcate.Location = new System.Drawing.Point(99, 468);
            this.txtBoxBifurcate.Name = "txtBoxBifurcate";
            this.txtBoxBifurcate.Size = new System.Drawing.Size(107, 27);
            this.txtBoxBifurcate.TabIndex = 52;
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelK.Location = new System.Drawing.Point(13, 471);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(77, 20);
            this.labelK.TabIndex = 51;
            this.labelK.Text = "Bifurcate:";
            // 
            // txtBoxPer2
            // 
            this.txtBoxPer2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPer2.Location = new System.Drawing.Point(99, 375);
            this.txtBoxPer2.Name = "txtBoxPer2";
            this.txtBoxPer2.Size = new System.Drawing.Size(107, 27);
            this.txtBoxPer2.TabIndex = 50;
            // 
            // labelPer2
            // 
            this.labelPer2.AutoSize = true;
            this.labelPer2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPer2.Location = new System.Drawing.Point(42, 378);
            this.labelPer2.Name = "labelPer2";
            this.labelPer2.Size = new System.Drawing.Size(47, 20);
            this.labelPer2.TabIndex = 49;
            this.labelPer2.Text = "per2:";
            // 
            // txtBoxPer1
            // 
            this.txtBoxPer1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPer1.Location = new System.Drawing.Point(99, 329);
            this.txtBoxPer1.Name = "txtBoxPer1";
            this.txtBoxPer1.Size = new System.Drawing.Size(107, 27);
            this.txtBoxPer1.TabIndex = 48;
            // 
            // txtBoxTh2
            // 
            this.txtBoxTh2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxTh2.Location = new System.Drawing.Point(99, 285);
            this.txtBoxTh2.Name = "txtBoxTh2";
            this.txtBoxTh2.Size = new System.Drawing.Size(107, 27);
            this.txtBoxTh2.TabIndex = 47;
            // 
            // txtBoxTh1
            // 
            this.txtBoxTh1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxTh1.Location = new System.Drawing.Point(99, 242);
            this.txtBoxTh1.Name = "txtBoxTh1";
            this.txtBoxTh1.Size = new System.Drawing.Size(107, 27);
            this.txtBoxTh1.TabIndex = 46;
            // 
            // labelPer1
            // 
            this.labelPer1.AutoSize = true;
            this.labelPer1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPer1.Location = new System.Drawing.Point(43, 332);
            this.labelPer1.Name = "labelPer1";
            this.labelPer1.Size = new System.Drawing.Size(47, 20);
            this.labelPer1.TabIndex = 45;
            this.labelPer1.Text = "per1:";
            // 
            // labelTh2
            // 
            this.labelTh2.AutoSize = true;
            this.labelTh2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTh2.Location = new System.Drawing.Point(52, 288);
            this.labelTh2.Name = "labelTh2";
            this.labelTh2.Size = new System.Drawing.Size(37, 20);
            this.labelTh2.TabIndex = 44;
            this.labelTh2.Text = "th2:";
            // 
            // labelTh1
            // 
            this.labelTh1.AutoSize = true;
            this.labelTh1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTh1.Location = new System.Drawing.Point(52, 244);
            this.labelTh1.Name = "labelTh1";
            this.labelTh1.Size = new System.Drawing.Size(37, 20);
            this.labelTh1.TabIndex = 43;
            this.labelTh1.Text = "th1:";
            // 
            // checkBoxRd
            // 
            this.checkBoxRd.AutoSize = true;
            this.checkBoxRd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxRd.Location = new System.Drawing.Point(68, 144);
            this.checkBoxRd.Name = "checkBoxRd";
            this.checkBoxRd.Size = new System.Drawing.Size(162, 31);
            this.checkBoxRd.TabIndex = 30;
            this.checkBoxRd.Text = "Random Tree";
            this.checkBoxRd.UseVisualStyleBackColor = true;
            // 
            // drawButton
            // 
            this.drawButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.drawButton.Location = new System.Drawing.Point(69, 54);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(161, 66);
            this.drawButton.TabIndex = 29;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Cyan;
            this.btnColor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnColor.Location = new System.Drawing.Point(100, 520);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 43);
            this.btnColor.TabIndex = 60;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 700);
            this.Controls.Add(this.drawPanel);
            this.Controls.Add(this.panelPropt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CayLey Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPropt.ResumeLayout(false);
            this.panelPropt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel drawPanel;
        private System.Windows.Forms.Panel panelPropt;
        private System.Windows.Forms.TextBox txtBoxBifurcate;
        private System.Windows.Forms.Label labelK;
        private System.Windows.Forms.TextBox txtBoxPer2;
        private System.Windows.Forms.Label labelPer2;
        private System.Windows.Forms.TextBox txtBoxPer1;
        private System.Windows.Forms.TextBox txtBoxTh2;
        private System.Windows.Forms.TextBox txtBoxTh1;
        private System.Windows.Forms.Label labelPer1;
        private System.Windows.Forms.Label labelTh2;
        private System.Windows.Forms.Label labelTh1;
        private System.Windows.Forms.CheckBox checkBoxRd;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox txtBoxLengh;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.ColorDialog dialogColor;
        private System.Windows.Forms.Button btnColor;
    }
}

