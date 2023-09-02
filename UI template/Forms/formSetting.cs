﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace UI_template.Forms
{
    public partial class formSetting : Form
    {
        DataTable now_var_table = new DataTable();
        Recipe_ReadWrite Recipe_ReadWrite = new Recipe_ReadWrite();
        public formSetting()
        {
            InitializeComponent();
        }
        private void LoadTheme(System.Windows.Forms.Control controls)        //變色
        {
            foreach (System.Windows.Forms.Control control in controls.Controls)
            {
                if (control.Controls.Count > 0)
                    LoadTheme(control);
                else
                {
                    if (control is System.Windows.Forms.Button)
                    {
                        System.Windows.Forms.Button btn = (System.Windows.Forms.Button)control;
                        btn.BackColor = ThemeColor.PrimaryColor;
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    }

                    else if (control is System.Windows.Forms.Label)
                    {
                        control.ForeColor = ThemeColor.PrimaryColor;
                    }
                }
            }
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {
            LoadTheme(tCl_setting);
        }
        private void Save(DataTable dataTable)
        {
            Recipe_ReadWrite.load_Var(tCl_setting, dataTable);
        }
        public string guideFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇檔案";
            dialog.Filter = "所有檔案(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }
        public string guideFolder()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "請選擇資料夾";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = dialog.SelectedPath;
                return filepath;
            }
            return null;
        }
        private void btn_set_Save_Click(object sender, EventArgs e)
        {
            string path = guideFolder();
            if (path != null && tbx_FileName.Text != "")
            {
                List<string> now_var_list = new List<string>();
                now_var_table.Clear();
                now_var_table.Columns.Clear();
                now_var_list = Recipe_ReadWrite.crawl_Var(tCl_setting, now_var_list);
                now_var_table = Recipe_ReadWrite.create_table(now_var_list);

                Recipe_ReadWrite.create_CSV(path, now_var_table, $"{tbx_FileName.Text}.csv");

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//調整大小
                dataGridView1.DataSource = now_var_table;//顯示
            }
        }
        private void btn_set_read_Click(object sender, EventArgs e)
        {
            now_var_table.Clear();
            now_var_table.Columns.Clear();
            string path = guideFile();
            if (path != null)
            {
                now_var_table = Recipe_ReadWrite.read_CSV(path);
                Save(now_var_table);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//調整大小
                dataGridView1.DataSource = now_var_table;//顯示
            }
        }
    }
}
