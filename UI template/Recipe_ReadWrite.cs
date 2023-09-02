using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Shapes;

namespace UI_template
{
    public class Recipe_ReadWrite
    {
        public List<string> crawl_Var(System.Windows.Forms.Control controls, List<string> strings)   //抓資料
        {
            foreach (System.Windows.Forms.Control control in controls.Controls)
            {
                if (control.Controls.Count > 0)
                    crawl_Var(control, strings);
                else
                {
                    if (control is System.Windows.Forms.TextBox)
                    {
                        strings.Add(control.Name);
                        strings.Add(control.Text);
                    }
                    else if (control is System.Windows.Forms.CheckBox)
                    {
                        System.Windows.Forms.CheckBox ck = (System.Windows.Forms.CheckBox)control;
                        strings.Add(ck.Name);
                        strings.Add(ck.Checked.ToString());
                    }
                    else if (control is System.Windows.Forms.RadioButton)
                    {
                        System.Windows.Forms.RadioButton rb = (System.Windows.Forms.RadioButton)control;
                        strings.Add(rb.Name);
                        strings.Add(rb.Checked.ToString());
                    }
                }
            }
            return strings;
        }
        public void load_Var(System.Windows.Forms.Control controls, DataTable dataTable)
        {
            foreach (System.Windows.Forms.Control control in controls.Controls)
            {
                if (control.Controls.Count > 0)
                    load_Var(control, dataTable);
                else
                {
                    for (int i = 0; i < dataTable.Rows.Count;i++)
                    {
                        if (control.Name == dataTable.Rows[i]["Name"].ToString())
                        {
                            control.Text = dataTable.Rows[i]["Text"].ToString();
                        }
                    }
                }
            }
        }
        public DataTable create_table(List<string> strings)//存成datatable
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Name", typeof(String));
            dt.Columns.Add("Text", typeof(String));

            for (int i = 0; i < strings.Count; i += 2)
            {
                dt.Rows.Add(strings[i], strings[i + 1]);
            }
            return dt;
        }
        public DataTable read_CSV(string path)//讀CSV
        {
            DataTable dt = new DataTable();
            using (StreamReader sr = new StreamReader(path))
            {
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    dt.Columns.Add(header);
                }
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
        public void create_CSV(string path, DataTable dt, string name)//建CSV
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);//建資料夾

            path = $"{path}\\{name}";
            StreamWriter s = new StreamWriter(path, false);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                s.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                    s.Write(",");
            }
            s.Write(s.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (!Convert.IsDBNull(dr[i]))
                    {
                        string value = dr[i].ToString();
                        if (value.Contains(','))
                        {
                            value = String.Format("\"{0}\"", value);
                            s.Write(value);
                        }
                        else
                            s.Write(dr[i].ToString());
                    }
                    if (i < dt.Columns.Count - 1)
                        s.Write(",");
                }
                s.Write(s.NewLine);
            }
            s.Close();
        }
    }
}
