namespace rssApplikation
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
            this.listViewPodcast = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listViewEpisodes = new System.Windows.Forms.ListView();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.rTBoxEpisodeDetail = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listViewPodcast
            // 
            this.listViewPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.Kategorier,
            this.Avsnitt,
            this.Frekvens});
            this.listViewPodcast.HideSelection = false;
            this.listViewPodcast.Location = new System.Drawing.Point(16, 14);
            this.listViewPodcast.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listViewPodcast.Name = "listViewPodcast";
            this.listViewPodcast.Size = new System.Drawing.Size(485, 154);
            this.listViewPodcast.TabIndex = 0;
            this.listViewPodcast.UseCompatibleStateImageBehavior = false;
            this.listViewPodcast.View = System.Windows.Forms.View.Details;
            this.listViewPodcast.ItemActivate += new System.EventHandler(this.listViewPodcast_ItemActivate);
            this.listViewPodcast.SelectedIndexChanged += new System.EventHandler(this.listViewPodcast_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "Namn";
            // 
            // Kategorier
            // 
            this.Kategorier.Text = "Kategorier";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            // 
            // comboBoxUpdateFrequency
            // 
            this.comboBoxUpdateFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUpdateFrequency.FormattingEnabled = true;
            this.comboBoxUpdateFrequency.Items.AddRange(new object[] {
            "60 sekunder",
            "120 sekunder",
            "180 sekunder",
            "240 sekunder",
            "300 sekunder",
            "360 sekunder",
            "420 sekunder",
            "480 sekunder",
            "520 sekunder",
            "580 sekunder"});
            this.comboBoxUpdateFrequency.Location = new System.Drawing.Point(211, 191);
            this.comboBoxUpdateFrequency.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxUpdateFrequency.Name = "comboBoxUpdateFrequency";
            this.comboBoxUpdateFrequency.Size = new System.Drawing.Size(175, 23);
            this.comboBoxUpdateFrequency.TabIndex = 2;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(395, 191);
            this.comboBoxCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(107, 23);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(16, 192);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(185, 23);
            this.textBoxUrl.TabIndex = 4;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(16, 223);
            this.btnNew.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(187, 26);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Ny...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNewPodcast_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(211, 223);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(395, 223);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Ta bort...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listViewEpisodes
            // 
            this.listViewEpisodes.HideSelection = false;
            this.listViewEpisodes.Location = new System.Drawing.Point(16, 269);
            this.listViewEpisodes.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.listViewEpisodes.Name = "listViewEpisodes";
            this.listViewEpisodes.Size = new System.Drawing.Size(485, 124);
            this.listViewEpisodes.TabIndex = 8;
            this.listViewEpisodes.UseCompatibleStateImageBehavior = false;
            this.listViewEpisodes.View = System.Windows.Forms.View.Tile;
            this.listViewEpisodes.ItemActivate += new System.EventHandler(this.listViewEpisodes_ItemActivate);
            this.listViewEpisodes.SelectedIndexChanged += new System.EventHandler(this.listViewEpisodes_SelectedIndexChanged);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(632, 191);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(417, 23);
            this.textBoxCategory.TabIndex = 10;
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.Location = new System.Drawing.Point(632, 223);
            this.btnNewCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(187, 26);
            this.btnNewCategory.TabIndex = 11;
            this.btnNewCategory.Text = "Ny...";
            this.btnNewCategory.UseVisualStyleBackColor = true;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(827, 223);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(107, 26);
            this.btnSaveCategory.TabIndex = 12;
            this.btnSaveCategory.Text = "Spara";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(943, 223);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(107, 26);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Ta bort...";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // rTBoxEpisodeDetail
            // 
            this.rTBoxEpisodeDetail.Location = new System.Drawing.Point(632, 283);
            this.rTBoxEpisodeDetail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rTBoxEpisodeDetail.Name = "rTBoxEpisodeDetail";
            this.rTBoxEpisodeDetail.Size = new System.Drawing.Size(417, 110);
            this.rTBoxEpisodeDetail.TabIndex = 14;
            this.rTBoxEpisodeDetail.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Uppdateringsfrekvens:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kategori:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 251);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Podcast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(629, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Kategorier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Beskrivning";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.AllowDrop = true;
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 15;
            this.listBoxCategory.Location = new System.Drawing.Point(632, 29);
            this.listBoxCategory.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(418, 139);
            this.listBoxCategory.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1067, 465);
            this.Controls.Add(this.listBoxCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTBoxEpisodeDetail);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.btnNewCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.listViewEpisodes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxUpdateFrequency);
            this.Controls.Add(this.listViewPodcast);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podcast";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPodcast;
        private System.Windows.Forms.ComboBox comboBoxUpdateFrequency;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listViewEpisodes;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.RichTextBox rTBoxEpisodeDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader Kategorier;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ListBox listBoxCategory;
    }
}

