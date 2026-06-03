namespace mate22
{
	partial class Form1
	{
		
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			lblOperacion = new Label();
			lblNivel = new Label();
			lblTiempo = new Label();
			tabControlNiveles = new TabControl();
			tabPageNivel1 = new TabPage();
			tabPageNivel2 = new TabPage();
			tabPageNivel3 = new TabPage();
			tabPageNivel4 = new TabPage();
			panelNivel1 = new Panel();
			btnCarta1 = new Button();
			btnCarta2 = new Button();
			btnCarta3 = new Button();
			panelNivel2 = new Panel();
			btnCarta1_2 = new Button();
			btnCarta2_2 = new Button();
			btnCarta3_2 = new Button();
			panelNivel3 = new Panel();
			btnCarta1_3 = new Button();
			btnCarta2_3 = new Button();
			btnCarta3_3 = new Button();
			panelNivel4 = new Panel();
			btnCarta1_4 = new Button();
			btnCarta2_4 = new Button();
			btnCarta3_4 = new Button();
			timerOperacion = new System.Windows.Forms.Timer(components);
			lblContador = new Label();
			btnContinuar = new Button();
			btnLogout = new Button();
			tabControlNiveles.SuspendLayout();
			panelNivel1.SuspendLayout();
			panelNivel2.SuspendLayout();
			panelNivel3.SuspendLayout();
			panelNivel4.SuspendLayout();
			SuspendLayout();
			// 
			// lblOperacion
			// 
			lblOperacion.BackColor = Color.Transparent;
			lblOperacion.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblOperacion.Location = new Point(168, 10);
			lblOperacion.Name = "lblOperacion";
			lblOperacion.Size = new Size(499, 60);
			lblOperacion.TabIndex = 0;
			lblOperacion.Text = "Operacion";
			lblOperacion.TextAlign = ContentAlignment.MiddleCenter;
			lblOperacion.Click += lblOperacion_Click;
			// 
			// lblNivel
			// 
			lblNivel.AutoSize = true;
			lblNivel.BackColor = Color.Transparent;
			lblNivel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblNivel.Location = new Point(10, 10);
			lblNivel.Name = "lblNivel";
			lblNivel.Size = new Size(152, 28);
			lblNivel.TabIndex = 4;
			lblNivel.Text = "Nivel Actual: 1";
			// 
			// lblTiempo
			// 
			lblTiempo.AutoSize = true;
			lblTiempo.BackColor = Color.Transparent;
			lblTiempo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblTiempo.ForeColor = SystemColors.ControlText;
			lblTiempo.Location = new Point(673, 10);
			lblTiempo.Name = "lblTiempo";
			lblTiempo.Size = new Size(115, 28);
			lblTiempo.TabIndex = 6;
			lblTiempo.Text = "Tiempo: 5s";
			// 
			// tabControlNiveles
			// 
			tabControlNiveles.Controls.Add(tabPageNivel1);
			tabControlNiveles.Controls.Add(tabPageNivel2);
			tabControlNiveles.Controls.Add(tabPageNivel3);
			tabControlNiveles.Controls.Add(tabPageNivel4);
			tabControlNiveles.Location = new Point(50, 173);
			tabControlNiveles.Name = "tabControlNiveles";
			tabControlNiveles.SelectedIndex = 0;
			tabControlNiveles.Size = new Size(700, 250);
			tabControlNiveles.TabIndex = 0;
			// 
			// tabPageNivel1
			// 
			tabPageNivel1.Location = new Point(0, 0);
			tabPageNivel1.Name = "tabPageNivel1";
			tabPageNivel1.Size = new Size(200, 100);
			tabPageNivel1.TabIndex = 0;
			tabPageNivel1.Text = "Nivel 1: Sumas";
			// 
			// tabPageNivel2
			// 
			tabPageNivel2.Location = new Point(0, 0);
			tabPageNivel2.Name = "tabPageNivel2";
			tabPageNivel2.Size = new Size(200, 100);
			tabPageNivel2.TabIndex = 0;
			tabPageNivel2.Text = "Nivel 2: Multiplicaciones";
			// 
			// tabPageNivel3
			// 
			tabPageNivel3.Location = new Point(0, 0);
			tabPageNivel3.Name = "tabPageNivel3";
			tabPageNivel3.Size = new Size(200, 100);
			tabPageNivel3.TabIndex = 0;
			tabPageNivel3.Text = "Nivel 3: Divisiones";
			// 
			// tabPageNivel4
			// 
			tabPageNivel4.Location = new Point(0, 0);
			tabPageNivel4.Name = "tabPageNivel4";
			tabPageNivel4.Size = new Size(200, 100);
			tabPageNivel4.TabIndex = 1;
			tabPageNivel4.Text = "Nivel 4: Mixto";
			// 
			// panelNivel1
			// 
			panelNivel1.BackgroundImage = mateRe.Properties.Resources.Gemini_Generated_Image_jqfchrjqfchrjqfc;
			panelNivel1.BackgroundImageLayout = ImageLayout.Stretch;
			panelNivel1.Controls.Add(btnCarta1);
			panelNivel1.Controls.Add(btnCarta2);
			panelNivel1.Controls.Add(btnCarta3);
			panelNivel1.Location = new Point(50, 173);
			panelNivel1.Name = "panelNivel1";
			panelNivel1.Size = new Size(700, 250);
			panelNivel1.TabIndex = 5;
			panelNivel1.Paint += panelNivel1_Paint;
			// 
			// btnCarta1
			// 
			btnCarta1.BackgroundImage = mateRe.Properties.Resources.Gemini_Generated_Image_eqiic2eqiic2eqii;
			btnCarta1.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta1.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta1.Location = new Point(50, 25);
			btnCarta1.Name = "btnCarta1";
			btnCarta1.Size = new Size(150, 192);
			btnCarta1.TabIndex = 0;
			btnCarta1.Text = "0";
			btnCarta1.UseVisualStyleBackColor = true;
			// 
			// btnCarta2
			// 
			btnCarta2.BackgroundImage = mateRe.Properties.Resources.Gemini_Generated_Image_h4t6x1h4t6x1h4t6;
			btnCarta2.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta2.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta2.Location = new Point(269, 25);
			btnCarta2.Name = "btnCarta2";
			btnCarta2.Size = new Size(150, 192);
			btnCarta2.TabIndex = 1;
			btnCarta2.Text = "0";
			btnCarta2.UseVisualStyleBackColor = true;
			// 
			// btnCarta3
			// 
			btnCarta3.BackgroundImage = mateRe.Properties.Resources.Gemini_Generated_Image_v2878wv2878wv287;
			btnCarta3.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta3.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta3.Location = new Point(490, 25);
			btnCarta3.Name = "btnCarta3";
			btnCarta3.Size = new Size(150, 192);
			btnCarta3.TabIndex = 2;
			btnCarta3.Text = "0";
			btnCarta3.UseVisualStyleBackColor = true;
			// 
			// panelNivel2
			// 
			panelNivel2.Controls.Add(btnCarta1_2);
			panelNivel2.Controls.Add(btnCarta2_2);
			panelNivel2.Controls.Add(btnCarta3_2);
			panelNivel2.Location = new Point(50, 173);
			panelNivel2.Name = "panelNivel2";
			panelNivel2.Size = new Size(700, 250);
			panelNivel2.TabIndex = 6;
			panelNivel2.Visible = false;
			// 
			// btnCarta1_2
			// 
			btnCarta1_2.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta1_2.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta1_2.Location = new Point(50, 25);
			btnCarta1_2.Name = "btnCarta1_2";
			btnCarta1_2.Size = new Size(150, 186);
			btnCarta1_2.TabIndex = 0;
			btnCarta1_2.Text = "0";
			btnCarta1_2.UseVisualStyleBackColor = true;
			// 
			// btnCarta2_2
			// 
			btnCarta2_2.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta2_2.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta2_2.Location = new Point(270, 25);
			btnCarta2_2.Name = "btnCarta2_2";
			btnCarta2_2.Size = new Size(150, 186);
			btnCarta2_2.TabIndex = 1;
			btnCarta2_2.Text = "0";
			btnCarta2_2.UseVisualStyleBackColor = true;
			// 
			// btnCarta3_2
			// 
			btnCarta3_2.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta3_2.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta3_2.Location = new Point(490, 25);
			btnCarta3_2.Name = "btnCarta3_2";
			btnCarta3_2.Size = new Size(150, 186);
			btnCarta3_2.TabIndex = 2;
			btnCarta3_2.Text = "0";
			btnCarta3_2.UseVisualStyleBackColor = true;
			// 
			// panelNivel3
			// 
			panelNivel3.Controls.Add(btnCarta1_3);
			panelNivel3.Controls.Add(btnCarta2_3);
			panelNivel3.Controls.Add(btnCarta3_3);
			panelNivel3.Location = new Point(50, 173);
			panelNivel3.Name = "panelNivel3";
			panelNivel3.Size = new Size(700, 250);
			panelNivel3.TabIndex = 7;
			panelNivel3.Visible = false;
			// 
			// btnCarta1_3
			// 
			btnCarta1_3.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta1_3.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta1_3.Location = new Point(50, 21);
			btnCarta1_3.Name = "btnCarta1_3";
			btnCarta1_3.Size = new Size(150, 190);
			btnCarta1_3.TabIndex = 0;
			btnCarta1_3.Text = "0";
			btnCarta1_3.UseVisualStyleBackColor = true;
			// 
			// btnCarta2_3
			// 
			btnCarta2_3.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta2_3.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta2_3.Location = new Point(270, 21);
			btnCarta2_3.Name = "btnCarta2_3";
			btnCarta2_3.Size = new Size(150, 190);
			btnCarta2_3.TabIndex = 1;
			btnCarta2_3.Text = "0";
			btnCarta2_3.UseVisualStyleBackColor = true;
			// 
			// btnCarta3_3
			// 
			btnCarta3_3.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta3_3.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta3_3.Location = new Point(490, 21);
			btnCarta3_3.Name = "btnCarta3_3";
			btnCarta3_3.Size = new Size(150, 190);
			btnCarta3_3.TabIndex = 2;
			btnCarta3_3.Text = "0";
			btnCarta3_3.UseVisualStyleBackColor = true;
			// 
			// panelNivel4
			// 
			panelNivel4.Controls.Add(btnCarta1_4);
			panelNivel4.Controls.Add(btnCarta2_4);
			panelNivel4.Controls.Add(btnCarta3_4);
			panelNivel4.Location = new Point(50, 173);
			panelNivel4.Name = "panelNivel4";
			panelNivel4.Size = new Size(700, 250);
			panelNivel4.TabIndex = 8;
			panelNivel4.Visible = false;
			// 
			// btnCarta1_4
			// 
			btnCarta1_4.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta1_4.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta1_4.Location = new Point(50, 19);
			btnCarta1_4.Name = "btnCarta1_4";
			btnCarta1_4.Size = new Size(150, 192);
			btnCarta1_4.TabIndex = 0;
			btnCarta1_4.Text = "0";
			btnCarta1_4.UseVisualStyleBackColor = true;
			// 
			// btnCarta2_4
			// 
			btnCarta2_4.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta2_4.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta2_4.Location = new Point(269, 19);
			btnCarta2_4.Name = "btnCarta2_4";
			btnCarta2_4.Size = new Size(150, 192);
			btnCarta2_4.TabIndex = 1;
			btnCarta2_4.Text = "0";
			btnCarta2_4.UseVisualStyleBackColor = true;
			// 
			// btnCarta3_4
			// 
			btnCarta3_4.BackgroundImageLayout = ImageLayout.Stretch;
			btnCarta3_4.Font = new Font("Consolas", 14F, FontStyle.Bold);
			btnCarta3_4.Location = new Point(490, 19);
			btnCarta3_4.Name = "btnCarta3_4";
			btnCarta3_4.Size = new Size(150, 192);
			btnCarta3_4.TabIndex = 2;
			btnCarta3_4.Text = "0";
			btnCarta3_4.UseVisualStyleBackColor = true;
			// 
			// timerOperacion
			// 
			timerOperacion.Interval = 1000;
			timerOperacion.Tick += TimerOperacion_Tick;
			// 
			// lblContador
			// 
			lblContador.AutoSize = true;
			lblContador.BackColor = Color.Transparent;
			lblContador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblContador.Location = new Point(50, 38);
			lblContador.Name = "lblContador";
			lblContador.Size = new Size(57, 28);
			lblContador.TabIndex = 9;
			lblContador.Text = "0/10";
			// 
			// btnContinuar
			// 
			btnContinuar.BackColor = Color.Transparent;
			btnContinuar.Location = new Point(580, 101);
			btnContinuar.Name = "btnContinuar";
			btnContinuar.Size = new Size(120, 30);
			btnContinuar.TabIndex = 10;
			btnContinuar.Text = "Continuar";
			btnContinuar.UseVisualStyleBackColor = false;
			btnContinuar.Visible = false;
			// 
			// btnLogout
			// 
			btnLogout.BackColor = Color.Transparent;
			btnLogout.Location = new Point(680, 40);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(90, 26);
			btnLogout.TabIndex = 11;
			btnLogout.Text = "Cerrar sesión";
			btnLogout.UseVisualStyleBackColor = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(800, 450);
			Controls.Add(lblNivel);
			Controls.Add(lblTiempo);
			Controls.Add(lblOperacion);
			Controls.Add(lblContador);
			Controls.Add(btnContinuar);
			Controls.Add(btnLogout);
			Controls.Add(panelNivel1);
			Controls.Add(panelNivel2);
			Controls.Add(panelNivel3);
			Controls.Add(panelNivel4);
			DoubleBuffered = true;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "FastMind";
			tabControlNiveles.ResumeLayout(false);
			panelNivel1.ResumeLayout(false);
			panelNivel2.ResumeLayout(false);
			panelNivel3.ResumeLayout(false);
			panelNivel4.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblOperacion;
		private System.Windows.Forms.Label lblNivel;
		private System.Windows.Forms.Label lblTiempo;
		private System.Windows.Forms.Label lblContador;
		private System.Windows.Forms.Button btnContinuar;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Timer timerOperacion;
		private System.Windows.Forms.Panel panelNivel1;
		private System.Windows.Forms.Panel panelNivel2;
		private System.Windows.Forms.Panel panelNivel3;
		private System.Windows.Forms.Panel panelNivel4;
		private System.Windows.Forms.TabControl tabControlNiveles; // left for compatibility but not used visually
		private System.Windows.Forms.TabPage tabPageNivel1;
		private System.Windows.Forms.Button btnCarta1;
		private System.Windows.Forms.Button btnCarta2;
		private System.Windows.Forms.Button btnCarta3;
		private System.Windows.Forms.TabPage tabPageNivel2;
		private System.Windows.Forms.Button btnCarta1_2;
		private System.Windows.Forms.Button btnCarta2_2;
		private System.Windows.Forms.Button btnCarta3_2;
		private System.Windows.Forms.TabPage tabPageNivel3;
		private System.Windows.Forms.TabPage tabPageNivel4;
		private System.Windows.Forms.Button btnCarta1_3;
		private System.Windows.Forms.Button btnCarta2_3;
		private System.Windows.Forms.Button btnCarta3_3;
		private System.Windows.Forms.Button btnCarta1_4;
		private System.Windows.Forms.Button btnCarta2_4;
		private System.Windows.Forms.Button btnCarta3_4;
	}
}
