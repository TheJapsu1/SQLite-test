
namespace sqlite_testi
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.deleteSearchButton = new System.Windows.Forms.Button();
            this.contentsLabel = new System.Windows.Forms.Label();
            this.debugLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.contentsView = new System.Windows.Forms.ListView();
            this.searchField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(106, 143);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Lisää kantaan";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Etunimi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sukunimi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Osoite";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(106, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // deleteSearchButton
            // 
            this.deleteSearchButton.Location = new System.Drawing.Point(384, 52);
            this.deleteSearchButton.Name = "deleteSearchButton";
            this.deleteSearchButton.Size = new System.Drawing.Size(145, 20);
            this.deleteSearchButton.TabIndex = 7;
            this.deleteSearchButton.Text = "poista valinta kannasta";
            this.deleteSearchButton.UseVisualStyleBackColor = true;
            this.deleteSearchButton.Click += new System.EventHandler(this.deleteResultButton_Click);
            // 
            // contentsLabel
            // 
            this.contentsLabel.AutoSize = true;
            this.contentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentsLabel.Location = new System.Drawing.Point(317, 19);
            this.contentsLabel.Name = "contentsLabel";
            this.contentsLabel.Size = new System.Drawing.Size(115, 17);
            this.contentsLabel.TabIndex = 8;
            this.contentsLabel.Text = "Kannan sisältö";
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(237, 332);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(39, 13);
            this.debugLabel.TabIndex = 9;
            this.debugLabel.Text = "Debug";
            this.debugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(429, 335);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Tyhjennä kanta";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // contentsView
            // 
            this.contentsView.AutoArrange = false;
            this.contentsView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.contentsView.FullRowSelect = true;
            this.contentsView.GridLines = true;
            this.contentsView.HideSelection = false;
            this.contentsView.Location = new System.Drawing.Point(231, 78);
            this.contentsView.Name = "contentsView";
            this.contentsView.Size = new System.Drawing.Size(298, 251);
            this.contentsView.TabIndex = 5;
            this.contentsView.UseCompatibleStateImageBehavior = false;
            this.contentsView.View = System.Windows.Forms.View.Details;
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(270, 52);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(108, 20);
            this.searchField.TabIndex = 11;
            this.searchField.TextChanged += new System.EventHandler(this.searchField_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hae";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lisää henkilö tietokantaan";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.contentsView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.debugLabel);
            this.Controls.Add(this.contentsLabel);
            this.Controls.Add(this.deleteSearchButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button deleteSearchButton;
        private System.Windows.Forms.Label contentsLabel;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView contentsView;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

