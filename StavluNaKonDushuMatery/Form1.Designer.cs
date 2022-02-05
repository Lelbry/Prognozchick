namespace StavluNaKonDushuMatery
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AccountH = new System.Windows.Forms.TextBox();
            this.Money = new System.Windows.Forms.Button();
            this.Vivod = new System.Windows.Forms.RichTextBox();
            this.AccountG = new System.Windows.Forms.TextBox();
            this.Vid = new AxWMPLib.AxWindowsMediaPlayer();
            this.Home = new System.Windows.Forms.Label();
            this.Goest = new System.Windows.Forms.Label();
            this.ColonaA = new System.Windows.Forms.PictureBox();
            this.btn_ProverkaNewForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Vid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColonaA)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountH
            // 
            this.AccountH.AcceptsReturn = true;
            this.AccountH.AcceptsTab = true;
            this.AccountH.Location = new System.Drawing.Point(9, 59);
            this.AccountH.Margin = new System.Windows.Forms.Padding(2);
            this.AccountH.Multiline = true;
            this.AccountH.Name = "AccountH";
            this.AccountH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccountH.Size = new System.Drawing.Size(100, 19);
            this.AccountH.TabIndex = 0;
            this.AccountH.TextChanged += new System.EventHandler(this.ControlH);
            // 
            // Money
            // 
            this.Money.BackColor = System.Drawing.SystemColors.Window;
            this.Money.Cursor = System.Windows.Forms.Cursors.Default;
            this.Money.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Money.FlatAppearance.BorderSize = 0;
            this.Money.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Money.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Money.Location = new System.Drawing.Point(9, 119);
            this.Money.Margin = new System.Windows.Forms.Padding(2);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(231, 61);
            this.Money.TabIndex = 1;
            this.Money.Text = "Ставлю на кон душу матери";
            this.Money.UseVisualStyleBackColor = false;
            this.Money.Click += new System.EventHandler(this.DelatDengiBlyatVotTak);
            // 
            // Vivod
            // 
            this.Vivod.BackColor = System.Drawing.Color.White;
            this.Vivod.Enabled = false;
            this.Vivod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vivod.Location = new System.Drawing.Point(9, 200);
            this.Vivod.Margin = new System.Windows.Forms.Padding(2);
            this.Vivod.Name = "Vivod";
            this.Vivod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Vivod.Size = new System.Drawing.Size(266, 101);
            this.Vivod.TabIndex = 3;
            this.Vivod.Text = "";
            // 
            // AccountG
            // 
            this.AccountG.Location = new System.Drawing.Point(128, 60);
            this.AccountG.Margin = new System.Windows.Forms.Padding(2);
            this.AccountG.Name = "AccountG";
            this.AccountG.Size = new System.Drawing.Size(106, 20);
            this.AccountG.TabIndex = 4;
            this.AccountG.TextChanged += new System.EventHandler(this.ControlG);
            // 
            // Vid
            // 
            this.Vid.Enabled = true;
            this.Vid.Location = new System.Drawing.Point(633, 47);
            this.Vid.Margin = new System.Windows.Forms.Padding(2);
            this.Vid.Name = "Vid";
            this.Vid.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Vid.OcxState")));
            this.Vid.Size = new System.Drawing.Size(342, 238);
            this.Vid.TabIndex = 5;
            this.Vid.Visible = false;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.BackColor = System.Drawing.Color.White;
            this.Home.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(9, 10);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(303, 25);
            this.Home.TabIndex = 6;
            this.Home.Text = "Введите счёт матчей у хозяев";
            // 
            // Goest
            // 
            this.Goest.AutoSize = true;
            this.Goest.BackColor = System.Drawing.Color.White;
            this.Goest.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Goest.Location = new System.Drawing.Point(302, 10);
            this.Goest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Goest.Name = "Goest";
            this.Goest.Size = new System.Drawing.Size(302, 25);
            this.Goest.TabIndex = 7;
            this.Goest.Text = "Введите счёт матчей у гостей";
            // 
            // ColonaA
            // 
            this.ColonaA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ColonaA.Location = new System.Drawing.Point(348, 60);
            this.ColonaA.Margin = new System.Windows.Forms.Padding(2);
            this.ColonaA.Name = "ColonaA";
            this.ColonaA.Size = new System.Drawing.Size(105, 144);
            this.ColonaA.TabIndex = 8;
            this.ColonaA.TabStop = false;
            // 
            // btn_ProverkaNewForm
            // 
            this.btn_ProverkaNewForm.Location = new System.Drawing.Point(348, 259);
            this.btn_ProverkaNewForm.Name = "btn_ProverkaNewForm";
            this.btn_ProverkaNewForm.Size = new System.Drawing.Size(151, 26);
            this.btn_ProverkaNewForm.TabIndex = 10;
            this.btn_ProverkaNewForm.Text = "Создание новой формы";
            this.btn_ProverkaNewForm.UseVisualStyleBackColor = true;
            this.btn_ProverkaNewForm.Click += new System.EventHandler(this.btn_ProverkaNewForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1073, 404);
            this.Controls.Add(this.btn_ProverkaNewForm);
            this.Controls.Add(this.Goest);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Vid);
            this.Controls.Add(this.AccountG);
            this.Controls.Add(this.Vivod);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.AccountH);
            this.Controls.Add(this.ColonaA);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Наруто";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartScreen);
            ((System.ComponentModel.ISupportInitialize)(this.Vid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColonaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountH;
        private System.Windows.Forms.Button Money;
        private System.Windows.Forms.RichTextBox Vivod;
        private System.Windows.Forms.TextBox AccountG;
        private AxWMPLib.AxWindowsMediaPlayer Vid;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label Goest;
        private System.Windows.Forms.PictureBox ColonaA;
        private System.Windows.Forms.Button btn_ProverkaNewForm;
    }
}

