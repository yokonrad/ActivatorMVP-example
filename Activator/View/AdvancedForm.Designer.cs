namespace Activator.View
{
    partial class AdvancedForm
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
            TabControl = new TabControl();
            TabControlPage1 = new TabPage();
            NameContainer = new GroupBox();
            NameInput = new TextBox();
            NameButton = new Button();
            SerialNumberContainer = new GroupBox();
            SerialNumberInput = new TextBox();
            SerialNumberButton = new Button();
            BusAddressContainer = new GroupBox();
            BusAddressInput = new ComboBox();
            BusAddressButton = new Button();
            RebootContainer = new GroupBox();
            RebootButton = new Button();
            TabControlPage2 = new TabPage();
            VerifyCodeContainer = new GroupBox();
            VerifyCodeInput = new ComboBox();
            VerifyCodeButton = new Button();
            WorkTypeContainer = new GroupBox();
            WorkTypeInput = new ComboBox();
            WorkTypeButton = new Button();
            BitRateContainer = new GroupBox();
            BitRateInput = new ComboBox();
            BitRateButton = new Button();
            TriggerTypeContainer = new GroupBox();
            TriggerTypeInput = new ComboBox();
            TriggerTypeButton = new Button();
            RssiContainer = new GroupBox();
            RssiInput = new ComboBox();
            RssiButton = new Button();
            FrequencyContainer = new GroupBox();
            FrequencyInput = new ComboBox();
            FrequencyButton = new Button();
            IntervalContainer = new GroupBox();
            IntervalInput = new ComboBox();
            IntervalButton = new Button();
            PowerContainer = new GroupBox();
            PowerInput = new ComboBox();
            PowerButton = new Button();
            BaudRateContainer = new GroupBox();
            BaudRateInput = new ComboBox();
            BaudRateButton = new Button();
            RestoreDefaultsContainer = new GroupBox();
            RestoreDefaultsButton = new Button();
            TabControl.SuspendLayout();
            TabControlPage1.SuspendLayout();
            NameContainer.SuspendLayout();
            SerialNumberContainer.SuspendLayout();
            BusAddressContainer.SuspendLayout();
            RebootContainer.SuspendLayout();
            TabControlPage2.SuspendLayout();
            VerifyCodeContainer.SuspendLayout();
            WorkTypeContainer.SuspendLayout();
            BitRateContainer.SuspendLayout();
            TriggerTypeContainer.SuspendLayout();
            RssiContainer.SuspendLayout();
            FrequencyContainer.SuspendLayout();
            IntervalContainer.SuspendLayout();
            PowerContainer.SuspendLayout();
            BaudRateContainer.SuspendLayout();
            RestoreDefaultsContainer.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(TabControlPage1);
            TabControl.Controls.Add(TabControlPage2);
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(310, 615);
            TabControl.SizeMode = TabSizeMode.Fixed;
            TabControl.TabIndex = 0;
            TabControl.TabStop = false;
            // 
            // TabControlPage1
            // 
            TabControlPage1.Controls.Add(NameContainer);
            TabControlPage1.Controls.Add(SerialNumberContainer);
            TabControlPage1.Controls.Add(BusAddressContainer);
            TabControlPage1.Controls.Add(RebootContainer);
            TabControlPage1.Location = new Point(4, 24);
            TabControlPage1.Name = "TabControlPage1";
            TabControlPage1.Padding = new Padding(3);
            TabControlPage1.Size = new Size(302, 587);
            TabControlPage1.TabIndex = 1;
            // 
            // NameContainer
            // 
            NameContainer.Controls.Add(NameInput);
            NameContainer.Controls.Add(NameButton);
            NameContainer.Location = new Point(8, 6);
            NameContainer.Name = "NameContainer";
            NameContainer.Size = new Size(286, 51);
            NameContainer.TabIndex = 2;
            NameContainer.TabStop = false;
            // 
            // NameInput
            // 
            NameInput.Location = new Point(10, 18);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(160, 23);
            NameInput.TabIndex = 3;
            NameInput.TabStop = false;
            NameInput.TextAlign = HorizontalAlignment.Center;
            // 
            // NameButton
            // 
            NameButton.Location = new Point(176, 17);
            NameButton.Name = "NameButton";
            NameButton.Size = new Size(100, 25);
            NameButton.TabIndex = 4;
            NameButton.TabStop = false;
            NameButton.UseVisualStyleBackColor = true;
            // 
            // SerialNumberContainer
            // 
            SerialNumberContainer.Controls.Add(SerialNumberInput);
            SerialNumberContainer.Controls.Add(SerialNumberButton);
            SerialNumberContainer.Location = new Point(8, 63);
            SerialNumberContainer.Name = "SerialNumberContainer";
            SerialNumberContainer.Size = new Size(286, 51);
            SerialNumberContainer.TabIndex = 5;
            SerialNumberContainer.TabStop = false;
            // 
            // SerialNumberInput
            // 
            SerialNumberInput.Location = new Point(10, 18);
            SerialNumberInput.Name = "SerialNumberInput";
            SerialNumberInput.Size = new Size(160, 23);
            SerialNumberInput.TabIndex = 6;
            SerialNumberInput.TabStop = false;
            SerialNumberInput.TextAlign = HorizontalAlignment.Center;
            // 
            // SerialNumberButton
            // 
            SerialNumberButton.Location = new Point(176, 17);
            SerialNumberButton.Name = "SerialNumberButton";
            SerialNumberButton.Size = new Size(100, 25);
            SerialNumberButton.TabIndex = 7;
            SerialNumberButton.TabStop = false;
            SerialNumberButton.UseVisualStyleBackColor = true;
            // 
            // BusAddressContainer
            // 
            BusAddressContainer.Controls.Add(BusAddressInput);
            BusAddressContainer.Controls.Add(BusAddressButton);
            BusAddressContainer.Location = new Point(8, 120);
            BusAddressContainer.Name = "BusAddressContainer";
            BusAddressContainer.Size = new Size(286, 52);
            BusAddressContainer.TabIndex = 8;
            BusAddressContainer.TabStop = false;
            // 
            // BusAddressInput
            // 
            BusAddressInput.DrawMode = DrawMode.OwnerDrawFixed;
            BusAddressInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BusAddressInput.Location = new Point(10, 18);
            BusAddressInput.Name = "BusAddressInput";
            BusAddressInput.Size = new Size(160, 24);
            BusAddressInput.TabIndex = 9;
            BusAddressInput.TabStop = false;
            BusAddressInput.DrawItem += BusAddressInput_DrawItem;
            // 
            // BusAddressButton
            // 
            BusAddressButton.Location = new Point(176, 17);
            BusAddressButton.Name = "BusAddressButton";
            BusAddressButton.Size = new Size(100, 26);
            BusAddressButton.TabIndex = 10;
            BusAddressButton.TabStop = false;
            BusAddressButton.UseVisualStyleBackColor = true;
            // 
            // RebootContainer
            // 
            RebootContainer.Controls.Add(RebootButton);
            RebootContainer.Location = new Point(8, 178);
            RebootContainer.Name = "RebootContainer";
            RebootContainer.Size = new Size(286, 51);
            RebootContainer.TabIndex = 11;
            RebootContainer.TabStop = false;
            // 
            // RebootButton
            // 
            RebootButton.Location = new Point(10, 17);
            RebootButton.Name = "RebootButton";
            RebootButton.Size = new Size(266, 25);
            RebootButton.TabIndex = 12;
            RebootButton.TabStop = false;
            RebootButton.UseVisualStyleBackColor = true;
            // 
            // TabControlPage2
            // 
            TabControlPage2.Controls.Add(VerifyCodeContainer);
            TabControlPage2.Controls.Add(WorkTypeContainer);
            TabControlPage2.Controls.Add(BitRateContainer);
            TabControlPage2.Controls.Add(TriggerTypeContainer);
            TabControlPage2.Controls.Add(RssiContainer);
            TabControlPage2.Controls.Add(FrequencyContainer);
            TabControlPage2.Controls.Add(IntervalContainer);
            TabControlPage2.Controls.Add(PowerContainer);
            TabControlPage2.Controls.Add(BaudRateContainer);
            TabControlPage2.Controls.Add(RestoreDefaultsContainer);
            TabControlPage2.Location = new Point(4, 24);
            TabControlPage2.Name = "TabControlPage2";
            TabControlPage2.Padding = new Padding(3);
            TabControlPage2.Size = new Size(302, 587);
            TabControlPage2.TabIndex = 13;
            // 
            // VerifyCodeContainer
            // 
            VerifyCodeContainer.Controls.Add(VerifyCodeInput);
            VerifyCodeContainer.Controls.Add(VerifyCodeButton);
            VerifyCodeContainer.Location = new Point(8, 6);
            VerifyCodeContainer.Name = "VerifyCodeContainer";
            VerifyCodeContainer.Size = new Size(286, 52);
            VerifyCodeContainer.TabIndex = 14;
            VerifyCodeContainer.TabStop = false;
            // 
            // VerifyCodeInput
            // 
            VerifyCodeInput.DrawMode = DrawMode.OwnerDrawFixed;
            VerifyCodeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            VerifyCodeInput.Location = new Point(10, 18);
            VerifyCodeInput.Name = "VerifyCodeInput";
            VerifyCodeInput.Size = new Size(160, 24);
            VerifyCodeInput.TabIndex = 15;
            VerifyCodeInput.TabStop = false;
            VerifyCodeInput.DrawItem += VerifyCodeInput_DrawItem;
            // 
            // VerifyCodeButton
            // 
            VerifyCodeButton.Location = new Point(176, 17);
            VerifyCodeButton.Name = "VerifyCodeButton";
            VerifyCodeButton.Size = new Size(100, 26);
            VerifyCodeButton.TabIndex = 16;
            VerifyCodeButton.TabStop = false;
            VerifyCodeButton.UseVisualStyleBackColor = true;
            // 
            // WorkTypeContainer
            // 
            WorkTypeContainer.Controls.Add(WorkTypeInput);
            WorkTypeContainer.Controls.Add(WorkTypeButton);
            WorkTypeContainer.Location = new Point(8, 64);
            WorkTypeContainer.Name = "WorkTypeContainer";
            WorkTypeContainer.Size = new Size(286, 52);
            WorkTypeContainer.TabIndex = 17;
            WorkTypeContainer.TabStop = false;
            // 
            // WorkTypeInput
            // 
            WorkTypeInput.DrawMode = DrawMode.OwnerDrawFixed;
            WorkTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            WorkTypeInput.Location = new Point(10, 18);
            WorkTypeInput.Name = "WorkTypeInput";
            WorkTypeInput.Size = new Size(160, 24);
            WorkTypeInput.TabIndex = 18;
            WorkTypeInput.TabStop = false;
            WorkTypeInput.DrawItem += WorkTypeInput_DrawItem;
            // 
            // WorkTypeButton
            // 
            WorkTypeButton.Location = new Point(176, 17);
            WorkTypeButton.Name = "WorkTypeButton";
            WorkTypeButton.Size = new Size(100, 26);
            WorkTypeButton.TabIndex = 19;
            WorkTypeButton.TabStop = false;
            WorkTypeButton.UseVisualStyleBackColor = true;
            // 
            // BitRateContainer
            // 
            BitRateContainer.Controls.Add(BitRateInput);
            BitRateContainer.Controls.Add(BitRateButton);
            BitRateContainer.Location = new Point(8, 122);
            BitRateContainer.Name = "BitRateContainer";
            BitRateContainer.Size = new Size(286, 52);
            BitRateContainer.TabIndex = 20;
            BitRateContainer.TabStop = false;
            // 
            // BitRateInput
            // 
            BitRateInput.DrawMode = DrawMode.OwnerDrawFixed;
            BitRateInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BitRateInput.Location = new Point(10, 18);
            BitRateInput.Name = "BitRateInput";
            BitRateInput.Size = new Size(160, 24);
            BitRateInput.TabIndex = 21;
            BitRateInput.TabStop = false;
            BitRateInput.DrawItem += BitRateInput_DrawItem;
            // 
            // BitRateButton
            // 
            BitRateButton.Location = new Point(176, 17);
            BitRateButton.Name = "BitRateButton";
            BitRateButton.Size = new Size(100, 26);
            BitRateButton.TabIndex = 22;
            BitRateButton.TabStop = false;
            BitRateButton.UseVisualStyleBackColor = true;
            // 
            // TriggerTypeContainer
            // 
            TriggerTypeContainer.Controls.Add(TriggerTypeInput);
            TriggerTypeContainer.Controls.Add(TriggerTypeButton);
            TriggerTypeContainer.Location = new Point(8, 180);
            TriggerTypeContainer.Name = "TriggerTypeContainer";
            TriggerTypeContainer.Size = new Size(286, 52);
            TriggerTypeContainer.TabIndex = 23;
            TriggerTypeContainer.TabStop = false;
            // 
            // TriggerTypeInput
            // 
            TriggerTypeInput.DrawMode = DrawMode.OwnerDrawFixed;
            TriggerTypeInput.DropDownStyle = ComboBoxStyle.DropDownList;
            TriggerTypeInput.Location = new Point(10, 18);
            TriggerTypeInput.Name = "TriggerTypeInput";
            TriggerTypeInput.Size = new Size(160, 24);
            TriggerTypeInput.TabIndex = 24;
            TriggerTypeInput.TabStop = false;
            TriggerTypeInput.DrawItem += TriggerTypeInput_DrawItem;
            // 
            // TriggerTypeButton
            // 
            TriggerTypeButton.Location = new Point(176, 17);
            TriggerTypeButton.Name = "TriggerTypeButton";
            TriggerTypeButton.Size = new Size(100, 26);
            TriggerTypeButton.TabIndex = 25;
            TriggerTypeButton.TabStop = false;
            TriggerTypeButton.UseVisualStyleBackColor = true;
            // 
            // RssiContainer
            // 
            RssiContainer.Controls.Add(RssiInput);
            RssiContainer.Controls.Add(RssiButton);
            RssiContainer.Location = new Point(8, 238);
            RssiContainer.Name = "RssiContainer";
            RssiContainer.Size = new Size(286, 52);
            RssiContainer.TabIndex = 26;
            RssiContainer.TabStop = false;
            // 
            // RssiInput
            // 
            RssiInput.DrawMode = DrawMode.OwnerDrawFixed;
            RssiInput.DropDownStyle = ComboBoxStyle.DropDownList;
            RssiInput.Location = new Point(10, 18);
            RssiInput.Name = "RssiInput";
            RssiInput.Size = new Size(160, 24);
            RssiInput.TabIndex = 27;
            RssiInput.TabStop = false;
            RssiInput.DrawItem += RssiInput_DrawItem;
            // 
            // RssiButton
            // 
            RssiButton.Location = new Point(176, 17);
            RssiButton.Name = "RssiButton";
            RssiButton.Size = new Size(100, 26);
            RssiButton.TabIndex = 28;
            RssiButton.TabStop = false;
            RssiButton.UseVisualStyleBackColor = true;
            // 
            // FrequencyContainer
            // 
            FrequencyContainer.Controls.Add(FrequencyInput);
            FrequencyContainer.Controls.Add(FrequencyButton);
            FrequencyContainer.Location = new Point(8, 296);
            FrequencyContainer.Name = "FrequencyContainer";
            FrequencyContainer.Size = new Size(286, 52);
            FrequencyContainer.TabIndex = 29;
            FrequencyContainer.TabStop = false;
            // 
            // FrequencyInput
            // 
            FrequencyInput.DrawMode = DrawMode.OwnerDrawFixed;
            FrequencyInput.DropDownStyle = ComboBoxStyle.DropDownList;
            FrequencyInput.Location = new Point(10, 18);
            FrequencyInput.Name = "FrequencyInput";
            FrequencyInput.Size = new Size(160, 24);
            FrequencyInput.TabIndex = 30;
            FrequencyInput.TabStop = false;
            FrequencyInput.DrawItem += FrequencyInput_DrawItem;
            // 
            // FrequencyButton
            // 
            FrequencyButton.Location = new Point(176, 17);
            FrequencyButton.Name = "FrequencyButton";
            FrequencyButton.Size = new Size(100, 26);
            FrequencyButton.TabIndex = 31;
            FrequencyButton.TabStop = false;
            FrequencyButton.UseVisualStyleBackColor = true;
            // 
            // IntervalContainer
            // 
            IntervalContainer.Controls.Add(IntervalInput);
            IntervalContainer.Controls.Add(IntervalButton);
            IntervalContainer.Location = new Point(8, 354);
            IntervalContainer.Name = "IntervalContainer";
            IntervalContainer.Size = new Size(286, 52);
            IntervalContainer.TabIndex = 32;
            IntervalContainer.TabStop = false;
            // 
            // IntervalInput
            // 
            IntervalInput.DrawMode = DrawMode.OwnerDrawFixed;
            IntervalInput.DropDownStyle = ComboBoxStyle.DropDownList;
            IntervalInput.Location = new Point(10, 18);
            IntervalInput.Name = "IntervalInput";
            IntervalInput.Size = new Size(160, 24);
            IntervalInput.TabIndex = 33;
            IntervalInput.TabStop = false;
            IntervalInput.DrawItem += IntervalInput_DrawItem;
            // 
            // IntervalButton
            // 
            IntervalButton.Location = new Point(176, 17);
            IntervalButton.Name = "IntervalButton";
            IntervalButton.Size = new Size(100, 26);
            IntervalButton.TabIndex = 34;
            IntervalButton.TabStop = false;
            IntervalButton.UseVisualStyleBackColor = true;
            // 
            // PowerContainer
            // 
            PowerContainer.Controls.Add(PowerInput);
            PowerContainer.Controls.Add(PowerButton);
            PowerContainer.Location = new Point(8, 412);
            PowerContainer.Name = "PowerContainer";
            PowerContainer.Size = new Size(286, 52);
            PowerContainer.TabIndex = 35;
            PowerContainer.TabStop = false;
            // 
            // PowerInput
            // 
            PowerInput.DrawMode = DrawMode.OwnerDrawFixed;
            PowerInput.DropDownStyle = ComboBoxStyle.DropDownList;
            PowerInput.Location = new Point(10, 18);
            PowerInput.Name = "PowerInput";
            PowerInput.Size = new Size(160, 24);
            PowerInput.TabIndex = 36;
            PowerInput.TabStop = false;
            PowerInput.DrawItem += PowerInput_DrawItem;
            // 
            // PowerButton
            // 
            PowerButton.Location = new Point(176, 17);
            PowerButton.Name = "PowerButton";
            PowerButton.Size = new Size(100, 26);
            PowerButton.TabIndex = 37;
            PowerButton.TabStop = false;
            PowerButton.UseVisualStyleBackColor = true;
            // 
            // BaudRateContainer
            // 
            BaudRateContainer.Controls.Add(BaudRateInput);
            BaudRateContainer.Controls.Add(BaudRateButton);
            BaudRateContainer.Location = new Point(8, 470);
            BaudRateContainer.Name = "BaudRateContainer";
            BaudRateContainer.Size = new Size(286, 52);
            BaudRateContainer.TabIndex = 38;
            BaudRateContainer.TabStop = false;
            // 
            // BaudRateInput
            // 
            BaudRateInput.DrawMode = DrawMode.OwnerDrawFixed;
            BaudRateInput.DropDownStyle = ComboBoxStyle.DropDownList;
            BaudRateInput.Location = new Point(10, 18);
            BaudRateInput.Name = "BaudRateInput";
            BaudRateInput.Size = new Size(160, 24);
            BaudRateInput.TabIndex = 39;
            BaudRateInput.TabStop = false;
            BaudRateInput.DrawItem += BaudRateInput_DrawItem;
            // 
            // BaudRateButton
            // 
            BaudRateButton.Location = new Point(176, 17);
            BaudRateButton.Name = "BaudRateButton";
            BaudRateButton.Size = new Size(100, 26);
            BaudRateButton.TabIndex = 40;
            BaudRateButton.TabStop = false;
            BaudRateButton.UseVisualStyleBackColor = true;
            // 
            // RestoreDefaultsContainer
            // 
            RestoreDefaultsContainer.Controls.Add(RestoreDefaultsButton);
            RestoreDefaultsContainer.Location = new Point(8, 528);
            RestoreDefaultsContainer.Name = "RestoreDefaultsContainer";
            RestoreDefaultsContainer.Size = new Size(286, 51);
            RestoreDefaultsContainer.TabIndex = 41;
            RestoreDefaultsContainer.TabStop = false;
            // 
            // RestoreDefaultsButton
            // 
            RestoreDefaultsButton.Location = new Point(10, 17);
            RestoreDefaultsButton.Name = "RestoreDefaultsButton";
            RestoreDefaultsButton.Size = new Size(266, 25);
            RestoreDefaultsButton.TabIndex = 42;
            RestoreDefaultsButton.TabStop = false;
            RestoreDefaultsButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 615);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdvancedForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Move += AdvancedForm_Move;
            TabControl.ResumeLayout(false);
            TabControlPage1.ResumeLayout(false);
            NameContainer.ResumeLayout(false);
            NameContainer.PerformLayout();
            SerialNumberContainer.ResumeLayout(false);
            SerialNumberContainer.PerformLayout();
            BusAddressContainer.ResumeLayout(false);
            RebootContainer.ResumeLayout(false);
            TabControlPage2.ResumeLayout(false);
            VerifyCodeContainer.ResumeLayout(false);
            WorkTypeContainer.ResumeLayout(false);
            BitRateContainer.ResumeLayout(false);
            TriggerTypeContainer.ResumeLayout(false);
            RssiContainer.ResumeLayout(false);
            FrequencyContainer.ResumeLayout(false);
            IntervalContainer.ResumeLayout(false);
            PowerContainer.ResumeLayout(false);
            BaudRateContainer.ResumeLayout(false);
            RestoreDefaultsContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage TabControlPage1;
        private GroupBox NameContainer;
        private TextBox NameInput;
        private Button NameButton;
        private GroupBox SerialNumberContainer;
        private TextBox SerialNumberInput;
        private Button SerialNumberButton;
        private GroupBox BusAddressContainer;
        private ComboBox BusAddressInput;
        private Button BusAddressButton;
        private GroupBox RebootContainer;
        private Button RebootButton;
        private TabPage TabControlPage2;
        private GroupBox VerifyCodeContainer;
        private ComboBox VerifyCodeInput;
        private Button VerifyCodeButton;
        private GroupBox WorkTypeContainer;
        private ComboBox WorkTypeInput;
        private Button WorkTypeButton;
        private GroupBox BitRateContainer;
        private ComboBox BitRateInput;
        private Button BitRateButton;
        private GroupBox TriggerTypeContainer;
        private ComboBox TriggerTypeInput;
        private Button TriggerTypeButton;
        private GroupBox RssiContainer;
        private ComboBox RssiInput;
        private Button RssiButton;
        private GroupBox FrequencyContainer;
        private ComboBox FrequencyInput;
        private Button FrequencyButton;
        private GroupBox IntervalContainer;
        private ComboBox IntervalInput;
        private Button IntervalButton;
        private GroupBox PowerContainer;
        private ComboBox PowerInput;
        private Button PowerButton;
        private GroupBox BaudRateContainer;
        private ComboBox BaudRateInput;
        private Button BaudRateButton;
        private GroupBox RestoreDefaultsContainer;
        private Button RestoreDefaultsButton;
    }
}