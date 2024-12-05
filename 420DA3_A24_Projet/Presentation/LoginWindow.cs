using _420DA3_A24_Projet.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_A24_Projet.Presentation;
/// <summary>
/// Classe représentant la vue de connexion au système
/// </summary>
internal partial class LoginWindow : Form {
    /// <summary>
    /// L'application elle-même
    /// </summary>
    private WsysApplication parentApp;

    /// <summary>
    /// Constructeur
    /// </summary>
    /// <param name="parentApp">L'application</param>
    public LoginWindow(WsysApplication parentApp) {
        this.parentApp = parentApp;
        this.InitializeComponent();
    }

    /// <summary>
    /// Déclencher le processsus de connexion
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ConnectionButton_Click(object sender, EventArgs e) {
        try {
            string username = this.usernameTextBox.Text.Trim();
            string password = this.passwordTextBox.Text.Trim();
            this.parentApp.LoginService.TryLogIn(username, password);
            this.DialogResult = DialogResult.OK;
        } catch (Exception ex) {
            this.parentApp.HandleException(ex);
        }

    }

    /// <summary>
    /// Quitter la fenêtre de connexion
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(object sender, EventArgs e) {
        DialogResult result = MessageBox.Show("Vous devez vous connectez pour continuer l'utilisation ! Est-vous sur de quitter ?",
            "Confirmation",
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes) {
            Application.Exit();
        }
    }
}
