using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Files
{
    public class FilesHandler
    {
        private List<String> listoffiles;
        private Image selectedimage = null;

        public FilesHandler()
        {
            listoffiles = new List<String>();
        }

        private bool checkItem(String item)
        {
            for (int i = 0; i < listoffiles.Count; i++)
                if (listoffiles[i] == item)
                    return false;

            return true;
        }

        public void addItems(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (checkItem(arr[i]))
                    listoffiles.Add(arr[i]);
        }

        public void showItemsOnLVWF(ListBox lb)
        {
            lb.Items.Clear();

            for (int i = 0; i < listoffiles.Count; i++)
                lb.Items.Add(Path.GetFileName(listoffiles[i]));
        }

        public void showItemsOnLVWPF(System.Windows.Controls.ListBox lb)
        {
            lb.Items.Clear();

            for (int i = 0; i < listoffiles.Count; i++)
                lb.Items.Add(Path.GetFileName(listoffiles[i]));
        }

        public String getFileNameByIndex(int index)
        {
            selectedimage = Image.FromFile(listoffiles[index]);
            return listoffiles[index];
        }

        public Image getSelectedImage()
        {
            return selectedimage;
        }
    }
}
