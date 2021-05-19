namespace recruitPGwork
{
    partial class LunchBoxMemoForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemListTextBox = new System.Windows.Forms.TextBox();
            this.GraphTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(14, 95);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "計算";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 12);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "品名";
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ハンバーガー",
            "コロッケパン",
            "メロンパン"});
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Items.AddRange(new object[] {
            "ハンバーガー",
            "コロッケパン",
            "メロンパン"});
            this.ItemNameComboBox.Location = new System.Drawing.Point(12, 33);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(121, 20);
            this.ItemNameComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "個数";
            // 
            // ItemListTextBox
            // 
            this.ItemListTextBox.Location = new System.Drawing.Point(216, 33);
            this.ItemListTextBox.Multiline = true;
            this.ItemListTextBox.Name = "ItemListTextBox";
            this.ItemListTextBox.Size = new System.Drawing.Size(150, 150);
            this.ItemListTextBox.TabIndex = 5;
            // 
            // GraphTextBox
            // 
            this.GraphTextBox.Location = new System.Drawing.Point(372, 33);
            this.GraphTextBox.Multiline = true;
            this.GraphTextBox.Name = "GraphTextBox";
            this.GraphTextBox.Size = new System.Drawing.Size(150, 150);
            this.GraphTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "買物";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "グラフ";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(14, 144);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(14, 190);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "終了";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(316, 198);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 19);
            this.TotalTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "合計";
            // 
            // CountNumericUpDown
            // 
            this.CountNumericUpDown.Location = new System.Drawing.Point(140, 33);
            this.CountNumericUpDown.Name = "CountNumericUpDown";
            this.CountNumericUpDown.Size = new System.Drawing.Size(70, 19);
            this.CountNumericUpDown.TabIndex = 13;
            // 
            // LunchBoxMemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 231);
            this.Controls.Add(this.CountNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GraphTextBox);
            this.Controls.Add(this.ItemListTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.CalculateButton);
            this.Name = "LunchBoxMemoForm";
            this.Text = "お弁当メモ";
            ((System.ComponentModel.ISupportInitialize)(this.CountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemListTextBox;
        private System.Windows.Forms.TextBox GraphTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CountNumericUpDown;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog1;
    }
}

