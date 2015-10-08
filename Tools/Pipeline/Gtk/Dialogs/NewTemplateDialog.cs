﻿using System;
using System.Collections.Generic;
using Gtk;

namespace MonoGame.Tools.Pipeline
{
    public partial class NewTemplateDialog : Dialog
    {
        public string name;
        public ContentItemTemplate templateFile;

        List<ContentItemTemplate> items;
        TreeStore listStore;

        public NewTemplateDialog (IEnumerator<ContentItemTemplate> enums)
        {
            Build();

            Title = "New Item";
            var column = new TreeViewColumn ();

            var iconCell = new CellRendererPixbuf ();
            var textCell = new CellRendererText ();
            var textCell2 = new CellRendererText ();

            column.PackStart (iconCell, false);
            column.PackStart (textCell, false);
            column.PackStart (textCell2, false);

            treeview1.AppendColumn (column);

            column.AddAttribute (iconCell,  "pixbuf", 0);
            column.AddAttribute (textCell, "text", 1);
            column.AddAttribute (textCell, "text", 2);

            listStore = new TreeStore (typeof (Gdk.Pixbuf), typeof (string), typeof (string));
            treeview1.Model = listStore;

            items = new List<ContentItemTemplate> ();
            int i = 0;

            while (enums.MoveNext ()) {
                listStore.AppendValues (new Gdk.Pixbuf (System.IO.Path.GetDirectoryName (enums.Current.TemplateFile) + "/" + enums.Current.Icon), enums.Current.Label, i.ToString());
                items.Add (enums.Current);
                i++;
            }
        }

        protected void OnResponse(object sender, EventArgs e)
        {
            name = entry1.Text;

            TreeIter iter;
            if (treeview1.Selection.GetSelected (out iter)) {
                int tid = Convert.ToInt32 (treeview1.Model.GetValue (iter, 2).ToString ());
                templateFile = items [tid];
            }

            Destroy();
        }

        public void ButtonOkEnabled()
        {
            TreeIter iter;

            if (entry1.Text != "") {
                if (MainWindow.CheckString (entry1.Text, MainWindow.AllowedCharacters)) {
                    if (treeview1.Selection.GetSelected (out iter)) {
                        buttonOk.Sensitive = true;
                        label2.Visible = false;
                    } else {
                        buttonOk.Sensitive = false;
                        label2.Visible = false;
                    }
                } else {
                    buttonOk.Sensitive = false;
                    label2.Visible = true;
                }
            } else {
                buttonOk.Sensitive = false;
                label2.Visible = false;
            }
        }

        protected void OnTreeview1CursorChanged (object sender, EventArgs e)
        {
            TreeIter iter;
            if(treeview1.Selection.GetSelected(out iter))
                ButtonOkEnabled ();
        }

        protected void OnEntry1Changed (object sender, EventArgs e)
        {
            ButtonOkEnabled ();
        }

        protected void OnButtonOkClicked (object sender, EventArgs e)
        {
            if (buttonOk.Sensitive) 
                Respond(ResponseType.Ok);
        }
    }
}

