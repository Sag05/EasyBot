using System.Security;


namespace EasyBot
{
    public partial class Form1 : Form
    {
        string token;

        public Form1()
        {
            InitializeComponent();
        }

        //Get Token for discord bot
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileSelector = new OpenFileDialog();

            if (fileSelector.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var reader = new StreamReader(fileSelector.FileName);
                    token = reader.ReadToEnd();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        //Start bot
        private async void startButton_Click(object sender, EventArgs e) => await DiscordStart.StartBot(token);

        public void outputAddText(string input) => textOutput.Text += input;
    }
}