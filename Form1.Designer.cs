namespace StoneScissors
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
			if(disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.rbServer = new System.Windows.Forms.RadioButton();
			this.rbClient = new System.Windows.Forms.RadioButton();
			this.btnStart = new System.Windows.Forms.Button();
			this.lblResult = new System.Windows.Forms.Label();
			this.tbxDebug = new System.Windows.Forms.TextBox();
			this.tbxAddress = new System.Windows.Forms.TextBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.btnInstruct = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnPaper = new System.Windows.Forms.Button();
			this.btnScissors = new System.Windows.Forms.Button();
			this.btnStone = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rbServer
			// 
			this.rbServer.AutoSize = true;
			this.rbServer.Checked = true;
			this.rbServer.Location = new System.Drawing.Point(32, 35);
			this.rbServer.Name = "rbServer";
			this.rbServer.Size = new System.Drawing.Size(86, 22);
			this.rbServer.TabIndex = 0;
			this.rbServer.TabStop = true;
			this.rbServer.Text = "Сервер";
			this.rbServer.UseVisualStyleBackColor = true;
			// 
			// rbClient
			// 
			this.rbClient.AutoSize = true;
			this.rbClient.Location = new System.Drawing.Point(32, 76);
			this.rbClient.Name = "rbClient";
			this.rbClient.Size = new System.Drawing.Size(85, 22);
			this.rbClient.TabIndex = 1;
			this.rbClient.TabStop = true;
			this.rbClient.Text = "Клиент";
			this.rbClient.UseVisualStyleBackColor = true;
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStart.Location = new System.Drawing.Point(32, 134);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(124, 40);
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Запуск!";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblResult.Location = new System.Drawing.Point(251, 254);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(94, 25);
			this.lblResult.TabIndex = 7;
			this.lblResult.Text = "lblResult";
			this.lblResult.Visible = false;
			// 
			// tbxDebug
			// 
			this.tbxDebug.Location = new System.Drawing.Point(12, 293);
			this.tbxDebug.Multiline = true;
			this.tbxDebug.Name = "tbxDebug";
			this.tbxDebug.ReadOnly = true;
			this.tbxDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbxDebug.Size = new System.Drawing.Size(571, 154);
			this.tbxDebug.TabIndex = 8;
			// 
			// tbxAddress
			// 
			this.tbxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
			this.tbxAddress.Location = new System.Drawing.Point(32, 104);
			this.tbxAddress.Name = "tbxAddress";
			this.tbxAddress.Size = new System.Drawing.Size(124, 24);
			this.tbxAddress.TabIndex = 2;
			this.tbxAddress.Text = "127.0.0.1";
			this.tbxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbxAddress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxAddress_MouseDoubleClick);
			// 
			// timer
			// 
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// btnInstruct
			// 
			this.btnInstruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
			this.btnInstruct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInstruct.Location = new System.Drawing.Point(32, 180);
			this.btnInstruct.Name = "btnInstruct";
			this.btnInstruct.Size = new System.Drawing.Size(124, 40);
			this.btnInstruct.TabIndex = 4;
			this.btnInstruct.Text = "Инструкция";
			this.btnInstruct.UseVisualStyleBackColor = false;
			this.btnInstruct.Click += new System.EventHandler(this.btnInstruct_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
			this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnAbout.Location = new System.Drawing.Point(32, 226);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(124, 40);
			this.btnAbout.TabIndex = 5;
			this.btnAbout.Text = "Об игре";
			this.btnAbout.UseVisualStyleBackColor = false;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnPaper
			// 
			this.btnPaper.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPaper.Image = global::StoneScissors.Properties.Resources.paper;
			this.btnPaper.Location = new System.Drawing.Point(196, 168);
			this.btnPaper.Name = "btnPaper";
			this.btnPaper.Size = new System.Drawing.Size(387, 70);
			this.btnPaper.TabIndex = 8;
			this.btnPaper.Text = "Бумага";
			this.btnPaper.UseVisualStyleBackColor = false;
			this.btnPaper.UseWaitCursor = true;
			this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
			// 
			// btnScissors
			// 
			this.btnScissors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnScissors.Image = global::StoneScissors.Properties.Resources.scissors;
			this.btnScissors.Location = new System.Drawing.Point(196, 90);
			this.btnScissors.Name = "btnScissors";
			this.btnScissors.Size = new System.Drawing.Size(387, 70);
			this.btnScissors.TabIndex = 7;
			this.btnScissors.Text = "Ножницы";
			this.btnScissors.UseVisualStyleBackColor = false;
			this.btnScissors.UseWaitCursor = true;
			this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
			// 
			// btnStone
			// 
			this.btnStone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnStone.Image = global::StoneScissors.Properties.Resources.stone;
			this.btnStone.Location = new System.Drawing.Point(196, 14);
			this.btnStone.Name = "btnStone";
			this.btnStone.Size = new System.Drawing.Size(387, 70);
			this.btnStone.TabIndex = 6;
			this.btnStone.Text = "Камень";
			this.btnStone.UseVisualStyleBackColor = false;
			this.btnStone.UseWaitCursor = true;
			this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(233)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(597, 290);
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.btnInstruct);
			this.Controls.Add(this.tbxAddress);
			this.Controls.Add(this.tbxDebug);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.btnPaper);
			this.Controls.Add(this.btnScissors);
			this.Controls.Add(this.btnStone);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.rbClient);
			this.Controls.Add(this.rbServer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Камень, ножницы или бумага?";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbServer;
		private System.Windows.Forms.RadioButton rbClient;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStone;
		private System.Windows.Forms.Button btnScissors;
		private System.Windows.Forms.Button btnPaper;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.TextBox tbxDebug;
		private System.Windows.Forms.TextBox tbxAddress;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button btnInstruct;
		private System.Windows.Forms.Button btnAbout;
	}
}

