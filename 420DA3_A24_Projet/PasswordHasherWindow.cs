using _420DA3_A24_Projet.Business.Services;

namespace _420DA3_A24_Projet;

public partial class PasswordHasherWindow : Form {
    public PasswordHasherWindow() {
        this.InitializeComponent();
    }

    private void ConvertButton_Click(object sender, EventArgs e) {
        PasswordService passwordService = PasswordService.GetInstance();
        string password = this.clearPasswordTextBox.Text;
        string hashedPassword = passwordService.HashPassword(password);
        this.phHashTextBox.Text = hashedPassword;
    }

    private void QuitButton_Click(object sender, EventArgs e) {
        Application.Exit();
    }
}
