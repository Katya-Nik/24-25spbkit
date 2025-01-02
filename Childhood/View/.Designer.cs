namespace Childhood
{
    partial class Avtorizachiya
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorizachiya));
            this.MainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Avtoriz = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TLPPodval = new System.Windows.Forms.TableLayoutPanel();
            this.Mail = new System.Windows.Forms.Label();
            this.NikonorovaE = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pass = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.MainTLP.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TLPPodval.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTLP
            // 
            this.MainTLP.ColumnCount = 1;
            this.MainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTLP.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.MainTLP.Controls.Add(this.TLPPodval, 0, 2);
            this.MainTLP.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.MainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTLP.Location = new System.Drawing.Point(0, 0);
            this.MainTLP.Margin = new System.Windows.Forms.Padding(5);
            this.MainTLP.Name = "MainTLP";
            this.MainTLP.RowCount = 3;
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainTLP.Size = new System.Drawing.Size(752, 516);
            this.MainTLP.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.Avtoriz, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Exit, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(746, 71);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // Avtoriz
            // 
            this.Avtoriz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avtoriz.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avtoriz.Location = new System.Drawing.Point(75, 8);
            this.Avtoriz.Margin = new System.Windows.Forms.Padding(8);
            this.Avtoriz.Name = "Avtoriz";
            this.Avtoriz.Size = new System.Drawing.Size(550, 55);
            this.Avtoriz.TabIndex = 0;
            this.Avtoriz.Text = "Авторизация";
            this.Avtoriz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(641, 8);
            this.Exit.Margin = new System.Windows.Forms.Padding(8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(97, 55);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TLPPodval
            // 
            this.TLPPodval.BackColor = System.Drawing.Color.AntiqueWhite;
            this.TLPPodval.ColumnCount = 2;
            this.TLPPodval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPodval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPodval.Controls.Add(this.Mail, 1, 0);
            this.TLPPodval.Controls.Add(this.NikonorovaE, 0, 0);
            this.TLPPodval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPodval.Location = new System.Drawing.Point(3, 467);
            this.TLPPodval.Name = "TLPPodval";
            this.TLPPodval.RowCount = 1;
            this.TLPPodval.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPodval.Size = new System.Drawing.Size(746, 46);
            this.TLPPodval.TabIndex = 1;
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Mail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mail.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.Location = new System.Drawing.Point(376, 0);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(367, 46);
            this.Mail.TabIndex = 1;
            this.Mail.Text = "nikonkatyaa@gmail.com";
            this.Mail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NikonorovaE
            // 
            this.NikonorovaE.AutoSize = true;
            this.NikonorovaE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NikonorovaE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NikonorovaE.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NikonorovaE.Location = new System.Drawing.Point(3, 0);
            this.NikonorovaE.Name = "NikonorovaE";
            this.NikonorovaE.Size = new System.Drawing.Size(367, 46);
            this.NikonorovaE.TabIndex = 0;
            this.NikonorovaE.Text = "Никонорова Екатерина";
            this.NikonorovaE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Pass, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Log, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonLogin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Login, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 381);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Pass
            // 
            this.Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pass.AutoSize = true;
            this.Pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pass.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Location = new System.Drawing.Point(139, 187);
            this.Pass.Margin = new System.Windows.Forms.Padding(15);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(95, 27);
            this.Pass.TabIndex = 1;
            this.Pass.Text = "Пароль";
            this.Pass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Log.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Location = new System.Drawing.Point(15, 15);
            this.Log.Margin = new System.Windows.Forms.Padding(15);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(343, 104);
            this.Log.TabIndex = 0;
            this.Log.Text = "Логин";
            this.Log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(388, 283);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(15);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(343, 83);
            this.ButtonLogin.TabIndex = 4;
            this.ButtonLogin.Text = "Войти в систему";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Password
            // 
            this.Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(423, 184);
            this.Password.Margin = new System.Windows.Forms.Padding(50);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(273, 34);
            this.Password.TabIndex = 3;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(423, 50);
            this.Login.Margin = new System.Windows.Forms.Padding(50);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(273, 34);
            this.Login.TabIndex = 2;
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Avtorizachiya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(752, 516);
            this.Controls.Add(this.MainTLP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Avtorizachiya";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Avtorizachiya_Load);
            this.MainTLP.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TLPPodval.ResumeLayout(false);
            this.TLPPodval.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTLP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Avtoriz;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TableLayoutPanel TLPPodval;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label NikonorovaE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Log;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

