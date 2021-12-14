﻿namespace FFBatch
{
    partial class AeroWizard6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AeroWizard6));
            this.fd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chk_save_pres = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_start_multi = new System.Windows.Forms.Button();
            this.btn_abort = new System.Windows.Forms.Button();
            this.lbl_warn = new System.Windows.Forms.Label();
            this.pic_warn_two = new System.Windows.Forms.PictureBox();
            this.check_name = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.wz_final = new AeroWizard.WizardPage();
            this.wz1 = new AeroWizard.WizardPage();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.txt_naming = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_streamcopy = new System.Windows.Forms.CheckBox();
            this.txt_path_main = new System.Windows.Forms.TextBox();
            this.combo_ext = new System.Windows.Forms.ComboBox();
            this.chk_out_name = new System.Windows.Forms.CheckBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.radio_absolute = new System.Windows.Forms.RadioButton();
            this.radio_relative = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_size = new System.Windows.Forms.ComboBox();
            this.radio_size = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_Seconds = new System.Windows.Forms.ComboBox();
            this.radio_time = new System.Windows.Forms.RadioButton();
            this.wiz_split = new AeroWizard.WizardControl();
            this.wz_end = new AeroWizard.WizardPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_preset_name = new System.Windows.Forms.TextBox();
            this.chk_save_preset = new System.Windows.Forms.CheckBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_warn_two)).BeginInit();
            this.wz_final.SuspendLayout();
            this.wz1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiz_split)).BeginInit();
            this.wz_end.SuspendLayout();
            this.SuspendLayout();
            // 
            // fd1
            // 
            resources.ApplyResources(this.fd1, "fd1");
            // 
            // chk_save_pres
            // 
            resources.ApplyResources(this.chk_save_pres, "chk_save_pres");
            this.chk_save_pres.Name = "chk_save_pres";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btn_start_multi
            // 
            resources.ApplyResources(this.btn_start_multi, "btn_start_multi");
            this.btn_start_multi.FlatAppearance.BorderSize = 0;
            this.btn_start_multi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_start_multi.Name = "btn_start_multi";
            this.btn_start_multi.UseVisualStyleBackColor = true;
            // 
            // btn_abort
            // 
            resources.ApplyResources(this.btn_abort, "btn_abort");
            this.btn_abort.FlatAppearance.BorderSize = 0;
            this.btn_abort.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_abort.Name = "btn_abort";
            this.btn_abort.UseVisualStyleBackColor = true;
            // 
            // lbl_warn
            // 
            resources.ApplyResources(this.lbl_warn, "lbl_warn");
            this.lbl_warn.Name = "lbl_warn";
            // 
            // pic_warn_two
            // 
            resources.ApplyResources(this.pic_warn_two, "pic_warn_two");
            this.pic_warn_two.Name = "pic_warn_two";
            this.pic_warn_two.TabStop = false;
            // 
            // check_name
            // 
            resources.ApplyResources(this.check_name, "check_name");
            this.check_name.Checked = true;
            this.check_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_name.Name = "check_name";
            this.check_name.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // wz_final
            // 
            resources.ApplyResources(this.wz_final, "wz_final");
            this.wz_final.Controls.Add(this.textBox1);
            this.wz_final.Controls.Add(this.check_name);
            this.wz_final.Controls.Add(this.pic_warn_two);
            this.wz_final.Controls.Add(this.lbl_warn);
            this.wz_final.Controls.Add(this.btn_abort);
            this.wz_final.Controls.Add(this.btn_start_multi);
            this.wz_final.Controls.Add(this.label6);
            this.wz_final.Controls.Add(this.label5);
            this.wz_final.Controls.Add(this.label4);
            this.wz_final.Controls.Add(this.chk_save_pres);
            this.wz_final.IsFinishPage = true;
            this.wz_final.Name = "wz_final";
            // 
            // wz1
            // 
            resources.ApplyResources(this.wz1, "wz1");
            this.wz1.Controls.Add(this.label10);
            this.wz1.Controls.Add(this.groupBox2);
            this.wz1.Controls.Add(this.groupBox1);
            this.wz1.Name = "wz1";
            this.wz1.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wz1_Commit);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txt_path);
            this.groupBox2.Controls.Add(this.txt_naming);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.chk_streamcopy);
            this.groupBox2.Controls.Add(this.txt_path_main);
            this.groupBox2.Controls.Add(this.combo_ext);
            this.groupBox2.Controls.Add(this.chk_out_name);
            this.groupBox2.Controls.Add(this.btn_browse);
            this.groupBox2.Controls.Add(this.radio_absolute);
            this.groupBox2.Controls.Add(this.radio_relative);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txt_path
            // 
            resources.ApplyResources(this.txt_path, "txt_path");
            this.txt_path.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            // 
            // txt_naming
            // 
            this.txt_naming.AcceptsReturn = true;
            resources.ApplyResources(this.txt_naming, "txt_naming");
            this.txt_naming.Name = "txt_naming";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // chk_streamcopy
            // 
            resources.ApplyResources(this.chk_streamcopy, "chk_streamcopy");
            this.chk_streamcopy.Checked = true;
            this.chk_streamcopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_streamcopy.Name = "chk_streamcopy";
            this.chk_streamcopy.UseVisualStyleBackColor = true;
            // 
            // txt_path_main
            // 
            resources.ApplyResources(this.txt_path_main, "txt_path_main");
            this.txt_path_main.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_path_main.Name = "txt_path_main";
            this.txt_path_main.TextChanged += new System.EventHandler(this.txt_path_main_TextChanged);
            // 
            // combo_ext
            // 
            resources.ApplyResources(this.combo_ext, "combo_ext");
            this.combo_ext.FormattingEnabled = true;
            this.combo_ext.Items.AddRange(new object[] {
            resources.GetString("combo_ext.Items"),
            resources.GetString("combo_ext.Items1"),
            resources.GetString("combo_ext.Items2"),
            resources.GetString("combo_ext.Items3"),
            resources.GetString("combo_ext.Items4"),
            resources.GetString("combo_ext.Items5")});
            this.combo_ext.Name = "combo_ext";
            // 
            // chk_out_name
            // 
            resources.ApplyResources(this.chk_out_name, "chk_out_name");
            this.chk_out_name.Checked = true;
            this.chk_out_name.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_out_name.Name = "chk_out_name";
            this.chk_out_name.UseVisualStyleBackColor = true;
            this.chk_out_name.CheckedChanged += new System.EventHandler(this.chk_out_name_CheckedChanged);
            // 
            // btn_browse
            // 
            resources.ApplyResources(this.btn_browse, "btn_browse");
            this.btn_browse.FlatAppearance.BorderSize = 0;
            this.btn_browse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_absolute
            // 
            resources.ApplyResources(this.radio_absolute, "radio_absolute");
            this.radio_absolute.Name = "radio_absolute";
            this.radio_absolute.UseVisualStyleBackColor = true;
            this.radio_absolute.CheckedChanged += new System.EventHandler(this.radio_absolute_CheckedChanged);
            // 
            // radio_relative
            // 
            resources.ApplyResources(this.radio_relative, "radio_relative");
            this.radio_relative.Checked = true;
            this.radio_relative.Name = "radio_relative";
            this.radio_relative.TabStop = true;
            this.radio_relative.UseVisualStyleBackColor = true;
            this.radio_relative.CheckedChanged += new System.EventHandler(this.radio_relative_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_size);
            this.groupBox1.Controls.Add(this.radio_size);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_Seconds);
            this.groupBox1.Controls.Add(this.radio_time);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // combo_size
            // 
            resources.ApplyResources(this.combo_size, "combo_size");
            this.combo_size.FormattingEnabled = true;
            this.combo_size.Items.AddRange(new object[] {
            resources.GetString("combo_size.Items"),
            resources.GetString("combo_size.Items1"),
            resources.GetString("combo_size.Items2"),
            resources.GetString("combo_size.Items3"),
            resources.GetString("combo_size.Items4"),
            resources.GetString("combo_size.Items5"),
            resources.GetString("combo_size.Items6")});
            this.combo_size.Name = "combo_size";
            this.combo_size.SelectedIndexChanged += new System.EventHandler(this.combo_size_SelectedIndexChanged);
            this.combo_size.TextChanged += new System.EventHandler(this.combo_size_TextChanged);
            // 
            // radio_size
            // 
            resources.ApplyResources(this.radio_size, "radio_size");
            this.radio_size.Checked = true;
            this.radio_size.Name = "radio_size";
            this.radio_size.TabStop = true;
            this.radio_size.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // combo_Seconds
            // 
            resources.ApplyResources(this.combo_Seconds, "combo_Seconds");
            this.combo_Seconds.FormattingEnabled = true;
            this.combo_Seconds.Items.AddRange(new object[] {
            resources.GetString("combo_Seconds.Items"),
            resources.GetString("combo_Seconds.Items1"),
            resources.GetString("combo_Seconds.Items2"),
            resources.GetString("combo_Seconds.Items3"),
            resources.GetString("combo_Seconds.Items4"),
            resources.GetString("combo_Seconds.Items5"),
            resources.GetString("combo_Seconds.Items6")});
            this.combo_Seconds.Name = "combo_Seconds";
            this.combo_Seconds.SelectedIndexChanged += new System.EventHandler(this.combo_Seconds_SelectedIndexChanged);
            this.combo_Seconds.TextChanged += new System.EventHandler(this.combo_Seconds_TextChanged);
            // 
            // radio_time
            // 
            resources.ApplyResources(this.radio_time, "radio_time");
            this.radio_time.Checked = true;
            this.radio_time.Name = "radio_time";
            this.radio_time.TabStop = true;
            this.radio_time.UseVisualStyleBackColor = true;
            // 
            // wiz_split
            // 
            resources.ApplyResources(this.wiz_split, "wiz_split");
            this.wiz_split.BackColor = System.Drawing.Color.White;
            this.wiz_split.Name = "wiz_split";
            this.wiz_split.Pages.Add(this.wz1);
            this.wiz_split.Pages.Add(this.wz_end);
            this.wiz_split.Cancelling += new System.ComponentModel.CancelEventHandler(this.wizardControl1_Cancelling);
            // 
            // wz_end
            // 
            resources.ApplyResources(this.wz_end, "wz_end");
            this.wz_end.Controls.Add(this.label9);
            this.wz_end.Controls.Add(this.label8);
            this.wz_end.Controls.Add(this.label7);
            this.wz_end.Controls.Add(this.txt_preset_name);
            this.wz_end.Controls.Add(this.chk_save_preset);
            this.wz_end.Controls.Add(this.btn_cancel);
            this.wz_end.Controls.Add(this.btn_Start);
            this.wz_end.IsFinishPage = true;
            this.wz_end.Name = "wz_end";
            this.wz_end.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wz_end_Commit);
            this.wz_end.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.wz_end_Initialize);
            this.wz_end.Rollback += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.wz_end_Rollback);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txt_preset_name
            // 
            resources.ApplyResources(this.txt_preset_name, "txt_preset_name");
            this.txt_preset_name.Name = "txt_preset_name";
            // 
            // chk_save_preset
            // 
            resources.ApplyResources(this.chk_save_preset, "chk_save_preset");
            this.chk_save_preset.Name = "chk_save_preset";
            this.chk_save_preset.UseVisualStyleBackColor = true;
            this.chk_save_preset.CheckedChanged += new System.EventHandler(this.chk_save_preset_CheckedChanged);
            // 
            // btn_cancel
            // 
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Start
            // 
            resources.ApplyResources(this.btn_Start, "btn_Start");
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // AeroWizard6
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wiz_split);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AeroWizard6";
            this.Load += new System.EventHandler(this.AeroWizard6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_warn_two)).EndInit();
            this.wz_final.ResumeLayout(false);
            this.wz_final.PerformLayout();
            this.wz1.ResumeLayout(false);
            this.wz1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wiz_split)).EndInit();
            this.wz_end.ResumeLayout(false);
            this.wz_end.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog fd1;
        private System.Windows.Forms.CheckBox chk_save_pres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_start_multi;
        private System.Windows.Forms.Button btn_abort;
        private System.Windows.Forms.Label lbl_warn;
        private System.Windows.Forms.PictureBox pic_warn_two;
        private System.Windows.Forms.CheckBox check_name;
        private System.Windows.Forms.TextBox textBox1;
        private AeroWizard.WizardPage wz_final;
        private AeroWizard.WizardPage wz1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_absolute;
        private System.Windows.Forms.RadioButton radio_relative;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_path_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_time;
        private AeroWizard.WizardControl wiz_split;
        private AeroWizard.WizardPage wz_end;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.CheckBox chk_save_preset;
        private System.Windows.Forms.TextBox txt_naming;
        private System.Windows.Forms.CheckBox chk_out_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_preset_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk_streamcopy;
        public System.Windows.Forms.ComboBox combo_ext;
        public System.Windows.Forms.ComboBox combo_Seconds;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox combo_size;
        private System.Windows.Forms.RadioButton radio_size;
        private System.Windows.Forms.Label label10;
    }
}