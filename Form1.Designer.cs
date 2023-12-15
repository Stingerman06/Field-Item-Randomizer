namespace Field_Item_Randomizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(412, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Select a file to load from...";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 41);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(412, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Select a location to save your randomized file...";
            // 
            // button1
            // 
            button1.Location = new Point(430, 12);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 2;
            button1.Text = "Load File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(430, 40);
            button2.Name = "button2";
            button2.Size = new Size(125, 23);
            button2.TabIndex = 3;
            button2.Text = "Save File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Impact", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(299, 76);
            button3.Name = "button3";
            button3.Size = new Size(256, 52);
            button3.TabIndex = 4;
            button3.Text = "RANDOMIZE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "bin";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.InitialDirectory = "AppDomain.CurrentDomain.BaseDirectory";
            openFileDialog1.Title = "Open your takara.bin file...";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 98);
            label1.Name = "label1";
            label1.Size = new Size(242, 15);
            label1.TabIndex = 5;
            label1.Text = "Seed: 0 = Random || 1 - 2147483647 = Forced";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(183, 23);
            textBox3.TabIndex = 6;
            textBox3.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 7;
            label2.Text = " ";
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 151);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(583, 190);
            MinimumSize = new Size(583, 190);
            Name = "Form1";
            Text = "FFX Field Item Randomizer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private SaveFileDialog saveFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
