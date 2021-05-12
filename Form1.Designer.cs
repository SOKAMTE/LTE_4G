namespace LTE_4G
{
    partial class connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(connexion));
            this.panel = new System.Windows.Forms.Panel();
            this.nom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.loginForget = new System.Windows.Forms.Label();
            this.passwordForget = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resetPass = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel.Controls.Add(this.resetPass);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.passwordForget);
            this.panel.Controls.Add(this.loginForget);
            this.panel.Controls.Add(this.password);
            this.panel.Controls.Add(this.login);
            this.panel.Controls.Add(this.connect);
            this.panel.Controls.Add(this.textBox2);
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.nom);
            this.panel.Location = new System.Drawing.Point(1, -2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(431, 454);
            this.panel.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(54, 53);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(321, 37);
            this.nom.TabIndex = 0;
            this.nom.Text = "Logo de l\'Entreprise";
            this.nom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 2;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(115, 341);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(180, 39);
            this.connect.TabIndex = 3;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(45, 199);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(53, 20);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(45, 270);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(86, 20);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // loginForget
            // 
            this.loginForget.AutoSize = true;
            this.loginForget.ForeColor = System.Drawing.Color.Maroon;
            this.loginForget.Location = new System.Drawing.Point(138, 226);
            this.loginForget.Name = "loginForget";
            this.loginForget.Size = new System.Drawing.Size(126, 13);
            this.loginForget.TabIndex = 6;
            this.loginForget.Text = "nom d\'utilisateur incorrect";
            // 
            // passwordForget
            // 
            this.passwordForget.AutoSize = true;
            this.passwordForget.ForeColor = System.Drawing.Color.Maroon;
            this.passwordForget.Location = new System.Drawing.Point(138, 293);
            this.passwordForget.Name = "passwordForget";
            this.passwordForget.Size = new System.Drawing.Size(114, 13);
            this.passwordForget.TabIndex = 7;
            this.passwordForget.Text = "mot de passe incorrect";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Authentification";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // resetPass
            // 
            this.resetPass.AutoSize = true;
            this.resetPass.Location = new System.Drawing.Point(249, 417);
            this.resetPass.Name = "resetPass";
            this.resetPass.Size = new System.Drawing.Size(110, 13);
            this.resetPass.TabIndex = 9;
            this.resetPass.Text = "mot de passe oublié ?";
            // 
            // connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page de connexion";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label resetPass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label passwordForget;
        public System.Windows.Forms.Label loginForget;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nom;
    }
}

