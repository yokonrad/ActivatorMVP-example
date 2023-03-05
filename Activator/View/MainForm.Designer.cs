namespace Activator.View
{
    partial class MainForm
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
            ConnectionComContainer = new GroupBox();
            ConnectionComId = new ComboBox();
            ConnectionComBusAddress = new ComboBox();
            ConnectionComComNumber = new ComboBox();
            ConnectionComBaudRate = new ComboBox();
            ConnectionComConnect = new Button();
            ConnectionComDisconnect = new Button();
            SettingHwContainer = new GroupBox();
            SettingHwRssi = new ComboBox();
            SettingHwInterval = new ComboBox();
            SettingHwPower = new ComboBox();
            SettingHwAdvanced = new Button();
            LogDeviceContainer = new GroupBox();
            LogDeviceListView = new ListView();
            LogDeviceListViewColumnNull = new ColumnHeader();
            LogDeviceListViewColumnId = new ColumnHeader();
            LogDeviceListViewColumnTime = new ColumnHeader();
            LogDeviceListViewColumnValue = new ColumnHeader();
            ConnectionComContainer.SuspendLayout();
            SettingHwContainer.SuspendLayout();
            LogDeviceContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ConnectionComContainer
            // 
            ConnectionComContainer.Controls.Add(ConnectionComId);
            ConnectionComContainer.Controls.Add(ConnectionComBusAddress);
            ConnectionComContainer.Controls.Add(ConnectionComComNumber);
            ConnectionComContainer.Controls.Add(ConnectionComBaudRate);
            ConnectionComContainer.Controls.Add(ConnectionComConnect);
            ConnectionComContainer.Controls.Add(ConnectionComDisconnect);
            ConnectionComContainer.Location = new Point(8, 6);
            ConnectionComContainer.Name = "ConnectionComContainer";
            ConnectionComContainer.Size = new Size(480, 52);
            ConnectionComContainer.TabIndex = 0;
            ConnectionComContainer.TabStop = false;
            // 
            // ConnectionComId
            // 
            ConnectionComId.DrawMode = DrawMode.OwnerDrawFixed;
            ConnectionComId.DropDownStyle = ComboBoxStyle.DropDownList;
            ConnectionComId.FormattingEnabled = true;
            ConnectionComId.Location = new Point(10, 18);
            ConnectionComId.Name = "ConnectionComId";
            ConnectionComId.Size = new Size(70, 24);
            ConnectionComId.TabIndex = 1;
            ConnectionComId.TabStop = false;
            ConnectionComId.DrawItem += ConnectionComId_DrawItem;
            // 
            // ConnectionComBusAddress
            // 
            ConnectionComBusAddress.DrawMode = DrawMode.OwnerDrawFixed;
            ConnectionComBusAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            ConnectionComBusAddress.FormattingEnabled = true;
            ConnectionComBusAddress.Location = new Point(86, 18);
            ConnectionComBusAddress.Name = "ConnectionComBusAddress";
            ConnectionComBusAddress.Size = new Size(70, 24);
            ConnectionComBusAddress.TabIndex = 2;
            ConnectionComBusAddress.TabStop = false;
            ConnectionComBusAddress.DrawItem += ConnectionComBusAddress_DrawItem;
            // 
            // ConnectionComComNumber
            // 
            ConnectionComComNumber.DrawMode = DrawMode.OwnerDrawFixed;
            ConnectionComComNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            ConnectionComComNumber.FormattingEnabled = true;
            ConnectionComComNumber.Location = new Point(162, 18);
            ConnectionComComNumber.Name = "ConnectionComComNumber";
            ConnectionComComNumber.Size = new Size(70, 24);
            ConnectionComComNumber.TabIndex = 3;
            ConnectionComComNumber.TabStop = false;
            ConnectionComComNumber.DrawItem += ConnectionComComNumber_DrawItem;
            // 
            // ConnectionComBaudRate
            // 
            ConnectionComBaudRate.DrawMode = DrawMode.OwnerDrawFixed;
            ConnectionComBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            ConnectionComBaudRate.FormattingEnabled = true;
            ConnectionComBaudRate.Location = new Point(238, 18);
            ConnectionComBaudRate.Name = "ConnectionComBaudRate";
            ConnectionComBaudRate.Size = new Size(70, 24);
            ConnectionComBaudRate.TabIndex = 4;
            ConnectionComBaudRate.TabStop = false;
            ConnectionComBaudRate.DrawItem += ConnectionComBaudRate_DrawItem;
            // 
            // ConnectionComConnect
            // 
            ConnectionComConnect.Location = new Point(314, 17);
            ConnectionComConnect.Name = "ConnectionComConnect";
            ConnectionComConnect.Size = new Size(75, 26);
            ConnectionComConnect.TabIndex = 5;
            ConnectionComConnect.TabStop = false;
            ConnectionComConnect.UseVisualStyleBackColor = true;
            // 
            // ConnectionComDisconnect
            // 
            ConnectionComDisconnect.Location = new Point(395, 17);
            ConnectionComDisconnect.Name = "ConnectionComDisconnect";
            ConnectionComDisconnect.Size = new Size(75, 26);
            ConnectionComDisconnect.TabIndex = 6;
            ConnectionComDisconnect.TabStop = false;
            ConnectionComDisconnect.UseVisualStyleBackColor = true;
            // 
            // SettingHwContainer
            // 
            SettingHwContainer.Controls.Add(SettingHwRssi);
            SettingHwContainer.Controls.Add(SettingHwInterval);
            SettingHwContainer.Controls.Add(SettingHwPower);
            SettingHwContainer.Controls.Add(SettingHwAdvanced);
            SettingHwContainer.Location = new Point(8, 64);
            SettingHwContainer.Name = "SettingHwContainer";
            SettingHwContainer.Size = new Size(480, 52);
            SettingHwContainer.TabIndex = 7;
            SettingHwContainer.TabStop = false;
            // 
            // SettingHwRssi
            // 
            SettingHwRssi.DrawMode = DrawMode.OwnerDrawFixed;
            SettingHwRssi.DropDownStyle = ComboBoxStyle.DropDownList;
            SettingHwRssi.FormattingEnabled = true;
            SettingHwRssi.Location = new Point(10, 18);
            SettingHwRssi.Name = "SettingHwRssi";
            SettingHwRssi.Size = new Size(70, 24);
            SettingHwRssi.TabIndex = 8;
            SettingHwRssi.TabStop = false;
            SettingHwRssi.DrawItem += SettingHwRssi_DrawItem;
            // 
            // SettingHwInterval
            // 
            SettingHwInterval.DrawMode = DrawMode.OwnerDrawFixed;
            SettingHwInterval.DropDownStyle = ComboBoxStyle.DropDownList;
            SettingHwInterval.FormattingEnabled = true;
            SettingHwInterval.Location = new Point(86, 18);
            SettingHwInterval.Name = "SettingHwInterval";
            SettingHwInterval.Size = new Size(70, 24);
            SettingHwInterval.TabIndex = 9;
            SettingHwInterval.TabStop = false;
            SettingHwInterval.DrawItem += SettingHwInterval_DrawItem;
            // 
            // SettingHwPower
            // 
            SettingHwPower.DrawMode = DrawMode.OwnerDrawFixed;
            SettingHwPower.DropDownStyle = ComboBoxStyle.DropDownList;
            SettingHwPower.FormattingEnabled = true;
            SettingHwPower.Location = new Point(162, 18);
            SettingHwPower.Name = "SettingHwPower";
            SettingHwPower.Size = new Size(70, 24);
            SettingHwPower.TabIndex = 10;
            SettingHwPower.TabStop = false;
            SettingHwPower.DrawItem += SettingHwPower_DrawItem;
            // 
            // SettingHwAdvanced
            // 
            SettingHwAdvanced.Location = new Point(238, 17);
            SettingHwAdvanced.Name = "SettingHwAdvanced";
            SettingHwAdvanced.Size = new Size(232, 26);
            SettingHwAdvanced.TabIndex = 11;
            SettingHwAdvanced.TabStop = false;
            SettingHwAdvanced.UseVisualStyleBackColor = true;
            // 
            // LogDeviceContainer
            // 
            LogDeviceContainer.Controls.Add(LogDeviceListView);
            LogDeviceContainer.Location = new Point(8, 122);
            LogDeviceContainer.Name = "LogDeviceContainer";
            LogDeviceContainer.Size = new Size(480, 485);
            LogDeviceContainer.TabIndex = 12;
            LogDeviceContainer.TabStop = false;
            // 
            // LogDeviceListView
            // 
            LogDeviceListView.Columns.AddRange(new ColumnHeader[] { LogDeviceListViewColumnNull, LogDeviceListViewColumnId, LogDeviceListViewColumnTime, LogDeviceListViewColumnValue });
            LogDeviceListView.FullRowSelect = true;
            LogDeviceListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LogDeviceListView.Location = new Point(10, 18);
            LogDeviceListView.Name = "LogDeviceListView";
            LogDeviceListView.ShowItemToolTips = true;
            LogDeviceListView.Size = new Size(460, 457);
            LogDeviceListView.TabIndex = 13;
            LogDeviceListView.TabStop = false;
            LogDeviceListView.UseCompatibleStateImageBehavior = false;
            LogDeviceListView.View = System.Windows.Forms.View.Details;
            LogDeviceListView.ColumnWidthChanged += LogDeviceListView_ColumnWidthChanged;
            // 
            // LogDeviceListViewColumnId
            // 
            LogDeviceListViewColumnId.TextAlign = HorizontalAlignment.Center;
            // 
            // LogDeviceListViewColumnTime
            // 
            LogDeviceListViewColumnTime.TextAlign = HorizontalAlignment.Center;
            // 
            // LogDeviceListViewColumnValue
            // 
            LogDeviceListViewColumnValue.TextAlign = HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 615);
            Controls.Add(ConnectionComContainer);
            Controls.Add(SettingHwContainer);
            Controls.Add(LogDeviceContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            ConnectionComContainer.ResumeLayout(false);
            SettingHwContainer.ResumeLayout(false);
            LogDeviceContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ConnectionComContainer;
        private ComboBox ConnectionComId;
        private ComboBox ConnectionComBusAddress;
        private ComboBox ConnectionComComNumber;
        private ComboBox ConnectionComBaudRate;
        private Button ConnectionComConnect;
        private Button ConnectionComDisconnect;
        private GroupBox SettingHwContainer;
        private ComboBox SettingHwRssi;
        private ComboBox SettingHwInterval;
        private ComboBox SettingHwPower;
        private Button SettingHwAdvanced;
        private GroupBox LogDeviceContainer;
        private ListView LogDeviceListView;
        private ColumnHeader LogDeviceListViewColumnNull;
        private ColumnHeader LogDeviceListViewColumnId;
        private ColumnHeader LogDeviceListViewColumnTime;
        private ColumnHeader LogDeviceListViewColumnValue;
    }
}