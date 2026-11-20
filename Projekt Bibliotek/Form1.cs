using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Projekt_Bibliotek.Classes;



namespace Projekt_Bibliotek
{
    public partial class Form1 : Form
    {

        private List<Media> mediaList = new List<Media>();

        public Form1()
        {
            InitializeComponent();


            // Add example media
            mediaList.Add(new Book("Harry Potter", 3, "J.K. Rowling", 1997));
            mediaList.Add(new Audiobook("The Hobbit", 2, "J.R.R. Tolkien", "Andy Serkis"));
            mediaList.Add(new Newspaper("Daily News", 5, "2026-10-07"));
            mediaList.Add(new Movie("The Matrix", 4, "The Wachowskis", 1999));
            mediaList.Add(new Game("Minecraft", 4, "Mojang", "PC"));

            dvgMedia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgMedia.MultiSelect = false;
            dvgMedia.ReadOnly = true;
            dvgMedia.ReadOnly = true;

            DisplayMedia();
        }


        private void DisplayMedia()
        {
            dvgMedia.Rows.Clear();


            foreach (Media media in mediaList)
            {
                dvgMedia.Rows.Add(
                    media.Title,
                    media.GetType().Name,
                    media.Copies
                );
            }
        }
        public void UpdateMediaList(List<Media> updatedList)
        {
            mediaList = updatedList;
            DisplayMedia();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddMediaForm addForm = new AddMediaForm();

                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    mediaList.Add(addForm.NewMedia);
                    DisplayMedia();
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error opening AddMediaForm");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dvgMedia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a media first.");
                return;
            }

            int selectedIndex = dvgMedia.SelectedRows[0].Index;

            Media selectedMedia = mediaList[selectedIndex];

            lblDetailsTitle.Text = selectedMedia.Title;

            lblDetails.Text =
                "Media type: " + selectedMedia.GetType().Name + "\n" +
                selectedMedia.GetDetails() + "\n" +
                "Available copies: " + selectedMedia.Copies;


            dvgMedia.Visible = false;
            btnDetails.Visible = false;
            btnAdd.Visible = false;
            btnEdit.Visible = false;
            btnRemove.Visible = false;

            pnlDetails.Visible = true;
            pnlDetails.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlDetails.Visible = false;
            dvgMedia.Visible = true;
            btnDetails.Visible = true;
            btnAdd.Visible = true;
            btnEdit.Visible = true;
            btnRemove.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = dvgMedia.SelectedRows[0].Index;

            string MediaTitle = mediaList[selectedIndex].Title;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to remove " + MediaTitle + "?",
                "Remove Media",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                mediaList.RemoveAt(selectedIndex);

                DisplayMedia();

                MessageBox.Show("Media removed successfully!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dvgMedia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a media to edit.");
                return;
            }

            int selectedIndex = dvgMedia.SelectedRows[0].Index;
            Media selectedMedia = mediaList[selectedIndex];

            AddMediaForm editForm = new AddMediaForm(selectedMedia);

            if (editForm.ShowDialog(this) == DialogResult.OK)
            {
                mediaList[selectedIndex] = editForm.NewMedia;

                DisplayMedia();

                MessageBox.Show("Media updated successfully!");
            }
        }
    }
}
