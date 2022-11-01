namespace AddressHandler
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
            this.Search_INPT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Results_cmb = new System.Windows.Forms.ComboBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Add_BTN = new System.Windows.Forms.Button();
            this.AdrList_cmb = new System.Windows.Forms.ComboBox();
            this.Del_btn = new System.Windows.Forms.Button();
            this.secondLoc_cmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.distance_outp = new System.Windows.Forms.Label();
            this.CalcDis_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search_INPT
            // 
            this.Search_INPT.Location = new System.Drawing.Point(56, 12);
            this.Search_INPT.Name = "Search_INPT";
            this.Search_INPT.Size = new System.Drawing.Size(251, 23);
            this.Search_INPT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Results_cmb
            // 
            this.Results_cmb.FormattingEnabled = true;
            this.Results_cmb.Location = new System.Drawing.Point(56, 41);
            this.Results_cmb.Name = "Results_cmb";
            this.Results_cmb.Size = new System.Drawing.Size(251, 23);
            this.Results_cmb.TabIndex = 2;
            this.Results_cmb.TextChanged += new System.EventHandler(this.Results_cmb_TextChanged);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(313, 12);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 3;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Add_BTN
            // 
            this.Add_BTN.Location = new System.Drawing.Point(313, 41);
            this.Add_BTN.Name = "Add_BTN";
            this.Add_BTN.Size = new System.Drawing.Size(75, 23);
            this.Add_BTN.TabIndex = 4;
            this.Add_BTN.Text = "Add";
            this.Add_BTN.UseVisualStyleBackColor = true;
            this.Add_BTN.Click += new System.EventHandler(this.Add_BTN_Click);
            // 
            // AdrList_cmb
            // 
            this.AdrList_cmb.FormattingEnabled = true;
            this.AdrList_cmb.Location = new System.Drawing.Point(455, 15);
            this.AdrList_cmb.Name = "AdrList_cmb";
            this.AdrList_cmb.Size = new System.Drawing.Size(292, 23);
            this.AdrList_cmb.TabIndex = 5;
            // 
            // Del_btn
            // 
            this.Del_btn.Location = new System.Drawing.Point(455, 44);
            this.Del_btn.Name = "Del_btn";
            this.Del_btn.Size = new System.Drawing.Size(75, 23);
            this.Del_btn.TabIndex = 6;
            this.Del_btn.Text = "Delete";
            this.Del_btn.UseVisualStyleBackColor = true;
            this.Del_btn.Click += new System.EventHandler(this.Del_btn_Click);
            // 
            // secondLoc_cmb
            // 
            this.secondLoc_cmb.FormattingEnabled = true;
            this.secondLoc_cmb.Location = new System.Drawing.Point(455, 92);
            this.secondLoc_cmb.Name = "secondLoc_cmb";
            this.secondLoc_cmb.Size = new System.Drawing.Size(292, 23);
            this.secondLoc_cmb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Location";
            // 
            // distance_outp
            // 
            this.distance_outp.AutoSize = true;
            this.distance_outp.Location = new System.Drawing.Point(536, 125);
            this.distance_outp.Name = "distance_outp";
            this.distance_outp.Size = new System.Drawing.Size(86, 15);
            this.distance_outp.TabIndex = 9;
            this.distance_outp.Text = "Not Calculated";
            // 
            // CalcDis_btn
            // 
            this.CalcDis_btn.Location = new System.Drawing.Point(455, 121);
            this.CalcDis_btn.Name = "CalcDis_btn";
            this.CalcDis_btn.Size = new System.Drawing.Size(75, 23);
            this.CalcDis_btn.TabIndex = 10;
            this.CalcDis_btn.Text = "Distance";
            this.CalcDis_btn.UseVisualStyleBackColor = true;
            this.CalcDis_btn.Click += new System.EventHandler(this.CalcDis_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcDis_btn);
            this.Controls.Add(this.distance_outp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondLoc_cmb);
            this.Controls.Add(this.Del_btn);
            this.Controls.Add(this.AdrList_cmb);
            this.Controls.Add(this.Add_BTN);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Results_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search_INPT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Search_INPT;
        private Label label1;
        private ComboBox Results_cmb;
        private Button Search_btn;
        private Button Add_BTN;
        private ComboBox AdrList_cmb;
        private Button Del_btn;
        private ComboBox secondLoc_cmb;
        private Label label2;
        private Label distance_outp;
        private Button CalcDis_btn;
    }
}