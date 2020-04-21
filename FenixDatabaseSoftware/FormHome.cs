// Fenix Database Software 1.0
// Copyright © Ismael Heredia 2020

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Configuration;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace FenixDatabaseSoftware
{
    public partial class FormHome : Telerik.WinControls.UI.RadForm
    {

        public string program_title = "Fenix Database Software 1.0";
        public string database_name;
        public string database_exported;

        public FormHome()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("Office2013Light");
            database_name = System.Configuration.ConfigurationManager.AppSettings["database_name"];
            database_exported = System.Configuration.ConfigurationManager.AppSettings["database_exported"];
            miEditName.Click += miEditName_Click;
            miEditLink.Click += miEditLink_Click;
            miDelete.Click += miDelete_Click;
        }

        private void add()
        {
            var name = RadInputBox.Show("Enter name", program_title, "");
            var link = RadInputBox.Show("Enter link", program_title, "");
            if (name != "")
            {
                if (link == "")
                {
                    link = "--";
                }

                ListViewDataItem add = new ListViewDataItem();
                add.SubItems.Add(name);
                add.SubItems.Add(link);

                bool existe = false;

                foreach (ListViewDataItem item in lvSoftware.Items)
                {
                    string name_check = item[0].ToString();
                    if(name == name_check)
                    {
                        existe = true;
                    }
                }

                if (existe == false)
                {
                    lvSoftware.Items.Add(add);
                } else
                {
                    RadMessageBox.Show("The name already exists", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void edit_name()
        {
            if (lvSoftware.SelectedItems.Count > 0)
            {
                var name = lvSoftware.SelectedItem[0].ToString();

                var new_name = RadInputBox.Show("Enter name", program_title, name);

                var count = 0;

                foreach (ListViewDataItem item in lvSoftware.Items)
                {
                    string name_check = item[0].ToString();
                    if (new_name == name_check)
                    {
                        count = count + 1;
                    }
                    else if(name == name_check)
                    {
                        count = count + 1;
                    }
                }

                if (count != 2)
                {
                    if (new_name != "")
                    {
                        MessageBox.Show(count.ToString());
                        lvSoftware.SelectedItem[0] = new_name;
                    }
                } else
                {
                    RadMessageBox.Show("The name already exists", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }

        private void edit_link()
        {
            if (lvSoftware.SelectedItems.Count > 0)
            {
                string link = lvSoftware.SelectedItem[1].ToString();
                var new_link = RadInputBox.Show("Enter link", program_title, link);
                if (new_link != "")
                {
                    lvSoftware.SelectedItem[1] = new_link;
                }
                else
                {
                    lvSoftware.SelectedItem[1] = "--";
                }
            }
        }

        private void delete()
        {
            if (lvSoftware.SelectedItems.Count > 0)
            {
                lvSoftware.SelectedItems.Clear();
            }
        }

        private void refresh_table()
        {
            lvSoftware.Items.Clear();
            if (File.Exists(Path.GetFullPath(database_name)))
            {
                DataAccess da = new DataAccess();
                ArrayList listSoftware = da.read_database();
                foreach (Software software in listSoftware)
                {
                    int id_software = software.pId_software;
                    string name = software.pName;
                    string link = software.pLink;
                    ListViewDataItem add = new ListViewDataItem();
                    add.SubItems.Add(name);
                    add.SubItems.Add(link);
                    lvSoftware.Items.Add(add);
                }
                gbSoftware.Text = "Software : " + lvSoftware.Items.Count  + " found";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit_name();
            edit_link();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Are you sure ?", program_title, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                ArrayList listSoftware = new ArrayList();
                foreach (ListViewDataItem item in lvSoftware.Items)
                {
                    Software software = new Software();
                    software.pName = item[0].ToString();
                    software.pLink = item[1].ToString();
                    listSoftware.Add(software);
                }

                DataAccess da = new DataAccess();
                if (da.update_database(listSoftware))
                {
                    refresh_table();
                    RadMessageBox.Show("The data was saved", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    RadMessageBox.Show("Error saving data", program_title, MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult ds = RadMessageBox.Show(this, "Are you sure ?", program_title, MessageBoxButtons.YesNo, RadMessageIcon.Question);
            if (ds.ToString() == "Yes")
            {
                if (File.Exists(Path.GetFullPath(database_name)))
                {
                    if (File.Exists(Path.GetFullPath(database_exported)))
                    {
                        File.Delete(database_exported);
                    }

                    DataAccess da = new DataAccess();
                    ArrayList listSoftware = da.read_database();

                    string html = "<html>" + Environment.NewLine;
                    html += "<head>" + Environment.NewLine;
                    html += "<link href='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css' rel='stylesheet' integrity='sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh' crossorigin='anonymous'>" + Environment.NewLine;
                    html += "<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js' integrity='sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6' crossorigin='anonymous'></script>" + Environment.NewLine;
                    html += "<script src='https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.bundle.min.js' integrity='sha384-6khuMg9gaYr5AxOqhkVIODVIvm9ynTT5J4V1cfthmT+emCG6yVmEZsRHdxlotUnm' crossorigin='anonymous'></script>" + Environment.NewLine;
                    html += "</head>" + Environment.NewLine;
                    html += "<body>" + Environment.NewLine;
                    html += "<br/>" + Environment.NewLine;
                    html += "<h1 align='center'>Software</h1>" + Environment.NewLine;
                    html += "<br/>" + Environment.NewLine;
                    html += "<table class='table'>" + Environment.NewLine;
                    html += "<thead>" + Environment.NewLine;
                    html += "<tr>" + Environment.NewLine;
                    html += "<th scope='col'>#</th>" + Environment.NewLine;
                    html += "<th scope='col'>Name</th>" + Environment.NewLine;
                    html += "<th scope='col'>Link</th>" + Environment.NewLine;
                    html += "</tr>" + Environment.NewLine;
                    html += "</thead>" + Environment.NewLine;
                    html += "<tbody>" + Environment.NewLine;

                    foreach (Software software in listSoftware)
                    {
                        int id_software = software.pId_software;
                        string name = software.pName;
                        string link = software.pLink;

                        html += "<tr>" + Environment.NewLine;
                        html += "<th scope='row'>" + id_software + "</th>" + Environment.NewLine;
                        html += "<td>" + name + "</td>" + Environment.NewLine;

                        if (link != "--")
                        {
                            html += "<td><a href='" + link + "' target='_blank'>Download</a></td>" + Environment.NewLine;
                        }
                        else
                        {
                            html += "<td><a href='http://www.google.com/search?q=" + link + "' target='_blank'>Search</a></td>" + Environment.NewLine;
                        }
                        html += "</tr>" + Environment.NewLine;
                    }

                    html += "</tbody>" + Environment.NewLine;
                    html += "</table>" + Environment.NewLine;
                    html += "</body>" + Environment.NewLine;
                    html += "</html>" + Environment.NewLine;

                    File.WriteAllText(database_exported, html);

                    DialogResult dse = RadMessageBox.Show(this, "You want to load the exported file ?", program_title, MessageBoxButtons.YesNo, RadMessageIcon.Question);
                    if (dse.ToString() == "Yes")
                    {
                        System.Diagnostics.Process.Start(database_exported);
                    }

                    RadMessageBox.Show("The list was exported", program_title, MessageBoxButtons.OK, RadMessageIcon.Info, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (lvSoftware.SelectedIndex > 0)
            {
                int index = lvSoftware.SelectedIndex;
                ListViewDataItem current = lvSoftware.SelectedItem as ListViewDataItem;
                lvSoftware.Items.Remove(current);
                lvSoftware.Items.Insert(index - 1, current);
                lvSoftware.SelectedIndex = index - 1;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if ((lvSoftware.SelectedIndex > -1) && (lvSoftware.SelectedIndex < lvSoftware.Items.Count - 1))
            {
                int index = lvSoftware.SelectedIndex;
                ListViewDataItem current = lvSoftware.SelectedItem as ListViewDataItem;
                lvSoftware.Items.Remove(current);
                lvSoftware.Items.Insert(index + 1, current);
                lvSoftware.SelectedIndex = index + 1;
            }
        }

        private void lvSoftware_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lvSoftware.SelectedIndex > -1)
                {
                    cmOptions.Show(Cursor.Position);
                }
            }
        }

        private void miEditName_Click(object sender, EventArgs e)
        {
            edit_name();
        }

        private void miEditLink_Click(object sender, EventArgs e)
        {
            edit_link();
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            refresh_table();
        }
    }
}
