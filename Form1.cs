using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_11._3_FrontEnd
{
    public partial class Form1 : Form
    {
        HttpClient gamesClient = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamesClient.BaseAddress = new Uri("http://localhost:5083/api/VideoGames/");
        }

        private async void btnGetGames_Click(object sender, EventArgs e)
        {
            var games = await gamesClient.GetAsync(gamesClient.BaseAddress);
            if (games.IsSuccessStatusCode)
            {
                var gamesList = await games.Content.ReadFromJsonAsync<List<VideoGame>>();
                dgvGames.DataSource = gamesList;
            }
            else
            {
                MessageBox.Show("Error: " + games.StatusCode);
            }

            btnClearFields.PerformClick();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            using StringContent content = SerializeTextboxes();

            using var response = gamesClient.PostAsync(gamesClient.BaseAddress, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Game added successfully!");
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }

            btnGetGames.PerformClick();
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            using StringContent content = SerializeTextboxes();

            using var response = gamesClient.PutAsync(txtID.Text, content).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Game updated successfully!");
                btnGetGames.PerformClick();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }

        private async void btnDeleteGame_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show($"Are you sure you want to delete the game at ID {txtID.Text}?","Confirm Deletion",MessageBoxButtons.YesNo);
            if (selection == DialogResult.No) return;

            var response = await gamesClient.DeleteAsync(txtID.Text);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Game deleted successfully.");
                btnGetGames.PerformClick();
            }
            else
            {
                MessageBox.Show("Error: " + response.StatusCode);
            }
        }

        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = dgvGames.CurrentRow.Cells["ID"].Value.ToString();
            txtTitle.Text = dgvGames.CurrentRow.Cells["Title"].Value.ToString();
            txtDeveloper.Text = dgvGames.CurrentRow.Cells["Developer"].Value.ToString();
            txtPublisher.Text = dgvGames.CurrentRow.Cells["Publisher"].Value.ToString();
            txtReleaseYear.Text = dgvGames.CurrentRow.Cells["ReleaseYear"].Value.ToString();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtTitle.Clear();
            txtDeveloper.Clear();
            txtPublisher.Clear();
            txtReleaseYear.Clear();
        }

        private StringContent SerializeTextboxes()
        {
            return new StringContent(JsonSerializer.Serialize(new VideoGame
            {
                ID = Convert.ToInt32(txtID.Text),
                Title = txtTitle.Text,
                Developer = txtDeveloper.Text,
                Publisher = txtPublisher.Text,
                ReleaseYear = Convert.ToInt32(txtReleaseYear.Text)
            }), System.Text.Encoding.UTF8, "application/json");
        }
    }
}