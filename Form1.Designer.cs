namespace DnD_Potion_Crafting_Tool
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ItemsTable = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addatives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Water = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Air = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vitality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Decay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arcane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Divine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Infernal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionButton = new System.Windows.Forms.Button();
            this.BasesCombo = new System.Windows.Forms.ComboBox();
            this.Addative1Combo = new System.Windows.Forms.ComboBox();
            this.Addative2Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Metal_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Water_Text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Fire_Text = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Vitality_Text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Nature_Text = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Divine_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Air_Text = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Decay_Text = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ModeButton = new System.Windows.Forms.Button();
            this.EffectBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Arcane_Text = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Infernal_Text = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AttributelistView = new System.Windows.Forms.ListView();
            this.ListAttribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.HerbalismCheck = new System.Windows.Forms.CheckBox();
            this.PoisonerCheck = new System.Windows.Forms.CheckBox();
            this.AlchemyCheck = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RankCombo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ValueText = new System.Windows.Forms.TextBox();
            this.EssenceWeight = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.newAttributeText = new System.Windows.Forms.TextBox();
            this.addAttribute = new System.Windows.Forms.Button();
            this.removeAttribute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsTable
            // 
            this.ItemsTable.AllowUserToAddRows = false;
            this.ItemsTable.AllowUserToDeleteRows = false;
            this.ItemsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ItemsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Kits,
            this.Rank,
            this.Value,
            this.Attributes,
            this.Base,
            this.Addatives,
            this.Water,
            this.Fire,
            this.Air,
            this.Nature,
            this.Metal,
            this.Vitality,
            this.Decay,
            this.Arcane,
            this.Divine,
            this.Infernal});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.ItemsTable.Location = new System.Drawing.Point(12, 273);
            this.ItemsTable.MultiSelect = false;
            this.ItemsTable.Name = "ItemsTable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ItemsTable.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ItemsTable.RowTemplate.ReadOnly = true;
            this.ItemsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsTable.Size = new System.Drawing.Size(1216, 310);
            this.ItemsTable.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Kits
            // 
            this.Kits.HeaderText = "Kits";
            this.Kits.Name = "Kits";
            this.Kits.ReadOnly = true;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Attributes
            // 
            this.Attributes.HeaderText = "Attributes";
            this.Attributes.Name = "Attributes";
            this.Attributes.ReadOnly = true;
            // 
            // Base
            // 
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            this.Base.ReadOnly = true;
            // 
            // Addatives
            // 
            this.Addatives.HeaderText = "Addatives";
            this.Addatives.Name = "Addatives";
            this.Addatives.ReadOnly = true;
            // 
            // Water
            // 
            this.Water.HeaderText = "Water";
            this.Water.Name = "Water";
            this.Water.ReadOnly = true;
            // 
            // Fire
            // 
            this.Fire.HeaderText = "Fire";
            this.Fire.Name = "Fire";
            this.Fire.ReadOnly = true;
            // 
            // Air
            // 
            this.Air.HeaderText = "Air";
            this.Air.Name = "Air";
            this.Air.ReadOnly = true;
            // 
            // Nature
            // 
            this.Nature.HeaderText = "Nature";
            this.Nature.Name = "Nature";
            this.Nature.ReadOnly = true;
            // 
            // Metal
            // 
            this.Metal.HeaderText = "Metal";
            this.Metal.Name = "Metal";
            this.Metal.ReadOnly = true;
            // 
            // Vitality
            // 
            this.Vitality.HeaderText = "Vitality";
            this.Vitality.Name = "Vitality";
            this.Vitality.ReadOnly = true;
            // 
            // Decay
            // 
            this.Decay.HeaderText = "Decay";
            this.Decay.Name = "Decay";
            this.Decay.ReadOnly = true;
            // 
            // Arcane
            // 
            this.Arcane.HeaderText = "Arcane";
            this.Arcane.Name = "Arcane";
            this.Arcane.ReadOnly = true;
            // 
            // Divine
            // 
            this.Divine.HeaderText = "Divine";
            this.Divine.Name = "Divine";
            this.Divine.ReadOnly = true;
            // 
            // Infernal
            // 
            this.Infernal.HeaderText = "Infernal";
            this.Infernal.Name = "Infernal";
            this.Infernal.ReadOnly = true;
            // 
            // ActionButton
            // 
            this.ActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionButton.Location = new System.Drawing.Point(1153, 12);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 1;
            this.ActionButton.Text = "Craft!";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // BasesCombo
            // 
            this.BasesCombo.FormattingEnabled = true;
            this.BasesCombo.Location = new System.Drawing.Point(204, 24);
            this.BasesCombo.Name = "BasesCombo";
            this.BasesCombo.Size = new System.Drawing.Size(121, 21);
            this.BasesCombo.TabIndex = 4;
            // 
            // Addative1Combo
            // 
            this.Addative1Combo.FormattingEnabled = true;
            this.Addative1Combo.Location = new System.Drawing.Point(331, 24);
            this.Addative1Combo.Name = "Addative1Combo";
            this.Addative1Combo.Size = new System.Drawing.Size(121, 21);
            this.Addative1Combo.TabIndex = 5;
            // 
            // Addative2Combo
            // 
            this.Addative2Combo.FormattingEnabled = true;
            this.Addative2Combo.Location = new System.Drawing.Point(458, 24);
            this.Addative2Combo.Name = "Addative2Combo";
            this.Addative2Combo.Size = new System.Drawing.Size(121, 21);
            this.Addative2Combo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Addative 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Addative 2";
            // 
            // Metal_Text
            // 
            this.Metal_Text.Location = new System.Drawing.Point(60, 42);
            this.Metal_Text.Name = "Metal_Text";
            this.Metal_Text.Size = new System.Drawing.Size(100, 20);
            this.Metal_Text.TabIndex = 10;
            this.Metal_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Metal Essence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Water Essence";
            // 
            // Water_Text
            // 
            this.Water_Text.Location = new System.Drawing.Point(5, 42);
            this.Water_Text.Name = "Water_Text";
            this.Water_Text.Size = new System.Drawing.Size(100, 20);
            this.Water_Text.TabIndex = 12;
            this.Water_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fire Essence";
            // 
            // Fire_Text
            // 
            this.Fire_Text.Location = new System.Drawing.Point(6, 93);
            this.Fire_Text.Name = "Fire_Text";
            this.Fire_Text.Size = new System.Drawing.Size(100, 20);
            this.Fire_Text.TabIndex = 16;
            this.Fire_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vitality Essence";
            // 
            // Vitality_Text
            // 
            this.Vitality_Text.Location = new System.Drawing.Point(6, 93);
            this.Vitality_Text.Name = "Vitality_Text";
            this.Vitality_Text.Size = new System.Drawing.Size(100, 20);
            this.Vitality_Text.TabIndex = 14;
            this.Vitality_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nature Essence";
            // 
            // Nature_Text
            // 
            this.Nature_Text.Location = new System.Drawing.Point(115, 93);
            this.Nature_Text.Name = "Nature_Text";
            this.Nature_Text.Size = new System.Drawing.Size(100, 20);
            this.Nature_Text.TabIndex = 24;
            this.Nature_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Divine Essence";
            // 
            // Divine_Text
            // 
            this.Divine_Text.Location = new System.Drawing.Point(6, 42);
            this.Divine_Text.Name = "Divine_Text";
            this.Divine_Text.Size = new System.Drawing.Size(102, 20);
            this.Divine_Text.TabIndex = 22;
            this.Divine_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Air Essence";
            // 
            // Air_Text
            // 
            this.Air_Text.Location = new System.Drawing.Point(114, 42);
            this.Air_Text.Name = "Air_Text";
            this.Air_Text.Size = new System.Drawing.Size(100, 20);
            this.Air_Text.TabIndex = 20;
            this.Air_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(112, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Decay Essence";
            // 
            // Decay_Text
            // 
            this.Decay_Text.Location = new System.Drawing.Point(112, 93);
            this.Decay_Text.Name = "Decay_Text";
            this.Decay_Text.Size = new System.Drawing.Size(100, 20);
            this.Decay_Text.TabIndex = 18;
            this.Decay_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(12, 24);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(186, 20);
            this.NameText.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Name";
            // 
            // ModeButton
            // 
            this.ModeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModeButton.Location = new System.Drawing.Point(1025, 12);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(122, 23);
            this.ModeButton.TabIndex = 28;
            this.ModeButton.Text = "Switch to Edit Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // EffectBox
            // 
            this.EffectBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EffectBox.Location = new System.Drawing.Point(12, 200);
            this.EffectBox.Name = "EffectBox";
            this.EffectBox.Size = new System.Drawing.Size(1216, 67);
            this.EffectBox.TabIndex = 29;
            this.EffectBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Effect";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Arcane Essence";
            // 
            // Arcane_Text
            // 
            this.Arcane_Text.Location = new System.Drawing.Point(6, 41);
            this.Arcane_Text.Name = "Arcane_Text";
            this.Arcane_Text.Size = new System.Drawing.Size(100, 20);
            this.Arcane_Text.TabIndex = 31;
            this.Arcane_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Infernal Essence";
            // 
            // Infernal_Text
            // 
            this.Infernal_Text.Location = new System.Drawing.Point(6, 93);
            this.Infernal_Text.Name = "Infernal_Text";
            this.Infernal_Text.Size = new System.Drawing.Size(102, 20);
            this.Infernal_Text.TabIndex = 33;
            this.Infernal_Text.TextChanged += new System.EventHandler(this.Essence_Text_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Nature_Text);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Air_Text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Fire_Text);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Water_Text);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 130);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Common";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Decay_Text);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Vitality_Text);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Metal_Text);
            this.groupBox2.Location = new System.Drawing.Point(241, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 130);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Uncommon";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Arcane_Text);
            this.groupBox3.Location = new System.Drawing.Point(465, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 129);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rare";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.Infernal_Text);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.Divine_Text);
            this.groupBox4.Location = new System.Drawing.Point(585, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 130);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Very Rare";
            // 
            // AttributelistView
            // 
            this.AttributelistView.AutoArrange = false;
            this.AttributelistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ListAttribute});
            this.AttributelistView.HideSelection = false;
            this.AttributelistView.Location = new System.Drawing.Point(705, 68);
            this.AttributelistView.MultiSelect = false;
            this.AttributelistView.Name = "AttributelistView";
            this.AttributelistView.ShowGroups = false;
            this.AttributelistView.Size = new System.Drawing.Size(135, 73);
            this.AttributelistView.TabIndex = 39;
            this.AttributelistView.UseCompatibleStateImageBehavior = false;
            this.AttributelistView.View = System.Windows.Forms.View.Details;
            // 
            // ListAttribute
            // 
            this.ListAttribute.Text = "Attribute";
            this.ListAttribute.Width = 130;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(702, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Attributes";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.HerbalismCheck);
            this.groupBox5.Controls.Add(this.PoisonerCheck);
            this.groupBox5.Controls.Add(this.AlchemyCheck);
            this.groupBox5.Location = new System.Drawing.Point(846, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(104, 129);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tool Proficiency";
            // 
            // HerbalismCheck
            // 
            this.HerbalismCheck.AutoSize = true;
            this.HerbalismCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HerbalismCheck.Location = new System.Drawing.Point(17, 92);
            this.HerbalismCheck.Name = "HerbalismCheck";
            this.HerbalismCheck.Size = new System.Drawing.Size(72, 31);
            this.HerbalismCheck.TabIndex = 2;
            this.HerbalismCheck.Text = "Herbalism Kit";
            this.HerbalismCheck.UseVisualStyleBackColor = true;
            // 
            // PoisonerCheck
            // 
            this.PoisonerCheck.AutoSize = true;
            this.PoisonerCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.PoisonerCheck.Location = new System.Drawing.Point(17, 54);
            this.PoisonerCheck.Name = "PoisonerCheck";
            this.PoisonerCheck.Size = new System.Drawing.Size(74, 31);
            this.PoisonerCheck.TabIndex = 1;
            this.PoisonerCheck.Text = "Poisoner\'s Kit";
            this.PoisonerCheck.UseVisualStyleBackColor = true;
            // 
            // AlchemyCheck
            // 
            this.AlchemyCheck.AutoSize = true;
            this.AlchemyCheck.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AlchemyCheck.Location = new System.Drawing.Point(6, 19);
            this.AlchemyCheck.Name = "AlchemyCheck";
            this.AlchemyCheck.Size = new System.Drawing.Size(92, 31);
            this.AlchemyCheck.TabIndex = 0;
            this.AlchemyCheck.Text = "Alchemist\'s Tools";
            this.AlchemyCheck.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(582, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Rank";
            // 
            // RankCombo
            // 
            this.RankCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RankCombo.FormattingEnabled = true;
            this.RankCombo.Location = new System.Drawing.Point(585, 24);
            this.RankCombo.Name = "RankCombo";
            this.RankCombo.Size = new System.Drawing.Size(108, 21);
            this.RankCombo.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(696, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Value";
            // 
            // ValueText
            // 
            this.ValueText.Location = new System.Drawing.Point(699, 24);
            this.ValueText.Name = "ValueText";
            this.ValueText.Size = new System.Drawing.Size(109, 20);
            this.ValueText.TabIndex = 44;
            // 
            // EssenceWeight
            // 
            this.EssenceWeight.AutoSize = true;
            this.EssenceWeight.Location = new System.Drawing.Point(814, 27);
            this.EssenceWeight.Name = "EssenceWeight";
            this.EssenceWeight.Size = new System.Drawing.Size(34, 13);
            this.EssenceWeight.TabIndex = 46;
            this.EssenceWeight.Text = "Value";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(814, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Essence Weight";
            // 
            // newAttributeText
            // 
            this.newAttributeText.Location = new System.Drawing.Point(705, 164);
            this.newAttributeText.Name = "newAttributeText";
            this.newAttributeText.Size = new System.Drawing.Size(135, 20);
            this.newAttributeText.TabIndex = 48;
            // 
            // addAttribute
            // 
            this.addAttribute.Location = new System.Drawing.Point(705, 141);
            this.addAttribute.Name = "addAttribute";
            this.addAttribute.Size = new System.Drawing.Size(68, 23);
            this.addAttribute.TabIndex = 49;
            this.addAttribute.Text = "Add";
            this.addAttribute.UseVisualStyleBackColor = true;
            this.addAttribute.Click += new System.EventHandler(this.addAttribute_Click);
            // 
            // removeAttribute
            // 
            this.removeAttribute.Location = new System.Drawing.Point(773, 141);
            this.removeAttribute.Name = "removeAttribute";
            this.removeAttribute.Size = new System.Drawing.Size(67, 23);
            this.removeAttribute.TabIndex = 50;
            this.removeAttribute.Text = "Remove";
            this.removeAttribute.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 595);
            this.Controls.Add(this.removeAttribute);
            this.Controls.Add(this.addAttribute);
            this.Controls.Add(this.newAttributeText);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.EssenceWeight);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ValueText);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.RankCombo);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.AttributelistView);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EffectBox);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Addative2Combo);
            this.Controls.Add(this.Addative1Combo);
            this.Controls.Add(this.BasesCombo);
            this.Controls.Add(this.ActionButton);
            this.Controls.Add(this.ItemsTable);
            this.Name = "Form1";
            this.Text = "Potion Crafting Tool";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemsTable;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.ComboBox BasesCombo;
        private System.Windows.Forms.ComboBox Addative1Combo;
        private System.Windows.Forms.ComboBox Addative2Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Metal_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Water_Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Fire_Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Vitality_Text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Nature_Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Divine_Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Air_Text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Decay_Text;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.RichTextBox EffectBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Arcane_Text;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Infernal_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView AttributelistView;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox HerbalismCheck;
        private System.Windows.Forms.CheckBox PoisonerCheck;
        private System.Windows.Forms.CheckBox AlchemyCheck;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox RankCombo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ValueText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attributes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addatives;
        private System.Windows.Forms.DataGridViewTextBoxColumn Water;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Air;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vitality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Decay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arcane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Divine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Infernal;
        private System.Windows.Forms.Label EssenceWeight;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox newAttributeText;
        private System.Windows.Forms.Button addAttribute;
        private System.Windows.Forms.Button removeAttribute;
        private System.Windows.Forms.ColumnHeader ListAttribute;
    }
}

