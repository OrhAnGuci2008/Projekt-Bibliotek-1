using System;
using System.Windows.Forms;
using Projekt_Bibliotek.Classes;


namespace Projekt_Bibliotek
{
    public partial class AddMediaForm : Form
    {
        public Media NewMedia { get; private set; }

        public AddMediaForm()
        {
            InitializeComponent();

            cmbMediaType.Items.Add("Book");
            cmbMediaType.Items.Add("Audiobook");
            cmbMediaType.Items.Add("Newspaper");
            cmbMediaType.Items.Add("Movie");
            cmbMediaType.Items.Add("Game");

            cmbMediaType.SelectedIndex = 0;

            // Connect buttons and ComboBox
            cmbMediaType.SelectedIndexChanged += cmbMediaType_SelectedIndexChanged;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void cmbMediaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbMediaType.Text;

            lblExtra2.Visible = true;
            txtExtra2.Visible = true;

            switch (selectedType)
            {
                case "Book":
                    lblExtra1.Text = "Author";
                    lblExtra2.Text = "Publication Year";
                    break;

                case "Audiobook":
                    lblExtra1.Text = "Author";
                    lblExtra2.Text = "Narrator";
                    break;

                case "Newspaper":
                    lblExtra1.Text = "Date";
                    lblExtra2.Visible = false;
                    txtExtra2.Visible = false;
                    break;

                case "Movie":
                    lblExtra1.Text = "Director";
                    lblExtra2.Text = "Release Year";
                    break;

                case "Game":
                    lblExtra1.Text = "Developer";
                    lblExtra2.Text = "Platform";
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check title
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            // Check copies
            if (!int.TryParse(txtCopies.Text, out int copies) || copies < 0)
            {
                MessageBox.Show("Please enter a valid number of copies.");
                return;
            }

            string title = txtTitle.Text.Trim();
            string extra1 = txtExtra1.Text.Trim();
            string extra2 = txtExtra2.Text.Trim();

            if (string.IsNullOrWhiteSpace(extra1))
            {
                MessageBox.Show("Please fill in the additional information.");
                return;
            }

            // Create the correct media object
            switch (cmbMediaType.Text)
            {
                case "Book":
                    if (!int.TryParse(extra2, out int bookYear))
                    {
                        MessageBox.Show("Enter a valid publication year.");
                        return;
                    }

                    NewMedia = new Book(title, copies, extra1, bookYear);
                    break;

                case "Audiobook":
                    if (string.IsNullOrWhiteSpace(extra2))
                    {
                        MessageBox.Show("Please enter a narrator.");
                        return;
                    }

                    NewMedia = new Audiobook(title, copies, extra1, extra2);
                    break;

                case "Newspaper":
                    NewMedia = new Newspaper(title, copies, extra1);
                    break;

                case "Movie":
                    if (!int.TryParse(extra2, out int movieYear))
                    {
                        MessageBox.Show("Enter a valid release year.");
                        return;
                    }

                    NewMedia = new Movie(title, copies, extra1, movieYear);
                    break;

                case "Game":
                    if (string.IsNullOrWhiteSpace(extra2))
                    {
                        MessageBox.Show("Please enter a platform.");
                        return;
                    }

                    NewMedia = new Game(title, copies, extra1, extra2);
                    break;
            }

            // Close form successfully
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public AddMediaForm(Media media)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;

            // Add media types
            cmbMediaType.Items.Add("Book");
            cmbMediaType.Items.Add("Audiobook");
            cmbMediaType.Items.Add("Newspaper");
            cmbMediaType.Items.Add("Movie");
            cmbMediaType.Items.Add("Game");

            // Connect events
            cmbMediaType.SelectedIndexChanged += cmbMediaType_SelectedIndexChanged;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;

            // Change form title
            this.Text = "Edit Media";
            btnSave.Text = "Save Changes";

            // Select media type
            cmbMediaType.SelectedItem = media.GetType().Name;

            // Update labels
            cmbMediaType_SelectedIndexChanged(cmbMediaType, EventArgs.Empty);

            // Fill in existing information
            txtTitle.Text = media.Title;
            txtCopies.Text = media.Copies.ToString();

            if (media is Book book)
            {
                txtExtra1.Text = book.Author;
                txtExtra2.Text = book.PublicationYear.ToString();
            }
            else if (media is Audiobook audiobook)
            {
                txtExtra1.Text = audiobook.Author;
                txtExtra2.Text = audiobook.Narrator;
            }
            else if (media is Newspaper newspaper)
            {
                txtExtra1.Text = newspaper.Date;
            }
            else if (media is Movie movie)
            {
                txtExtra1.Text = movie.Director;
                txtExtra2.Text = movie.ReleaseYear.ToString();
            }
            else if (media is Game game)
            {
                txtExtra1.Text = game.Developer;
                txtExtra2.Text = game.Platform;
            }
        }

        private void AddMediaForm_Load(object sender, EventArgs e)
        {

        }
    }
}

