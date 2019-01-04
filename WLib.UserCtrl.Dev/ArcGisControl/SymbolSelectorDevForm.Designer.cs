﻿namespace WLib.UserCtrls.Dev.ArcGisControl
{
    partial class SymbolSelectorDevForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymbolSelectorDevForm));
            this.axSymbologyControl1 = new ESRI.ArcGIS.Controls.AxSymbologyControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbPreview = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new DevExpress.XtraEditors.ColorEdit();
            this.btnOutlineColor = new DevExpress.XtraEditors.ColorEdit();
            this.nudAngle = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblOutlineColor = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnMoreSymbols = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStripMoreSymbol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.axSymbologyControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutlineColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axSymbologyControl1
            // 
            this.axSymbologyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axSymbologyControl1.Location = new System.Drawing.Point(3, 3);
            this.axSymbologyControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axSymbologyControl1.Name = "axSymbologyControl1";
            this.axSymbologyControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSymbologyControl1.OcxState")));
            this.axSymbologyControl1.Size = new System.Drawing.Size(414, 567);
            this.axSymbologyControl1.TabIndex = 0;
            this.axSymbologyControl1.OnDoubleClick += new ESRI.ArcGIS.Controls.ISymbologyControlEvents_Ax_OnDoubleClickEventHandler(this.axSymbologyControl1_OnDoubleClick);
            this.axSymbologyControl1.OnStyleClassChanged += new ESRI.ArcGIS.Controls.ISymbologyControlEvents_Ax_OnStyleClassChangedEventHandler(this.axSymbologyControl1_OnStyleClassChanged);
            this.axSymbologyControl1.OnItemSelected += new ESRI.ArcGIS.Controls.ISymbologyControlEvents_Ax_OnItemSelectedEventHandler(this.axSymbologyControl1_OnItemSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ptbPreview);
            this.groupBox1.Location = new System.Drawing.Point(16, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(155, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "预览";
            // 
            // ptbPreview
            // 
            this.ptbPreview.Location = new System.Drawing.Point(7, 27);
            this.ptbPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbPreview.Name = "ptbPreview";
            this.ptbPreview.Size = new System.Drawing.Size(139, 116);
            this.ptbPreview.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.btnOutlineColor);
            this.groupBox2.Controls.Add(this.nudAngle);
            this.groupBox2.Controls.Add(this.nudWidth);
            this.groupBox2.Controls.Add(this.nudSize);
            this.groupBox2.Controls.Add(this.lblAngle);
            this.groupBox2.Controls.Add(this.lblWidth);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.lblOutlineColor);
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Location = new System.Drawing.Point(16, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(155, 235);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // btnColor
            // 
            this.btnColor.EditValue = System.Drawing.Color.Empty;
            this.btnColor.Location = new System.Drawing.Point(77, 28);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColor.Name = "btnColor";
            this.btnColor.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Properties.Appearance.Options.UseForeColor = true;
            this.btnColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnColor.Size = new System.Drawing.Size(70, 25);
            this.btnColor.TabIndex = 1;
            this.btnColor.EditValueChanged += new System.EventHandler(this.btnColor_EditValueChanged);
            // 
            // btnOutlineColor
            // 
            this.btnOutlineColor.EditValue = System.Drawing.Color.Empty;
            this.btnOutlineColor.Location = new System.Drawing.Point(77, 71);
            this.btnOutlineColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOutlineColor.Name = "btnOutlineColor";
            this.btnOutlineColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.btnOutlineColor.Size = new System.Drawing.Size(70, 25);
            this.btnOutlineColor.TabIndex = 1;
            this.btnOutlineColor.EditValueChanged += new System.EventHandler(this.btnOutlineColor_EditValueChanged);
            // 
            // nudAngle
            // 
            this.nudAngle.DecimalPlaces = 2;
            this.nudAngle.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAngle.Location = new System.Drawing.Point(57, 192);
            this.nudAngle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudAngle.Name = "nudAngle";
            this.nudAngle.Size = new System.Drawing.Size(89, 26);
            this.nudAngle.TabIndex = 1;
            this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.DecimalPlaces = 2;
            this.nudWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudWidth.Location = new System.Drawing.Point(57, 154);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(89, 26);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudSize
            // 
            this.nudSize.DecimalPlaces = 2;
            this.nudSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSize.Location = new System.Drawing.Point(57, 118);
            this.nudSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(89, 26);
            this.nudSize.TabIndex = 1;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(7, 194);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(38, 18);
            this.lblAngle.TabIndex = 0;
            this.lblAngle.Text = "角度";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(7, 154);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(38, 18);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "宽度";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(7, 118);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 18);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "大小";
            // 
            // lblOutlineColor
            // 
            this.lblOutlineColor.AutoSize = true;
            this.lblOutlineColor.Location = new System.Drawing.Point(7, 75);
            this.lblOutlineColor.Name = "lblOutlineColor";
            this.lblOutlineColor.Size = new System.Drawing.Size(68, 18);
            this.lblOutlineColor.TabIndex = 0;
            this.lblOutlineColor.Text = "外框颜色";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(7, 32);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(38, 18);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "颜色";
            // 
            // btnMoreSymbols
            // 
            this.btnMoreSymbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoreSymbols.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnMoreSymbols.Location = new System.Drawing.Point(70, 427);
            this.btnMoreSymbols.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMoreSymbols.Name = "btnMoreSymbols";
            this.btnMoreSymbols.Size = new System.Drawing.Size(101, 37);
            this.btnMoreSymbols.TabIndex = 3;
            this.btnMoreSymbols.Text = "更多符号";
            this.btnMoreSymbols.Click += new System.EventHandler(this.btnMoreSymbols_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnOK.Location = new System.Drawing.Point(70, 472);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 37);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(70, 513);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&X)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contextMenuStripMoreSymbol
            // 
            this.contextMenuStripMoreSymbol.Name = "contextMenuStripMoreSymbol";
            this.contextMenuStripMoreSymbol.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripMoreSymbol.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStripMoreSymbol_ItemClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.btnCancel);
            this.panelControl1.Controls.Add(this.btnMoreSymbols);
            this.panelControl1.Controls.Add(this.btnOK);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(417, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(183, 567);
            this.panelControl1.TabIndex = 4;
            // 
            // SymbolSelectorDevForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(603, 573);
            this.Controls.Add(this.axSymbologyControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 481);
            this.Name = "SymbolSelectorDevForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "符号选择器";
            this.Load += new System.EventHandler(this.SymbolSelectorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axSymbologyControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPreview.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOutlineColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxSymbologyControl axSymbologyControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PictureEdit ptbPreview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblOutlineColor;
        private System.Windows.Forms.Label lblColor;
        private DevExpress.XtraEditors.SimpleButton btnMoreSymbols;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMoreSymbol;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraEditors.ColorEdit btnOutlineColor;
        private DevExpress.XtraEditors.ColorEdit btnColor;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}